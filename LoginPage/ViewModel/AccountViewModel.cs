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
			Debug.WriteLine("Account view model Consturctor called");
			if ((GlobalVariables.GlobalAccountList == null) || (GlobalVariables.GlobalAccountList.Count == 0))
			{
				Initialize();
				Debug.WriteLine("Initialize called");
			}
			else
			{
				foreach (var c in GlobalVariables.GlobalAccountList)
				{
					ContactList.Add(c);
					_accountcontactlist.Add(c);
				}
				Debug.WriteLine("Account view model else called");
			}
			_navigation = navigation;
		}

		public ObservableCollection<Account> ContactList
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
					ContactList.Add(c);
					GlobalVariables.GlobalAccountList.Add(c);
				}

			}
			catch (Exception err)
			{
				Debug.WriteLine(err.Message);
			}
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
				ContactList.Clear();
				foreach (var c in _accountcontactlist)
				{
					if (c.fullname.ToLower().Contains(text.ToLower()))
					{
						ContactList.Add(c);
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
