
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Windows.Data.Json;
using Xamarin.Forms;

using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace Xamarin_Learning.ViewModels
{
  public  class APICall:ContentPage
    {
        HttpClient client;
        public  APICall()
        {
            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;
            // parse the results, then update the screen:
             var a = test();

        }

        public async Task<object> test()
        {
            return await RefreshDataAsync();
        }

        // Gets API Call.
        public async Task<string> RefreshDataAsync()
        {
            try
            {
                var uri = new Uri("http://169.254.80.80:63439/api/values/5");
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var Items = JsonConvert.DeserializeObject<string>(content);
                    return Items;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return null;
        
        }
    }
}
