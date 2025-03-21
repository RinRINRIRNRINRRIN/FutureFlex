using FutureFlex.SQL;
using Newtonsoft.Json.Linq;
using RestSharp;
using Serilog;
using System;
using System.Data;
using System.Threading.Tasks;

namespace FutureFlex.API
{
    internal class RTFG
    {
        public static int Id { get; set; }
        public static string Name { get; set; }

        public static string ERR { get; set; }

        /// <summary>
        /// กรณีคืนสินค้าในรูปแบบ PO จะต้องใช้ new po มาแสดงที่ sticket
        /// </summary>
        public static string new_sale_name { get; set; }

        /// <summary>
        /// เลขที่ PO ใหม่
        /// </summary>
        public static string new_po_customer { get; set; }

        /// <summary>
        /// เก็บค่านำจวนใบที่ต้องคืน
        /// </summary>
        public static double Return_qty_pch { get; set; }
        public static double Return_qty_weight { get; set; }
        public static double product_roll_length { get; set; }


        public static DataTable Mrp_list_return { get; set; } = new DataTable();



        /// <summary>
        /// สำหรับการสร้าง datatable ใหม่เพื่อเก็บข้อมูล
        /// </summary>
        static void CreateDataTable()
        {
            try
            {
                if (Mrp_list_return.Columns.Count > 1)
                {
                    if (Mrp_list_return.Rows.Count != 0)
                    {
            Mrp_list_return.Rows.Clear();
                    }
                }
                else if (Mrp_list_return.Columns.Count == 0)
                {
            Mrp_list_return.Columns.Add("id");
            Mrp_list_return.Columns.Add("name");
            Mrp_list_return.Columns.Add("partner_name");
            Mrp_list_return.Columns.Add("product_name");
            Mrp_list_return.Columns.Add("uom");
        }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message + " | " + "RTFG CreateDataTable");
                throw;
            }
        }
        public static string Mo_pono { get; set; }
        public static int Mo_so_id { get; set; }
        public static string Mo_so_no { get; set; }
        public static int Partner_id { get; set; }
        public static string Partner_name { get; set; }


        /// <summary>
        /// สำหรับดึงข้อมูลไปชั่งเพื่อขาย
            /// </summary>
        public static class PO
        {
            /// <summary>
            /// สำหรับแสดงรายการ rtfg ที่ผูกกับ po
            /// </summary>
            /// <param name="po_num">เลขที่ PO</param>
        /// <returns></returns>
            public static async Task<bool> Return_list(string po_num)
        {
            try
            {
                    CreateDataTable();
                    JObject keys = new JObject();
                    JArray jArray = new JArray();

                var options = new RestClientOptions(tbOdoo.server)
                {
                        MaxTimeout = 3000,
                };
                var client = new RestClient(options);
                    var request = new RestRequest("/api/return_list", Method.Get);
                    request.AddHeader("key", tbOdoo.key);
                    request.AddHeader("po_num", po_num);
                RestResponse response = await client.ExecuteAsync(request);
                Console.WriteLine(response.Content);

                    if (response.StatusCode == System.Net.HttpStatusCode.Accepted)
                {
                        keys = JObject.Parse(response.Content);
                        ERR = $"เกิดข้อผิดผลาด Response code : {response.StatusCode}\nMessage : {keys["message"]}";
                    return false;
                }

                    if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                        ERR = "เกิดข้อผิดผลาด" + "Response  code : " + response.StatusCode;
                        return false;
                    }

                    keys = JObject.Parse(response.Content);
                    jArray = JArray.Parse(keys["RTFG"].ToString());

                    foreach (JObject value in jArray.Children<JObject>())
                    {
                        Id = int.Parse(value["id"].ToString());
                        Name = value["name"].ToString();
                        Mo_pono = value["mo_pono"].ToString();
                        Mo_so_id = int.Parse(value["mo_so_id"].ToString());
                        Mo_so_no = value["mo_so_no"].ToString();
                        Partner_id = int.Parse(value["partner_id"].ToString());
                        Partner_name = value["partner_name"].ToString();
                        Mrp_list_return.Rows.Add(Id, Name, Partner_name, "");
                        break;
                    }
                }
                catch (System.Exception ex)
                {
                    ERR = ex.Message;
                    return false;
                }
                return true;
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
