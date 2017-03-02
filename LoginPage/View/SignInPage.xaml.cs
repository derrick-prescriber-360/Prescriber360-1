using Newtonsoft.Json.Linq;
using Xamarin.Forms;
using System;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LoginPage
{
	public partial class SignInPage : ContentPage
	{
		public JObject jResult = null;
		public JObject jsonData = null;
		public ILoginManager _ilm;

		public SignInPage(ILoginManager ilm)
		{
			InitializeComponent();
			_ilm = ilm;
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
				isBusy.IsRunning = true;
				isBusy.IsVisible = true;
				isBusy.Color = Color.Gray;
				var authenticationResult = await authenticationService.Authenticate(
					AuthParamters.Authority,
					AuthParamters.CRMResourceUri,
					AuthParamters.ApplicationId,
					AuthParamters.ReturnUri);
				GlobalVariables.AuthToken = authenticationResult.AccessToken;
				Debug.WriteLine(GlobalVariables.AuthToken);
				App.Current.Properties["IsLoggedIn"] = true;
				Debug.WriteLine(_ilm);
				_ilm.ShowMainPage();
				isBusy.IsRunning = false;
				//isBusy.IsVisible = false;
			}
			catch (Exception err)
			{
				Debug.WriteLine(err.Message);
				await DisplayAlert("Failure", "Authentication failed.", "Ok");
				isBusy.IsRunning = false;
				isBusy.IsVisible = false;
			}
		}
	}
}
