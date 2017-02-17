using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LoginPage
{
	public static class HttpRequest
	{
		public static async Task<HttpResponseMessage> PatchAsync(HttpClient client, string requestUri, StringContent content)
		{
			var method = new HttpMethod("PATCH");

			var request = new HttpRequestMessage(method, requestUri)
			{
				Content = content
			};

			HttpResponseMessage response = new HttpResponseMessage();
			try
			{
				response = await client.SendAsync(request);
			}
			catch (TaskCanceledException e)
			{
				Debug.WriteLine("ERROR: " + e.ToString());
			}

			return response;
		}
	}
}
