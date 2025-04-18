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
                    }
                }
                catch (System.Exception ex)
                {
                    ERR = ex.Message;
                    return false;
                }
                return true;
            }


        }


        /// <summary>
        /// สำหรับดึงข้อมูลไปชั่งเพื่อเก็บ
        /// </summary>
        public static class JIT
        {

            public static string Mo_pono { get; set; }
            public static int Mo_so_id { get; set; }
            public static string Mo_so_no { get; set; }
            public static int Partner_id { get; set; }
            public static string Partner_name { get; set; }


            /// <summary>
            /// สำหรับแสดงรายละเอียด RTFG
            /// </summary>
            /// <param name="rtfg_num">เลขที่ RTFG</param>
            /// <returns></returns>
            public static async Task<bool> Return_num(string rtfg_num)
            {
                Log.Information($"=================================================================  ดึงข้อมูล RTFG จาก po {rtfg_num}");
                try
                {
                    CreateDataTable();
                    var options = new RestClientOptions(tbOdoo.server)
                    {
                        MaxTimeout = 3000,
                    };
                    var client = new RestClient(options);
                    var request = new RestRequest("/api/return_num", Method.Get);
                    request.AddHeader("key", tbOdoo.key);
                    request.AddHeader("return_num", rtfg_num);
                    RestResponse response = await client.ExecuteAsync(request);
                    Console.WriteLine(response.Content);

                    JObject keys = new JObject();
                    JArray jArray = new JArray();
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

                    jArray = JArray.Parse(response.Content);
                    foreach (JObject value in jArray.Children<JObject>())
                    {

                        Id = int.Parse(value["rtfg_id"].ToString());
                        Name = value["name"].ToString();
                        Return_qty_pch = double.Parse(value["return_qty_pch"].ToString());
                        Return_qty_weight = double.Parse(value["return_qty_weight"].ToString());
                        new_sale_name = value["new_sale_name"].ToString();
                        new_po_customer = value["new_po_customer"].ToString();

                        JArray jArray1 = JArray.Parse(value["mrp_list_return"].ToString());
                        foreach (JObject item in jArray1.Children<JObject>())
                        {
                            string id = item["id"].ToString();
                            string name = item["name"].ToString();
                            string parter = item["partner_name"].ToString();
                            string product = item["product_name"].ToString();
                            string uom = item["product_uom_name"].ToString();
                            Mrp_list_return.Rows.Add(id, name, parter, product, uom);
                        }
                        break;
                    }

                }
                catch (Exception ex)
                {
                    ERR = ex.Message;

                    return false;
                }
                return true;
            }



        }









        /// <summary>
        /// ส่งข้อมูลหา odoo
        /// </summary>
        /// <param name="rtfg_id">id ของ RTFG</param>
        /// <param name="wgh_id">weight id ของ ไทยเครื่องชั่งจะอยู่ใน database เป็น Auto incresment</param>
        /// <param name="machineOperator"></param>
        /// <param name="country"></param>
        /// <param name="type"></param>
        /// <param name="side"></param>
        /// <param name="po"></param>
        /// <param name="date"></param>
        /// <param name="net"></param>
        /// <param name="tare"></param>
        /// <param name="gross"></param>
        /// <param name="weightPaper"></param>
        /// <param name="weightCore"></param>
        /// <param name="joint"></param>
        /// <param name="qty_pch"></param>
        /// <param name="meterRoll"></param>
        /// <param name="lot"></param>
        /// <param name="seq"></param>
        /// <param name="count_total"></param>
        /// <param name="qty_roll">จำนวนม้วน/LOT</param>
        /// <returns></returns>
        public static async Task<bool> CREATE_RTFG(string rtfg_name, int rtfg_id, string wgh_id, string machineOperator, string country, string type, string side, string po, string date, string net, string tare, string gross, string weightPaper, string weightCore, string joint, string qty_pch, string meterRoll, string lot, string seq, string count_total, double qty_roll)
        {
            try
            {

                Log.Information("==================================================== SEND TO ODOO");
                Log.Information($"rtfg_name : {rtfg_name}");
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
                if (qty_roll == 0 && type == "roll")
                {
                    qty_roll = 1;
                }

                if (po == "")
                {
                    po = "JIT";
                }

                var options = new RestClientOptions(tbOdoo.server)
                {
                    MaxTimeout = -1,
                };
                var client = new RestClient(options);
                var request = new RestRequest("/api/return_num", Method.Post);
                request.AddHeader("key", tbOdoo.key);
                request.AddHeader("return_num", rtfg_id);
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

                if (response.StatusCode == System.Net.HttpStatusCode.Accepted)
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
