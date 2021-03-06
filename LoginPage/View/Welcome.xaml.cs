﻿using System;
using System.Collections.Generic;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Xamarin.Forms;
using System.Diagnostics;
using Rg.Plugins.Popup.Extensions;

namespace LoginPage
{
	public partial class Welcome : ContentPage
	{
		public Welcome()
		{
			InitializeComponent();
			BindingContext = new PrescriberViewModel(this.Navigation);
			////Add both contacts and accounts below correction with int type of country code
			//new AccountViewModel(this.Navigation);
			//new AppointmentViewModel(this.Navigation);
		}

		private PrescriberViewModel ViewModel { get { return BindingContext as PrescriberViewModel; } }

		public void Handle_TextChanged_ContactList(object sender, Xamarin.Forms.TextChangedEventArgs e)
		{
			if (contactName.Text.Length > 0)
			{
				contactList.IsVisible = true;
				ViewModel.FilterContactList(contactName.Text);
			}
			else
			{
				contactList.IsVisible = false;
			}
		}

		public async void Handle_ItemTapped_Selected_Contact(object sender, Xamarin.Forms.ItemTappedEventArgs e)
		{
			if (contactList.SelectedItem == null)
				return;
			Prescriber selectedContact = contactList.SelectedItem as Prescriber;
			contactList.SelectedItem = null;
			contactName.Text = selectedContact.fullname;
			contactList.IsVisible = false;
			await Navigation.PushAsync(new CustomerMasterPage(selectedContact)
			{
				Title = "Prescriber360"
			});
		}

		async void Handle_Customer_Navigation(object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new CustomerMasterPage()
			{
				Title = "Prescriber360"
			});

		}

		async void Handle_Appointment_Navigation(object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new AppointmentMasterPage()
			{
				Title = "Prescriber360"
			});

		}

		void Handle_Report_Navigation(object sender, System.EventArgs e)
		{
			Debug.WriteLine("Pop up called");

		}
	}
}
