using FutureFlex.SQL;
using Newtonsoft.Json.Linq;
using RestSharp;
using Serilog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace FutureFlex.API
{
    internal class RTFG
    {

        public static int Rtfg_ID { get; set; }
        public static string Name { get; set; }
        public static string EffectiveDate { get; set; }
        public static string State { get; set; }
        public static int Do_id { get; set; }
        public static string Do_no { get; set; }
        public static int Product_id { get; set; }
        public static string Customer_product_code { get; set; }
        public static string Default_code { get; set; }
        public static string Product_Name { get; set; }
        /// <summary>
        /// ความกว้างม้วน 
        /// </summary>
        public static double product_roll_width { get; set; }
        /// <summary>
        /// ความยาวม้วนเต็ม (นำไปคำนวนกับจำนวนม้วนของ prodcut)
        /// </summary>
        public static double product_roll_length { get; set; }
        public static string Product_uom_name { get; set; }
        public static string Po_customer { get; set; }
        public static double Return_qty_pch { get; set; }
        public static double Return_qty_weight { get; set; }
        public static string Gv_return { get; set; }
        public static List<string> Gv_list_return { get; set; } = new List<string>();
        public static DataTable Mrp_list_return { get; set; } = new DataTable();

        public static string ERR { get; set; }

        /// <summary>
        /// สำหรับการสร้าง datatable ใหม่เพื่อเก็บข้อมูล
        /// </summary>
        static void CreateDataTable()
        {
            Mrp_list_return.Rows.Clear();
            Mrp_list_return.Columns.Clear();
            Mrp_list_return.Columns.Add("id");
            Mrp_list_return.Columns.Add("name");
            Mrp_list_return.Columns.Add("mo_date");
            Mrp_list_return.Columns.Add("mo_date_delivery");
            Mrp_list_return.Columns.Add("mo_film");
            Mrp_list_return.Columns.Add("mo_film_total");
            Mrp_list_return.Columns.Add("mo_work");
            Mrp_list_return.Columns.Add("partner_name");
            Mrp_list_return.Columns.Add("product_name");
            Mrp_list_return.Columns.Add("mo_type");
            Mrp_list_return.Columns.Add("uom");
        }

        /// <summary>
        /// สำหรับดึงข้อมูล RTFG
        /// </summary>
        /// <param name="rtfg_number">เลขที่ RTFG</param>
        /// <returns></returns>
        public static async Task<bool> Get_rtfg(string rtfg_number)
        {
            Log.Information($"=================================================================  ดึงข้อมูล RTFG จากเลข {rtfg_number}");

            // Clear dataTable and create
            CreateDataTable();
            try
            {
                if (!await Authentication.CHECK_TOKEN())
                {
                    ERR = Authentication.ERR;
                    return false;
                }

                var options = new RestClientOptions(tbOdoo.server)
                {
                    MaxTimeout = -1,
                };
                var client = new RestClient(options);
                var request = new RestRequest("/api/return", Method.Get);
                request.AddHeader("token", Authentication.access_token);
                request.AddHeader("rtfg_number", rtfg_number);
                RestResponse response = await client.ExecuteAsync(request);
                Console.WriteLine(response.Content);

                if (response.Content == "[]")
                {
                    ERR = "ไม่พบรายการที่เลือก";
                    Log.Information($"- ไม่พบรายการ");
                    return false;
                }

                if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    Log.Information($"- token หมดอายุ");
                    if (await Authentication.take_token_key())
                    {
                        request.AddHeader("token", Authentication.access_token);
                        request.AddHeader("mrnumber", rtfg_number);
                        response = await client.ExecuteAsync(request);
                        Console.WriteLine(response.Content);
                    }
                }
                else if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    ERR = "เกิดข้อผิดผลาด" + "Response  code : " + response.StatusCode;
                    return false;
                }

                JArray key = JArray.Parse(response.Content);

                foreach (JObject value in key.Children<JObject>())
                {
                    Rtfg_ID = int.Parse(value["rtfg_id"].ToString());
                    Name = value["name"].ToString();
                    EffectiveDate = value["effective_date"].ToString();
                    State = value["state"].ToString();
                    Do_id = int.Parse(value["do_id"].ToString());
                    Do_no = value["do_no"].ToString();
                    Product_id = int.Parse(value["product_id"].ToString());
                    Customer_product_code = value["customer_product_code"].ToString();
                    Default_code = value["default_code"].ToString();
                    Product_Name = value["product_name"].ToString();
                    product_roll_width = double.Parse(value["product_roll_width"].ToString());
                    product_roll_length = double.Parse(value["product_roll_length"].ToString());
                    Product_uom_name = value["product_uom_name"].ToString();
                    Po_customer = value["po_customer"].ToString();
                    Return_qty_pch = double.Parse(value["return_qty_pch"].ToString());
                    Return_qty_weight = double.Parse(value["return_qty_weight"].ToString());
                    Gv_return = value["gv_return"].ToString();

                    key = JArray.Parse(value["gv_list_return"].ToString());
                    for (int i = 0; i < key.Count; i++)
                    {
                        Gv_list_return.Add(key[i].ToString());
                        Console.WriteLine(key[i].ToString());
                    }

                    key = JArray.Parse(value["mrp_list_return"].ToString());
                    foreach (var item in key.Children<JObject>())
                    {
                        int id = int.Parse(item["id"].ToString());
                        string name = item["name"].ToString();
                        string mo_date = item["mo_date"].ToString();
                        string mo_date_delivery = item["mo_date_delivery"].ToString();
                        string mo_film = item["mo_film"].ToString();
                        string mo_film_total = item["mo_film_total"].ToString();
                        string mo_work = item["mo_work"].ToString();
                        string partner_name = item["partner_name"].ToString();
                        string product_name = item["product_name"].ToString();
                        string mo_type = item["mo_type"].ToString();
                        string uom_id = item["uom_id"].ToString();
                        Mrp_list_return.Rows.Add(id, name, mo_date, mo_date_delivery, mo_film, mo_film_total, mo_work, partner_name, product_name, mo_type, uom_id);
                    }
                }
            }
            catch (System.Exception ex)
            {
                ERR = ex.Message;
                return false;
            }
            return true;
        }

        public static async Task<bool> CREATE_RTFG(string rtfg_id, string wgh_id, string machineOperator, string country, string type, string side, string po, string date, string net, string tare, string gross, string weightPaper, string weightCore, string joint, string qty_pch, string meterRoll, string lot, string seq, string count_total, double qty_roll)
        {
            try
            {
                if (!await Authentication.CHECK_TOKEN())
                {
                    return false;
                }
                Log.Information("==================================================== SEND TO ODOO");
                Log.Information($"rtfg_id : {rtfg_id}");
                Log.Information($"weigh_in_line_id : {wgh_id}");
                Log.Information($"emp_name_weigh_in : {machineOperator}");
                Log.Information($"select_country : {country}");
                Log.Information($"select_type : {type}");
                Log.Information($"select_side : {side}");
                Log.Information($"for_po : {po}");
                Log.Information($"date : {date}");
                Log.Information($"net_weight : {net}");
                Log.Information($"tare_weight : {tare}");
                Log.Information($"gross_weight : {gross}");
                Log.Information($"weight_paper_plastic : {weightPaper}");
                Log.Information($"weight_core_total : {weightCore}");
                Log.Information($"joint : {joint}");
                Log.Information($"qty_pch : {qty_pch}");
                Log.Information($"qty_bag_in_box : 0");
                Log.Information($"qty_meter_kg_in_roll : {meterRoll}");
                Log.Information($"weight_lot : {lot}");
                Log.Information($"weight_seq : {seq}");
                Log.Information($"count_total : {count_total}");
                Log.Information($"qty_roll : {qty_roll}");


                var options = new RestClientOptions(tbOdoo.server)
                {
                    MaxTimeout = -1,
                };
                var client = new RestClient(options);
                var request = new RestRequest("/api/rtfg/create", Method.Post);
                request.AddHeader("token", Authentication.access_token);
                request.AddHeader("Content-Type", "text/plain");
                var body = "{\n" +
                 $"    |rtfg_id|:|{rtfg_id}|,\n" +
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
                 $"    |qty_bag_in_box|:0,\n" +
                 $"    |qty_meter_kg_in_roll|:{meterRoll},\n" +
                 $"    |weight_lot|:|{lot}|,\n" +
                 $"    |weight_seq|:|{seq}|,\n" +
                 $"    |count_total|: {count_total},\n" +
                 $"    |qty_roll|:{qty_roll}" +
                 "}";

                request.AddParameter("text/plain", body.Replace('|', '"'), ParameterType.RequestBody);
                RestResponse response = await client.ExecuteAsync(request);
                Console.WriteLine(response.Content);
                Log.Information($"Response : {response.Content}");

                if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    if (await Authentication.take_token_key())
                    {
                        request.AddHeader("token", Authentication.access_token);
                        request.AddHeader("Content-Type", "text/plain");
                        request.AddParameter("text/plain", body.Replace('|', '"'), ParameterType.RequestBody);
                        response = await client.ExecuteAsync(request);
                        Log.Information($"{response.Content}");
                        if (response.StatusCode != System.Net.HttpStatusCode.OK)
                        {
                            return false;
                        }
                    }
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.Accepted)
                {
                    JObject key1 = JObject.Parse(response.Content);
                    ERR = key1["message"].ToString();
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            Console.WriteLine($"SEND SUCCESS RTFG NAME : {rtfg_id}");
            Log.Information($"SEND SUCCESS RTFG NAME : {rtfg_id}");
            return true;
        }
    }
}
