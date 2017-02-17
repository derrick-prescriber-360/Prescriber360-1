using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System;
using System.Globalization;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LoginPage
{
	public partial class LoginPage : ContentPage
	{
		public JObject jResult = null;
		public JObject jsonData = null;

		public LoginPage()
		{
			InitializeComponent();
		}

		public async void Login_Clicked(object sender, System.EventArgs e)
		{
			await Authenticate();
		}

		public async Task Authenticate()
		{
			var authenticationService = DependencyService.Get<IAuthenticator>();

			try
			{
				var authenticationResult = await authenticationService.Authenticate(
					AuthParamters.Authority,
					AuthParamters.CRMResourceUri,
					AuthParamters.ApplicationId,
					AuthParamters.ReturnUri);
				GlobalVariables.AuthToken = authenticationResult.AccessToken;
				Debug.WriteLine(GlobalVariables.AuthToken);
				await Navigation.PopAsync();
				await Navigation.PushModalAsync(new Welcome() {
					Title = "Prescriber360"
				});

			}
			catch(Exception err)
			{
				Debug.WriteLine(err.Message);
				await DisplayAlert("Failure", "Authentication failed.", "Ok");
			}
		}
	}
}
