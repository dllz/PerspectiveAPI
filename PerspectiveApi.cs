using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Enforcer5.Models.Perspective;
using Newtonsoft.Json;

namespace PerspectiveAPI
{
    public class PerspectiveApi
    {
        private string apiKey { get; set; }
        private string URL;

        public PerspectiveApi(string apikey)
        {
            apiKey = apikey;
            URL = $"https://commentanalyzer.googleapis.com/v1alpha1/comments:analyze?key={apiKey}";
        }

        public AnalyzeCommentResponse sendRequest(AnalyzeCommentRequest request)
        {
            using (var client = new HttpClient())
            {
               
                var content = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");
                var response = client.PostAsync(URL, content).Result;
                response.EnsureSuccessStatusCode();
                var data = response.Content.ReadAsStringAsync().Result;
                var result = JsonConvert.DeserializeObject<AnalyzeCommentResponse>(data);
                return result;
            }
        }
            
    }
}
