using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LoginPage
{
	public partial class CustomerDetailPage : ContentPage
	{
		Prescriber contact;

		private PrescriberViewModel ViewModel { get { return BindingContext as PrescriberViewModel; } }
		public CustomerDetailPage()
		{
			InitializeComponent();
		}

		public CustomerDetailPage(Prescriber contact)
		{
			this.contact = contact;
			InitializeComponent();
			this.firstName.Text = contact.firstname;
			this.lastName.Text = contact.lastname;

		}
	}
}
