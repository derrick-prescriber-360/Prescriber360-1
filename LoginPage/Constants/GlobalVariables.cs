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
		public static string AuthToken = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsIng1dCI6Il9VZ3FYR190TUxkdVNKMVQ4Y2FIeFU3Y090YyIsImtpZCI6Il9VZ3FYR190TUxkdVNKMVQ4Y2FIeFU3Y090YyJ9.eyJhdWQiOiJodHRwczovL29wcmVzY3JpYmVyMzYwLmNybS5keW5hbWljcy5jb20iLCJpc3MiOiJodHRwczovL3N0cy53aW5kb3dzLm5ldC8yZjI2N2I0Mi03MDc0LTQzZDctOTI3Zi02Y2Q1YzJiYTQyNzUvIiwiaWF0IjoxNDg5MDcyNzk5LCJuYmYiOjE0ODkwNzI3OTksImV4cCI6MTQ4OTA3NjY5OSwiYWNyIjoiMSIsImFpbyI6Ik5BIiwiYW1yIjpbInB3ZCJdLCJhcHBpZCI6IjVlYmIyOTI0LWY2NTgtNGIxYi05Zjk2LWVjZjBmNjVjYWZiMyIsImFwcGlkYWNyIjoiMCIsImVfZXhwIjoxMDgwMCwiZmFtaWx5X25hbWUiOiJMYWhvdGkiLCJnaXZlbl9uYW1lIjoiU291cmF2IiwiaXBhZGRyIjoiMTAzLjI1MS44MS41MSIsIm5hbWUiOiJTb3VyYXYgTGFob3RpIiwib2lkIjoiODAyNTI2ZTUtMzJiMC00NDQxLTgyZWItMDgxMjQ5Y2RmYjUxIiwicGxhdGYiOiIyIiwicHVpZCI6IjEwMDMwMDAwOURFNDIwQjUiLCJzY3AiOiJ1c2VyX2ltcGVyc29uYXRpb24iLCJzdWIiOiJzNUQyQ0k0VjNsX0h3dG80ZlJkdWFUcS15dHZMUlV0UFVJOWQtMC0tVk9FIiwidGlkIjoiMmYyNjdiNDItNzA3NC00M2Q3LTkyN2YtNmNkNWMyYmE0Mjc1IiwidW5pcXVlX25hbWUiOiJzb3VyYXYubGFob3RpQHByZXNjcmliZXIzNjAuY29tIiwidXBuIjoic291cmF2LmxhaG90aUBwcmVzY3JpYmVyMzYwLmNvbSIsInZlciI6IjEuMCJ9.5U-WxNlm1JXelTlPitfZmX1IzTtQHnvi1l9oIYniD1C6YXWOueek1ny6So6-dAExl524lw-FEW9W5zgxd_HLSNGX79BHJuHyOBYd1lO2Ho6P-zla8AXEL1VUErPfZcyghEX-vSqz6wOUG1cSNCzll_thMR2VR1vvzQJGB3xTN9IE8TpmLJEI8PpchBJ8uKbJocAk_8WgDk11AiqUVp7SsulSioLdzEWCqybU2Bb-zZKOFaUjzKjGxlc2PA1q1lnnf8ciN46ZMB1HIRPnFVAcW_fZIcjHjuO4MYgaCAVozgXyZa15bYaCBnFxj3pif3F2Z2hLWHnczWtRuxVfE7cnuw";
	}
}
