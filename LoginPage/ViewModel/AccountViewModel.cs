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
		private ObservableCollection<Account> _filteredaccountcontactlist = new ObservableCollection<Account>();
		private List<Account> _accountcontactlist = new List<Account>();
		private Account _selectedaccountContact;
		private INavigation _navigation;

		public event PropertyChangedEventHandler PropertyChanged;
		public AccountViewModel() { }
		public AccountViewModel(INavigation navigation)
		{
			if ((GlobalVariables.GlobalAccountList == null) || (GlobalVariables.GlobalAccountList.Count == 0))
				Initialize();
			else
			{
				foreach (var c in GlobalVariables.GlobalAccountList)
				{
					AccountContactList.Add(c);
					_accountcontactlist.Add(c);
				}
			}
			_navigation = navigation;
		}

		public ObservableCollection<Account> AccountContactList
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
				foreach (var c in _accountcontactlist)
				{
					AccountContactList.Add(c);
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

		public async Task<List<Account>> GetAccountContactList()
		{
			try
			{
				jsonData = await repository.Retrieve(GlobalVariables.AuthToken, "accounts", "");
				var contactdata = JsonConvert.DeserializeObject<AccountContactList>(jsonData.ToString());
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
				AccountContactList.Clear();
				foreach (var c in _accountcontactlist)
				{
					if (c.fullname.ToLower().Contains(text.ToLower()))
					{
						AccountContactList.Add(c);
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
