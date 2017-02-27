using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LoginPage
{
	public partial class AppointmentDetailsPage : ContentPage
	{
		Appointment appointment;

		private AppointmentViewModel ViewModel { get { return BindingContext as AppointmentViewModel; } }
		public AppointmentDetailsPage()
		{
			InitializeComponent();
		}

		public AppointmentDetailsPage(Appointment appointment)
		{
			this.appointment = appointment;
			InitializeComponent();
		}
	}
}
