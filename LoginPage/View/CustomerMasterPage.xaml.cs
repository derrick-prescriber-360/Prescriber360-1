using System;
using System.Collections.Generic;
using System.Diagnostics;

using Xamarin.Forms;

namespace LoginPage
{
	public partial class CustomerMasterPage : MasterDetailPage
	{
		private PrescriberViewModel ViewModel { get { return BindingContext as PrescriberViewModel; } }

		public CustomerMasterPage()
		{
			InitializeComponent();
			IsPresented = true;
			BindingContext = new PrescriberViewModel(this.Navigation);
		}

		void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			var t = contactCustomerList.SelectedItem as Prescriber;
			Debug.WriteLine(t.firstname);
			Detail = new NavigationPage(new CustomerDetailPage(contactCustomerList.SelectedItem as Prescriber));
		}

		void Handle_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
		{
			try
			{
				ViewModel.FilterContactList(contactName.Text);
			}
			catch (Exception err)
			{
				Debug.WriteLine(err.Message);
			}
		}
	}
}
