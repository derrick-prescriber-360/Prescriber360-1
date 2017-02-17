using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using UIKit;
using Xamarin.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.Diagnostics;

[assembly: Dependency(typeof(LoginPage.iOS.AuthenticationService))]
namespace LoginPage.iOS
{
	public class AuthenticationService : IAuthenticator
	{
		public async Task<AuthenticationResult> Authenticate(string authority, string resource, string clientId, string returnUri)
		{
			try
			{

				var authContext = new AuthenticationContext(authority);
				if (authContext.TokenCache.ReadItems().Any())
					authContext = new AuthenticationContext(authContext.TokenCache.ReadItems().First().Authority);

				var controller = UIApplication.SharedApplication.KeyWindow.RootViewController;
				var uri = new Uri(returnUri);
				var platformParams = new PlatformParameters(controller);
				var authResult = await authContext.AcquireTokenAsync(resource, clientId, uri, platformParams);
				return authResult;
			}
			catch (Exception err)
			{
				GlobalVariables.Errors = err.Message;
				return null;
			}

		}
	}
}
