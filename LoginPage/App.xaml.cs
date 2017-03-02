using Xamarin.Forms;
using System.Diagnostics;

namespace LoginPage
{
	public partial class App : Application, ILoginManager
	{
		public App()
		{
			InitializeComponent();

			var isLoggedIn = Properties.ContainsKey("IsLoggedIn") ? (bool)Properties["IsLoggedIn"] : false;

			// we remember if they're logged in, and only display the login page if they're not
			if (isLoggedIn)
				MainPage = new NavigationPage(new Welcome());
			else {
				MainPage = new LoginModalPage(this);
			}
		}

		public void ShowMainPage()
		{
			Debug.WriteLine("I am called ShowMainPage");
			var welcomePage = new NavigationPage(new Welcome());
			//welcomePage.BarBackgroundColor = Color.FromHex("77D065");
			//welcomePage.BarTextColor = Color.White;
			//welcomePage.Title = "Prescriber360";
			MainPage = welcomePage;

		}

		public void Logout()
		{
			Properties["IsLoggedIn"] = false; // only gets set to 'true' on the LoginPage
			MainPage = new LoginModalPage(this);
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
