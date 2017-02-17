using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LoginPage
{
	public partial class CutomerListPage : MasterDetailPage
	{
		public CutomerListPage()
		{
			InitializeComponent();
			IsPresented = true;
		}

		void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			Detail = new NavigationPage(new CustomerDetailPage(contactCustomerList.SelectedItem as Prescriber));
		}
	}
}
