using System;
using Xamarin.Forms;

namespace LoginPage
{
	public class LoginModalPage : CarouselPage
	{
		ContentPage login;
		public LoginModalPage(ILoginManager ilm)
		{
			login = new SignInPage(ilm);
			this.Children.Add(login);
		}
	}
}