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

namespace LoginPage
{
	public class ContactViewModel :INotifyPropertyChanged
	{
		private JObject jsonData = null;
		private Repository repository = new Repository();
		private ObservableCollection<Prescriber> _filteredcontactlist = new ObservableCollection<Prescriber>();
		private List<Prescriber> _contactlist = new List<Prescriber>();
		private Prescriber _selectedContact;

		public event PropertyChangedEventHandler PropertyChanged;

		public ContactViewModel() 
		{
			Initialize();
		}

		public ObservableCollection<Prescriber> ContactList
		{
			get 
			{
				return _filteredcontactlist;
			}
			set 
			{
				_filteredcontactlist = value;
				OnPropertyChanged("ContactList");
			}
		}


		public Prescriber SelectedContact
		{
			get { return _selectedContact; }
			set
			{
				_selectedContact = value;
				OnPropertyChanged("SelectedContact");
			}
		}

		public async void Initialize()
		{
			try
			{
				_contactlist = await GetContactList();
				foreach (var c in _contactlist)
				{
					ContactList.Add(c);
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

		public async Task<List<Prescriber>> GetContactList()
		{
			try
			{
				jsonData = await repository.Retrieve(GlobalVariables.AuthToken, "contacts", "");
				var contactdata = JsonConvert.DeserializeObject<ContactList>(jsonData.ToString());
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
				ContactList.Clear();
				foreach (var c in _contactlist)
				{
					if (c.fullname.ToLower().Contains(text.ToLower()))
					{
						ContactList.Add(c);
					}
				}
			}
			catch (Exception err){
				Debug.WriteLine(err.Message);
			}

		}

	}
}
