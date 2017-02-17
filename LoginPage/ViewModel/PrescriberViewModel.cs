using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Linq;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace LoginPage
{
	public class PrescriberViewModel : INotifyPropertyChanged
	{
		private JObject jsonData = null;
		private Repository repository = new Repository();
		private ObservableCollection<Prescriber> _filteredprescribercontactlist = new ObservableCollection<Prescriber>();
		private List<Prescriber> _prescribercontactlist = new List<Prescriber>();
		private Prescriber _selectedprescriberContact;
		private INavigation _navigation;
		private bool isBusy;
		private ILoginManager _ilm;

		public event PropertyChangedEventHandler PropertyChanged;
		public PrescriberViewModel() { }
		public PrescriberViewModel(INavigation navigation)
		{
			if ((GlobalVariables.GlobalContactList == null) || (GlobalVariables.GlobalContactList.Count == 0))
				Initialize();
			else {
				foreach (var c in GlobalVariables.GlobalContactList)
				{
					PrescriberContactList.Add(c);
					_prescribercontactlist.Add(c);
				}
			}
			_navigation = navigation;
		}

		public ObservableCollection<Prescriber> PrescriberContactList
		{
			get
			{
				return _filteredprescribercontactlist;
			}
			set
			{
				_filteredprescribercontactlist = value;
				OnPropertyChanged("PrescriberContactList");
			}
		}


		public Prescriber SelectedPrescriberContact
		{
			get { return _selectedprescriberContact; }
			set
			{
				_selectedprescriberContact = value;
				OnPropertyChanged("SelectedPrescriberContact");
			}
		}

		public bool IsBusy
		{
			get
			{
				return isBusy;
			}

			set
			{
				isBusy = value;
				OnPropertyChanged("IsBusy");
			}
		}

		public ILoginManager Ilm
		{
			get
			{
				return _ilm;
			}

			set
			{
				_ilm = value;
			}
		}

		public async void Initialize()
		{
			try
			{
				IsBusy = true;
				_prescribercontactlist = await GetPrescriberContactList();

				foreach (var c in _prescribercontactlist)
				{
					PrescriberContactList.Add(c);
					GlobalVariables.GlobalContactList.Add(c);
				}
				IsBusy = false;
			}

			catch (Exception err)
			{
				IsBusy = false;
				Debug.WriteLine(err.Message);
			}
			//_copycontactlist = ContactList;
			//Contact contact = new Contact();
			//contact.firstname = "test";
			//List<Contact> t = new List<Contact>();
			//t.Add(contact);
			//ContactList = t;
		}

		public async Task<List<Prescriber>> GetPrescriberContactList()
		{
			try
			{
				jsonData = await repository.Retrieve(GlobalVariables.AuthToken, "contacts", "");
				var contactdata = JsonConvert.DeserializeObject<PrescriberContactList>(jsonData.ToString());
				return contactdata.value;
			}
			catch (Exception err)
			{
				Debug.WriteLine(err.Message);
				//await _navigation.PushModalAsync(new SignInPage());

			}

			return null;
		}

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this,
					new PropertyChangedEventArgs(propertyName));
			}
		}


		public void FilterContactList(string text)
		{
			try
			{
				PrescriberContactList.Clear();
				foreach (var c in _prescribercontactlist)
				{
					if (c.fullname.ToLower().Contains(text.ToLower()))
					{
						PrescriberContactList.Add(c);
					}
				}
			}
			catch (Exception err)
			{
				Debug.WriteLine(err.Message);
			}

		}

	}
}
