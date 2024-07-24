using FutureFlex.SQL;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Threading.Tasks;
namespace FutureFlex.API
{
    public class Authentication
    {
        public static string access_token { get; set; }
        public static string ERR { get; set; }
        public async static Task<bool> take_token_key()
        {

            try
            {
                var options = new RestClientOptions(tbOdoo.server)
                {
                    MaxTimeout = -1,
                };
                var client = new RestClient(options);
                var request = new RestRequest("/api/login/token_api_key", Method.Get);
                request.AddHeader("db", tbOdoo.db);
                request.AddHeader("key", tbOdoo.key);
                RestResponse response = await client.ExecuteAsync(request);
                Console.WriteLine(response.Content);

                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    return false;
                }

                JObject key = JObject.Parse(response.Content);
                access_token = key["access_token"].ToString();
                Console.WriteLine(access_token);
            }
            catch (Exception ex)
            {
                ERR = ex.Message;
                return false;
            }
            return true;
        }


        public static async Task<bool> CHECK_TOKEN()
        {
            try
            {
                if (access_token == null)
                {
                    if (!await take_token_key())
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
