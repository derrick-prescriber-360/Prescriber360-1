using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.IO;

namespace LoginPage
{
	public class Repository
	{
		JObject jResult;
		public async Task<JObject> Retrieve(string accessToken, string entity, string queryparams)
		{
			// The URL for the OData organization web service.
			string url = GlobalVariables.RootUrl + GlobalVariables.EndPoint + entity + queryparams;

			// Build and send the HTTP request.
			HttpClient httpClient = new HttpClient();
			httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
			HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Get, url);
			req.Method = HttpMethod.Get;

			// Wait for the web service response.
			HttpResponseMessage response;
			response = await httpClient.SendAsync(req);
			var responseBodyAsText = await response.Content.ReadAsStringAsync();
			jResult = JObject.Parse(responseBodyAsText);
			Debug.WriteLine("entity");
			Debug.WriteLine(jResult);
			return jResult;
		}


		public async Task<JObject> Create(string accessToken, string entity, JObject data)
		{
			//dynamic jsonObject = new JObject();
			//jsonObject.mobilephone = "9038379779";
			// The URL for the OData organization web service.
			string url = GlobalVariables.RootUrl + GlobalVariables.EndPoint + entity;

			var content = new StringContent(data.ToString(), Encoding.UTF8, "application/json");
			// Build and send the HTTP request.
			HttpClient httpClient = new HttpClient();
			httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

			// Wait for the web service response.
			HttpResponseMessage response;
			response = await httpClient.PostAsync(url, content);
			var responseBodyAsText = await response.Content.ReadAsStringAsync();
			System.Diagnostics.Debug.WriteLine(responseBodyAsText);
			jResult = JObject.Parse(responseBodyAsText);
			return jResult;
		}


		public async Task<JObject> Update(string accessToken, string entity, JObject data, string id)
		{
			
			//oprescriber360.crm.dynamics.com/api/data/v8.1/contacts(cbe50e62-cfee-e611-8101-fc15b4282658)}
				  // The URL for the OData organization web service.
			string url = GlobalVariables.RootUrl + GlobalVariables.EndPoint + entity +"("+id+")?";
			dynamic jsonObject = new JObject();
			jsonObject.mobilephone = "9898989898";
			var content = new StringContent(jsonObject.ToString(), Encoding.UTF8, "application/json");
			// Build and send the HTTP request.
			HttpClient httpClient = new HttpClient();
			httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

			// Wait for the web service response.
			HttpResponseMessage response;
			response = await HttpRequest.PatchAsync(httpClient,url, content);
			var responseBodyAsText = await response.Content.ReadAsStringAsync();
			System.Diagnostics.Debug.WriteLine(responseBodyAsText);
			jResult = JObject.Parse(responseBodyAsText);
			return jResult;
		}

	}
}
