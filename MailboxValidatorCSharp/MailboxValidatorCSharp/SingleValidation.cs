using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MailboxValidator
{
	public class SingleValidation
	{
		private string api_key = "";
		static readonly HttpClient client = new HttpClient();

		public SingleValidation(string api_key)
		{
			this.api_key = api_key;
		}

		public string GetVersion()
		{
			Version ver = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
			return ver.Major + "." + ver.Minor + "." + ver.Build;
		}

		public async Task<JObject> ValidateEmailAsync(string email)
		{
			Dictionary<string, string> data = new Dictionary<string, string>()
	{
		{
			"format",
			"json"
		},
		{
			"email",
			email
		},
		{
			"key",
			api_key
		}
	};
			string datastr = string.Join("&", data.Select(x => x.Key + "=" + Uri.EscapeDataString(x.Value)).ToArray());
			string url = "http://api.mailboxvalidator.com/v2/validation/single?" + datastr.TrimStart('&');
			HttpResponseMessage response = await client.GetAsync(url);

			if (response.StatusCode == HttpStatusCode.OK)
			{
				string rawjson = await response.Content.ReadAsStringAsync();
				JObject results = JsonConvert.DeserializeObject<JObject>(rawjson);
				return results;
			}
			else if (response.StatusCode == HttpStatusCode.Unauthorized || response.StatusCode == HttpStatusCode.BadRequest)
			{
				string rawjson = await response.Content.ReadAsStringAsync();
				if (rawjson.Contains("error_message"))
				{
					JObject results = JsonConvert.DeserializeObject<JObject>(rawjson);
					throw new Exception(results["error"]["error_message"].ToString());
				}
			}
			throw new Exception("Error connecting to API.");
		}

		public async Task<JObject> DisposableEmailAsync(string email)
		{
			Dictionary<string, string> data = new Dictionary<string, string>()
	{
		{
			"format",
			"json"
		},
		{
			"email",
			email
		},
		{
			"key",
			api_key
		}
	};
			string datastr = string.Join("&", data.Select(x => x.Key + "=" + Uri.EscapeDataString(x.Value)).ToArray());

			string url = "http://api.mailboxvalidator.com/v2/email/disposable?" + datastr.TrimStart('&');
			HttpResponseMessage response = await client.GetAsync(url);

			if (response.StatusCode == HttpStatusCode.OK)
			{
				string rawjson = await response.Content.ReadAsStringAsync();
				JObject results = JsonConvert.DeserializeObject<JObject>(rawjson);
				return results;
			}
			else if (response.StatusCode == HttpStatusCode.Unauthorized || response.StatusCode == HttpStatusCode.BadRequest)
			{
				string rawjson = await response.Content.ReadAsStringAsync();
				if (rawjson.Contains("error_message"))
				{
					JObject results = JsonConvert.DeserializeObject<JObject>(rawjson);
					throw new Exception(results["error"]["error_message"].ToString());
				}
			}
			throw new Exception("Error connecting to API.");
		}

		public async Task<JObject> FreeEmailAsync(string email)
		{
			Dictionary<string, string> data = new Dictionary<string, string>()
	{
		{
			"format",
			"json"
		},
		{
			"email",
			email
		},
		{
			"key",
			api_key
		}
	};
			string datastr = string.Join("&", data.Select(x => x.Key + "=" + Uri.EscapeDataString(x.Value)).ToArray());

			string url = "http://api.mailboxvalidator.com/v2/email/free?" + datastr.TrimStart('&');
			HttpResponseMessage response = await client.GetAsync(url);

			if (response.StatusCode == HttpStatusCode.OK)
			{
				string rawjson = await response.Content.ReadAsStringAsync();
				JObject results = JsonConvert.DeserializeObject<JObject>(rawjson);
				return results;
			}
			else if (response.StatusCode == HttpStatusCode.Unauthorized || response.StatusCode == HttpStatusCode.BadRequest)
			{
				string rawjson = await response.Content.ReadAsStringAsync();
				if (rawjson.Contains("error_message"))
				{
					JObject results = JsonConvert.DeserializeObject<JObject>(rawjson);
					throw new Exception(results["error"]["error_message"].ToString());
				}
			}
			throw new Exception("Error connecting to API.");
		}

	}
}