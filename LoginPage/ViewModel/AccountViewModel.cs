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
	public class AccountViewModel
	{
		private JObject jsonData = null;
		private Repository repository = new Repository();
		private ObservableCollection<Prescriber> _filteredaccountcontactlist = new ObservableCollection<Prescriber>();
		private List<Prescriber> _accountcontactlist = new List<Prescriber>();
		private List<Prescriber> _prescribercontactlist = new List<Prescriber>();
		private Account _selectedaccountContact;
		private INavigation _navigation;

		public event PropertyChangedEventHandler PropertyChanged;
		public AccountViewModel() { }
		public AccountViewModel(INavigation navigation)
		{
			if ((GlobalVariables.GlobalContactList == null) || (GlobalVariables.GlobalContactList.Count == 0))
				Initialize();
			else
			{
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
				return _filteredaccountcontactlist;
			}
			set
			{
				_filteredaccountcontactlist = value;
				OnPropertyChanged("AccountContactList");
			}
		}


		public Account SelectedAccountContact
		{
			get { return _selectedaccountContact; }
			set
			{
				_selectedaccountContact = value;
				OnPropertyChanged("SelectedAccountContact");
			}
		}

		public async void Initialize()
		{
			try
			{
				_accountcontactlist = await GetAccountContactList();
				_prescribercontactlist = await GetPrescribersContactList();
				foreach (var c in _accountcontactlist)
				{
					PrescriberContactList.Add(c);
				}

				foreach (var c in _prescribercontactlist)
				{
					PrescriberContactList.Add(c);
				}
			}
			catch (Exception err)
			{
				Debug.WriteLine(err.Message);
			}
			//_copycontactlist = ContactList;
			//Contact contact = new Contact();
			//contact.firstname = "test";
			//List<Contact> t = new List<Contact>();
			//t.Add(contact);
			//ContactList = t;
		}

		public async Task<List<Prescriber>> GetAccountContactList()
		{
			try
			{
				jsonData = await repository.Retrieve(GlobalVariables.AuthToken, "accounts", "");
				var contactdata = JsonConvert.DeserializeObject<PrescriberContactList>(jsonData.ToString());
				return contactdata.value;
			}
			catch (Exception err)
			{
				Debug.WriteLine(err.Message);
			}

			return null;
		}

		public async Task<List<Prescriber>> GetPrescribersContactList()
		{
			try
			{
				Debug.WriteLine("Prescriber");
				jsonData = await repository.Retrieve(GlobalVariables.AuthToken, "contacts", "");
				var contactdata = JsonConvert.DeserializeObject<PrescriberContactList>(jsonData.ToString());
				Debug.WriteLine(jsonData);
				return contactdata.value;
			}
			catch (Exception err)
			{
				Debug.WriteLine(err.Message);
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
				foreach (var c in _accountcontactlist)
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
