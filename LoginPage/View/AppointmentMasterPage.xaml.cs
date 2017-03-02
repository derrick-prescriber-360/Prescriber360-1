using System;
using System.Diagnostics;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LoginPage
{
	public partial class AppointmentMasterPage : MasterDetailPage
	{
		private AppointmentViewModel ViewModel { get { return BindingContext as AppointmentViewModel; } }
		public AppointmentMasterPage()
		{
			InitializeComponent();
			IsPresented = true;
			BindingContext = new AppointmentViewModel(this.Navigation);
		}

		void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			Detail = new NavigationPage(new AppointmentDetailsPage(appointmentList.SelectedItem as Appointment));
		}

		void Handle_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
		{
			try
			{
				ViewModel.FilterContactList(appointmentName.Text);
			}
			catch (Exception err)
			{
				Debug.WriteLine(err.Message);
			}
		}
	}
}
