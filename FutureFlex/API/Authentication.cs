using FutureFlex.Models;
using Newtonsoft.Json.Linq;
using RestSharp;
using Serilog;
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
                Log.Information($"=================================================================  เช็ค token");
                var options = new RestClientOptions(OdooModel.Server)
                {
                    MaxTimeout = -1,
                };
                var client = new RestClient(options);
                var request = new RestRequest("/api/login/token_api_key", Method.Get);
                request.AddHeader("db", OdooModel.Database);
                request.AddHeader("key", OdooModel.Key);
                RestResponse response = await client.ExecuteAsync(request);
                Console.WriteLine(response.Content);
                Log.Information($"- response \n {response.Content}");
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
                Log.Error($"take_token_key | Authenticaion : {ERR}");
                return false;
            }
            Log.Information($"- เช็ค Token สำเร็จ");
            return true;
        }

    }
}
