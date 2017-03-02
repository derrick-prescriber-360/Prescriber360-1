using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace LoginPage
{
	public static class GlobalVariables
	{
		public static string FirstName { get; set; }
		public static string LastName { get; set; }
		public static string IdentityProvider { get; set; }
		public static string Errors { get; set; }

		public static List<Prescriber> GlobalContactList
		{
			get
			{
				return globalContactList;
			}

			set
			{
				globalContactList = value;
			}
		}

		public static List<Account> GlobalAccountList
		{
			get
			{
				return globalAccountList;
			}

			set
			{
				globalAccountList = value;
			}
		}


		public static List<Appointment> GlobalAppointmentList
		{
			get
			{
				return globalAppointmentList;
			}

			set
			{
				globalAppointmentList = value;
			}
		}

		public static string RootUrl = "https://oprescriber360.crm.dynamics.com";
		public static string EndPoint = "/api/data/v8.1/";
		private static List<Prescriber> globalContactList = new List<Prescriber>();
		private static List<Account> globalAccountList = new List<Account>();
		private static List<Appointment> globalAppointmentList = new List<Appointment>();
		//public static string AuthToken { get; set; }
		public static string AuthToken = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsIng1dCI6Il9VZ3FYR190TUxkdVNKMVQ4Y2FIeFU3Y090YyIsImtpZCI6Il9VZ3FYR190TUxkdVNKMVQ4Y2FIeFU3Y090YyJ9.eyJhdWQiOiJodHRwczovL29wcmVzY3JpYmVyMzYwLmNybS5keW5hbWljcy5jb20iLCJpc3MiOiJodHRwczovL3N0cy53aW5kb3dzLm5ldC8yZjI2N2I0Mi03MDc0LTQzZDctOTI3Zi02Y2Q1YzJiYTQyNzUvIiwiaWF0IjoxNDg3MjY3MjM2LCJuYmYiOjE0ODcyNjcyMzYsImV4cCI6MTQ4NzI3MTEzNiwiYWNyIjoiMSIsImFtciI6WyJwd2QiXSwiYXBwaWQiOiI1ZWJiMjkyNC1mNjU4LTRiMWItOWY5Ni1lY2YwZjY1Y2FmYjMiLCJhcHBpZGFjciI6IjAiLCJlX2V4cCI6MTA4MDAsImZhbWlseV9uYW1lIjoiTGFob3RpIiwiZ2l2ZW5fbmFtZSI6IlNvdXJhdiIsImlwYWRkciI6IjEwMy4yNTEuODEuMTI0IiwibmFtZSI6IlNvdXJhdiBMYWhvdGkiLCJvaWQiOiI4MDI1MjZlNS0zMmIwLTQ0NDEtODJlYi0wODEyNDljZGZiNTEiLCJwbGF0ZiI6IjIiLCJwdWlkIjoiMTAwMzAwMDA5REU0MjBCNSIsInNjcCI6InVzZXJfaW1wZXJzb25hdGlvbiIsInN1YiI6InM1RDJDSTRWM2xfSHd0bzRmUmR1YVRxLXl0dkxSVXRQVUk5ZC0wLS1WT0UiLCJ0aWQiOiIyZjI2N2I0Mi03MDc0LTQzZDctOTI3Zi02Y2Q1YzJiYTQyNzUiLCJ1bmlxdWVfbmFtZSI6InNvdXJhdi5sYWhvdGlAcHJlc2NyaWJlcjM2MC5jb20iLCJ1cG4iOiJzb3VyYXYubGFob3RpQHByZXNjcmliZXIzNjAuY29tIiwidmVyIjoiMS4wIn0.U2x-ttxVJwzucwWtlSeX-_x51LMp5ts-VWxlAxVbh0SGxqIRAgEHtxo0cRh0fAV4d1fxLxe7hmKHRhuNgs_zK-XuJi88IhkzAngqNoWTg3o-IAB8yqjCA9RibfFM5yCuRNuCn5ielk2V7FZCfvFisDMfuhS9PFolwtU-UXby0zFvguzD1LwUGgs9-fNrUGVotxBMV6hoj-Gbabt7xVB_4KEVjHUaNqdto4o4qh9vRTQEUc9CqjifPYRFb6hultfl189bNvf-B7qOYwwHgXkHE_6Qyu2gylfjb-Wys_wAAHMRXmaY8aj1vKe-XwkHvnnKhbmT6mJffy03Mr-JJ6NbrQ";
	}
}
