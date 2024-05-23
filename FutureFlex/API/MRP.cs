using FutureFlex.SQL;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Threading.Tasks;

namespace FutureFlex.API
{
    public class MRP
    {
        public static string id { get; set; }
        public static string name { get; set; }
        public static string mo_date { get; set; }
        public static string mo_date_delivery { get; set; }
        public static string mo_pono { get; set; }
        public static string mo_po { get; set; }
        public static int mo_so_id { get; set; }
        public static string mo_so_no { get; set; }
        public static int mo_station_id { get; set; }
        public static string mo_station_name { get; set; }
        public static int partner_id { get; set; }
        public static string partner_name { get; set; }
        public static int product_id { get; set; }
        public static string default_code { get; set; }
        public static string product_name { get; set; }
        public static string mo_gusset { get; set; }
        public static string mo_film { get; set; }
        public static string mo_film_total { get; set; }
        public static string mo_type { get; set; }
        public static string mo_work { get; set; }
        public static double product_qty { get; set; }
        public static double done_qty { get; set; }
        public static double manufactured_qty { get; set; }
        public static double pending_qty { get; set; }
        public static int product_uom_id { get; set; }
        public static string product_uom_name { get; set; }

        public static string err { get; set; }



        public async static Task<bool> GET_MRP(string gv)
        {
            if (!await Authentication.CHECK_TOKEN())
            {
                return false;
            }

            try
            {


                var options = new RestClientOptions(tbOdoo.server)
                {
                    MaxTimeout = -1,
                };
                var client = new RestClient(options);
                var request = new RestRequest("/api/mrp", Method.Get);
                request.AddHeader("token", Authentication.access_token);
                request.AddHeader("mrnumber", gv);
                RestResponse response = await client.ExecuteAsync(request);
                Console.WriteLine(response.Content);

                if (response.Content == "[]")
                {
                    err = "ไม่พบรายการที่เลือก";
                    return false;
                }

                if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    if (await Authentication.take_token_key())
                    {
                        request.AddHeader("token", Authentication.access_token);
                        request.AddHeader("mrnumber", gv);
                        response = await client.ExecuteAsync(request);
                        Console.WriteLine(response.Content);
                    }
                }
                else if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    err = "เกิดข้อผิดผลาด";
                    return false;
                }


                JArray key = JArray.Parse(response.Content);
                foreach (JObject value in key.Children<JObject>())
                {
                    id = value["id"].ToString();
                    name = value["name"].ToString();
                    mo_date = value["mo_date"].ToString();
                    mo_date_delivery = value["mo_date_delivery"].ToString();
                    mo_pono = value["mo_pono"].ToString();
                    mo_po = value["mo_po"].ToString();
                    mo_so_id = (int)value["mo_so_id"];
                    mo_so_no = value["mo_so_no"].ToString();
                    mo_station_id = (int)value["mo_station_id"];
                    mo_station_name = value["mo_station_name"].ToString();
                    partner_id = (int)value["partner_id"];
                    partner_name = value["partner_name"].ToString();
                    product_id = (int)value["product_id"];
                    default_code = value["default_code"].ToString();
                    product_name = value["product_name"].ToString();
                    mo_gusset = value["mo_gusset"].ToString();
                    mo_film = value["mo_film"].ToString();
                    mo_film_total = value["mo_film_total"].ToString();
                    mo_type = value["mo_type"].ToString();
                    mo_work = value["mo_work"].ToString();
                    product_qty = (double)value["product_qty"];
                    done_qty = (double)value["done_qty"];
                    manufactured_qty = (double)value["manufactured_qty"];
                    pending_qty = (double)value["pending_qty"];
                    product_uom_id = (int)value["product_uom_id"];
                    product_uom_name = value["product_uom_name"].ToString();
                }

            }
            catch (System.Exception ex)
            {
                err = $"เกิดข้อผิดผลาด {ex.Message}";

                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }

