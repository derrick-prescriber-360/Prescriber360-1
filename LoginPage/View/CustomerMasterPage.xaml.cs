using System;
using System.Collections.Generic;
using System.Diagnostics;

using Xamarin.Forms;

namespace LoginPage
{
	public partial class CustomerMasterPage : MasterDetailPage
	{
		private PrescriberViewModel prescriberViewModel { get { return BindingContext as PrescriberViewModel; } }
		private AccountViewModel accountViewModel { get { return BindingContext as AccountViewModel; } }
		private bool isHCP = true;


		public CustomerMasterPage()
		{
			InitializeComponent();
			IsPresented = true;
			BindingContext = new PrescriberViewModel(this.Navigation);
			this.hcp.BackgroundColor = Color.FromHex("77D065");
			this.hcp.TextColor = Color.White;
		}

		public CustomerMasterPage(Prescriber contact)
		{
			InitializeComponent();
			IsPresented = true;
			BindingContext = new PrescriberViewModel(this.Navigation);
			Detail = new NavigationPage(new CustomerDetailPage(contact as Prescriber));
			this.hcp.BackgroundColor = Color.FromHex("77D065");
			this.hcp.TextColor = Color.White;
		}

		void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			if (isHCP)
				Detail = new NavigationPage(new CustomerDetailPage(contactCustomerList.SelectedItem as Prescriber));
			else
				Detail = new NavigationPage(new CustomerDetailPage(contactCustomerList.SelectedItem as Account));
		}

		void Handle_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
		{
			try
			{
				if (isHCP)
				{ prescriberViewModel.FilterContactList(contactName.Text); }
				else { accountViewModel.FilterContactList(contactName.Text); }
			}
			catch (Exception err)
			{
				Debug.WriteLine(err.Message);
			}
		}

		void HCP_Handle_Clicked(object sender, System.EventArgs e)
		{
			this.hco.BackgroundColor = Color.White;
			this.hco.TextColor = Color.Black;
			this.hcp.BackgroundColor = Color.FromHex("77D065");
			this.hcp.TextColor = Color.White;
			BindingContext = new PrescriberViewModel(this.Navigation);
			isHCP = true;
			contactName.Text = "";
		}

		void HCO_Handle_Clicked(object sender, System.EventArgs e)
		{
			this.hco.BackgroundColor = Color.FromHex("77D065");
			this.hco.TextColor = Color.White;
			this.hcp.BackgroundColor = Color.White;
			this.hcp.TextColor = Color.Black;
			BindingContext = new AccountViewModel(this.Navigation);
			isHCP = false;
			contactName.Text = "";
		}
	}
}
