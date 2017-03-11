using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Clients.ActiveDirectory;

namespace LoginPage
{
	public interface IAuthenticator
	{
		Task<AuthenticationResult> Authenticate(string authority, string resource, string clientId, string returnUri);
		void RequestAccess();
	}
}