        public async static Task<JArray> GET_PO(string gv)
        {
            JArray value = new JArray();
            try
            {
                if (!await Authentication.CHECK_TOKEN())
                {
                    return value;
                }

                var options = new RestClientOptions(tbOdoo.server)
                {
                    MaxTimeout = -1,
                };
                var client = new RestClient(options);
                var request = new RestRequest("/api/mrp/po", Method.Get);
                request.AddHeader("token", Authentication.access_token);
                request.AddHeader("mrnumber", gv);
                RestResponse response = await client.ExecuteAsync(request);
                Console.WriteLine(response.Content);

                if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    if (await Authentication.take_token_key())
                    {
                        request.AddHeader("token", Authentication.access_token);
                        request.AddHeader("mrnumber", gv);
                        response = await client.ExecuteAsync(request);
                        Console.WriteLine(response.Content);

                        JObject key = JObject.Parse(response.Content);
                        value = JArray.Parse(key["mo_po_list"].ToString());
                        return value;
                    }
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    if (response.Content == "{}")
                    {
                        return value;
                    }
                    else
                    {
                        JObject key = JObject.Parse(response.Content);
                        value = JArray.Parse(key["mo_po_list"].ToString());
                        return value;
                    }
                }


            }
            catch (Exception ex)
            {
                err = $"เกิดข้อผิดผลาด {ex.Message}";
                System.Windows.MessageBox.Show(ex.Message);
                return value;

            }
            return value;
        }


        public async static Task<bool> CREATE_MRP(string GV_id, string wgh_id, string machineOperator, string country, string type, string side, string po, string date, string net, string tare, string gross, string weightPaper, string weightCore, string joint, string qty_pch, string qty_box, string meterRoll)
        {
            try
            {
                if (!await Authentication.CHECK_TOKEN())
                {
                    return false;
                }


                var options = new RestClientOptions(tbOdoo.server)
                {
                    MaxTimeout = -1,
                };
                var client = new RestClient(options);
                var request = new RestRequest("/api/mrp/create", Method.Post);
                request.AddHeader("token", Authentication.access_token);
                request.AddHeader("Content-Type", "text/plain");
                #region Body
                var body = "{\n" +
                  $"    |mrp_request_id|:|{GV_id}|,\n" +
                  $"    |weigh_in_line_id|:|{wgh_id}|,\n" +
                  $"    |emp_name_weigh_in|:|{machineOperator}|,\n" +
                  $"    |select_country|:|{country}|,\n" +
                  $"    |select_type|:|{type}|,\n" +
                  $"    |select_side|:|{side}|,\n" +
                  $"    |for_po|:|{po}|,\n" +
                  $"    |date|:|{date}|,\n" +
                  $"    |net_weight|:{net},\n" +
                  $"    |tare_weight|:{tare},\n" +
                  $"    |gross_weight|:{gross},\n" +
                  $"    |weight_paper_plastic|:{weightPaper},\n" +
                  $"    |weight_core_total|:{weightCore},\n" +
                  $"    |joint|:{joint},\n" +
                  $"    |qty_pch|:{qty_pch},\n" +
                  $"    |qty_bag_in_box|:{qty_box},\n" +
                  $"    |qty_meter_kg_in_roll|:{meterRoll}\n" +
                  "}";
                #endregion

                request.AddParameter("text/plain", body.Replace('|', '"'), ParameterType.RequestBody);
                RestResponse response = await client.ExecuteAsync(request);
                Console.WriteLine(response.Content);

                if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {

                    if (await Authentication.take_token_key())
                    {
                        request.AddHeader("token", Authentication.access_token);
                        request.AddHeader("Content-Type", "text/plain");
                        request.AddParameter("text/plain", body.Replace('|', '"'), ParameterType.RequestBody);
                        response = await client.ExecuteAsync(request);
                        Console.WriteLine(response.Content);

                        if (response.StatusCode != System.Net.HttpStatusCode.OK)
                        {
                            return false;
                        }
                    }
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.Accepted)
                {
                    JObject key1 = JObject.Parse(response.Content);
                    err = key1["message"].ToString();
                    return false;
                }
            }
            catch (Exception ex)
            {
                err = $"เกิดข้อผิดผลาด {ex.Message}";

                Console.Write(ex.Message);
                return false;
            }
            return true;
        }

        public async static Task<bool> DELETE(int weigh_in_line_id)
        {
            try
            {
                var options = new RestClientOptions(tbOdoo.server)
                {
                    MaxTimeout = -1,
                };
                var client = new RestClient(options);
                var request = new RestRequest("/api/unlinke/weighin", Method.Delete);
                request.AddHeader("token", Authentication.access_token);
                request.AddHeader("Content-Type", "text/plain");
                var body = "{\n" +
                    "     |weigh_in_line_id|:|" + weigh_in_line_id + "|\n" +
                    "}";
                request.AddParameter("text/plain", body.Replace('|', '"'), ParameterType.RequestBody);
                RestResponse response = await client.ExecuteAsync(request);
                Console.WriteLine(response.Content);


                if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    await Authentication.take_token_key();
                    request.AddHeader("token", Authentication.access_token);
                    request.AddHeader("Content-Type", "text/plain");
                    request.AddParameter("text/plain", body.Replace('|', '"'), ParameterType.RequestBody);
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.Accepted)
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                err = $"เกิดข้อผิดผลาด {ex.Message}";
                return false;
            }
            return true;
        }
    }
}
