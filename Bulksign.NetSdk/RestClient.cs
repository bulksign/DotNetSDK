using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Bulksign.Api
{
	internal class RestClient
	{
		private string endpointUrl = string.Empty;
		private HttpClient hp;


		public RestClient(string url, int timeout)
		{

			this.endpointUrl = url;

			hp = new HttpClient();
			hp.Timeout = new TimeSpan(0, 0, timeout);
		}


		public async Task<string> SendRequestAsync(AuthorizationApiModel authorization, string methodName, string jsonBodyObject)
		{
			hp.DefaultRequestHeaders.Clear();
			hp.DefaultRequestHeaders.TryAddWithoutValidation(Constants.AUTHENTICATION_HEADER, authorization.UserEmail + ";" + authorization.UserToken);
			HttpContent hc = new StringContent(jsonBodyObject, Encoding.Unicode, "application/json");
			HttpResponseMessage task = await hp.PostAsync(endpointUrl + methodName, hc);
			return await task.Content.ReadAsStringAsync();
		}


		public async Task<string> SendRequestAsync(AuthorizationApiModel authorization, string methodName, byte[] body)
		{
			hp.DefaultRequestHeaders.Clear();
			hp.DefaultRequestHeaders.TryAddWithoutValidation(Constants.AUTHENTICATION_HEADER, authorization.UserEmail + ";" + authorization.UserToken);
			HttpContent hc = new ByteArrayContent(body);
			HttpResponseMessage task = await hp.PostAsync(endpointUrl + methodName, hc);
			return await task.Content.ReadAsStringAsync();
		}


		public string SendRequest(AuthorizationApiModel authorization, string methodName, string jsonBodyObject)
		{
			hp.DefaultRequestHeaders.Clear();
			hp.DefaultRequestHeaders.TryAddWithoutValidation(Constants.AUTHENTICATION_HEADER, authorization.UserEmail + ";" + authorization.UserToken);
			HttpContent hc = new StringContent(jsonBodyObject, Encoding.Unicode, "application/json");
			HttpResponseMessage httpResponseMessage = hp.PostAsync(endpointUrl + methodName, hc).Result;
			string response = httpResponseMessage.Content.ReadAsStringAsync().Result;
			return response;
		}

		public async Task<string> SendRequestWithNoBodyContentAsync(AuthorizationApiModel authorization, string methodNameAndParameters)
		{
			hp.DefaultRequestHeaders.Clear();
			hp.DefaultRequestHeaders.TryAddWithoutValidation(Constants.AUTHENTICATION_HEADER, authorization.UserEmail + ";" + authorization.UserToken);
			HttpContent hc = new StringContent(string.Empty, Encoding.Unicode, "application/json");
			HttpResponseMessage httpResponseMessage = await hp.PostAsync(endpointUrl + methodNameAndParameters, hc);
			return await httpResponseMessage.Content.ReadAsStringAsync();
		}

		public string SendRequestWithNoBodyContent(AuthorizationApiModel authorization, string methodNameAndParameters)
		{
			hp.DefaultRequestHeaders.Clear();
			hp.DefaultRequestHeaders.TryAddWithoutValidation(Constants.AUTHENTICATION_HEADER, authorization.UserEmail + ";" + authorization.UserToken);
			HttpContent hc = new StringContent(string.Empty, Encoding.Unicode, "application/json");
			HttpResponseMessage httpResponseMessage = hp.PostAsync(endpointUrl + methodNameAndParameters, hc).Result;
			string response = httpResponseMessage.Content.ReadAsStringAsync().Result;
			return response;
		}

		public string SendRequest(AuthorizationApiModel authorization, string methodName, byte[] content)
		{
			hp.DefaultRequestHeaders.Clear();
			hp.DefaultRequestHeaders.TryAddWithoutValidation(Constants.AUTHENTICATION_HEADER, authorization.UserEmail + ";" + authorization.UserToken);
			HttpContent hc = new ByteArrayContent(content);
			HttpResponseMessage httpResponseMessage = hp.PostAsync(endpointUrl + methodName, hc).Result;
			string response = httpResponseMessage.Content.ReadAsStringAsync().Result;
			return response;
		}

		public T Deserialize<T>(string input)
		{
			JsonSerializerSettings settings = new JsonSerializerSettings
			{
				TypeNameHandling = TypeNameHandling.All
			};

			return JsonConvert.DeserializeObject<T>(input, settings);
		}

		public string Serialize<T>(T t)
		{
			return JsonConvert.SerializeObject(t);
		}
	}
}