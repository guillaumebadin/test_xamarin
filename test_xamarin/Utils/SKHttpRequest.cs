using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ubilab_mobile
{
	public class SKHttpRequest
	{
        static readonly int TIMEOUT_SECONDS = 120;
		public async Task<HttpResponseMessage> HttpGetAsync(string _url, Dictionary<string, string> headers = null)
		{
			HttpResponseMessage message = null;
			try
			{
                using (var client = GetHttpClient(_url, headers))
				{
					message = await client.GetAsync(_url);
				}
			}
			catch (Exception ex)
			{
                throw ex;
			}
			return message;
		}

		static HttpClient GetHttpClient(string _url, Dictionary<string, string> headers = null)
		{
			var uri = new Uri(_url);
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Host = uri.Host;
            client.BaseAddress = uri;
            client.Timeout = TimeSpan.FromSeconds(TIMEOUT_SECONDS);
			client.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "*/*");
			if (headers != null)
			{
				foreach (var item in headers)
				{
					client.DefaultRequestHeaders.TryAddWithoutValidation(item.Key, item.Value);
				}
			}
            return client;
        }
	}
}

