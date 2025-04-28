using FutureFlex.SQL;
using Newtonsoft.Json.Linq;
using RestSharp;
using Serilog;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FutureFlex.API
{
    public class MRP
    {
        public static string id { get; set; }    // เลขที่ใบสั่งงานหรือเลขที่ GV (1938)
        public static string name { get; set; }  // ชื่อเลขที่ใบส่งงาน (GV-67-07-0135)
        public static string mo_date { get; set; }  // วันที่ออกใบสั่งงาน (2024-06-09)
        public static string mo_date_delivery { get; set; }  // วันที่กำหนดส่ง
        public static string mo_pono { get; set; } // เลขที่ PO
        public static string mo_po { get; set; } // จำนวนสั่งซื้อ
        public static int mo_so_id { get; set; }  // เลขที่ id so (1827)
        public static string mo_so_no { get; set; } // เลขที่ so (so19234)
        public static int mo_station_id { get; set; }
        public static string mo_station_name { get; set; }
        public static int partner_id { get; set; }
        public static string partner_name { get; set; }
        public static string customer_product_code { get; set; }
        public static int product_id { get; set; }  // รหัสสินค้า
        public static double product_qty { get; set; } // จำนวนสั่งผลิต
        public static string default_code { get; set; }
        public static string product_name { get; set; }
        /// <summary>
        /// ความกว้างม้วน 
        /// </summary>
        public static double product_roll_width { get; set; }
        /// <summary>
        /// ความยาวม้วนเต็ม (นำไปคำนวนกับจำนวนม้วนของ prodcut)
        /// </summary>
        public static double product_roll_length { get; set; }
        public static string mo_gusset { get; set; }
        public static string mo_film { get; set; }  // โครงสร้าง
        public static string mo_film_total { get; set; }
        public static string mo_type { get; set; }  // ลักษณะงาน

        /// <summary>
        /// ขนาดสำเร็จ
        /// </summary>
        public static string mo_work { get; set; } // ขนาดสำเร็จ

        /// <summary>
        /// ขนาดเพื่อหด
        /// </summary>
        public static string mo_block { get; set; }
        public static double done_qty { get; set; }
        public static double manufactured_qty { get; set; }
        public static double pending_qty { get; set; }
        public static int product_uom_id { get; set; }
        public static string product_uom_name { get; set; }  // หน่วยงาน

        /// <summary>
        /// ขนาดงานใบ กว้าง
        /// </summary>
        public static double pch_width { get; set; }

        /// <summary>
        /// ขนาดงานใบ ยาว
        /// </summary>
        public static double pch_length { get; set; }


        /// <summary>
        /// ขนาดเพื่อหด
        /// </summary>
        public static double shrink_mm { get; set; }
        public static double mo_po_qty { get; set; } // จำนวนสั้งซื้อ
        public static string uom_id { get; set; } // หน่วย FG(สั่งซื้อ)
        public static double mo_po_new { get; set; } // จำนวนสั่งซื้อ (ใบ)
        public static double mo_order_qty { get; set; } // จำนวนสั่งซื้อ (ใบ) +%
        public static string err { get; set; }

        public static List<string> gvAndPo = new List<string>();

        public static void ClearProp()
        {
            Log.Information("== เครีย์ property MRP");
            id = "";
            name = "";
            mo_date = "";
            mo_date_delivery = "";
            mo_pono = "";
            mo_po = "";
            mo_so_id = 0;
            mo_so_no = "";
            mo_station_id = 0;
            mo_station_name = "";
            partner_id = 0;
            partner_name = "";
            product_id = 0;
            default_code = "";
            product_name = "";
            mo_gusset = "";
            mo_film = "";
            mo_film_total = "";
            mo_type = "";
            mo_work = "";
            product_qty = 0;
            done_qty = 0;
            manufactured_qty = 0;
            pending_qty = 0;
            product_uom_id = 0;
            product_uom_name = "";
            Log.Information("== เครีย์ property MRP สำเร็จ");
        }


        public async static Task<bool> GET_PO(string po)
        {
            Log.Information($"======================================================  GET PO {po}");

            try
            {
                var options = new RestClientOptions(tbOdoo.server)
                {
                    MaxTimeout = -1,
                };
                var client = new RestClient(options);
                var request = new RestRequest("/api/gv_list", Method.Get);
                request.AddHeader("key", tbOdoo.key);
                request.AddHeader("po_num", po);
                RestResponse response = await client.ExecuteAsync(request);
                Log.Information($"response \n {response.Content}");
                if (response.Content == "[]")
                {
                    err = "ไม่พบรายการที่เลือก";
                    Log.Information($"- ไม่พบรายการ");
                    return false;
                }

                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    err = "เกิดข้อผิดผลาด";
                    return false;
                }


                JObject key = JObject.Parse(response.Content);

                JArray jArray = JArray.Parse(key["GV"].ToString());
                gvAndPo.Clear();
                foreach (var item in jArray)
                {
                    foreach (JProperty property in item.Children<JProperty>())
                    {
                        string propertyName = property.Name;
                        JToken propertyValue = property.Value;

                        Log.Information($"{propertyName} : {propertyValue}");
                    }

                    string gv = item["name"].ToString();
                    string so = item["mo_so_no"].ToString();
                    gvAndPo.Add($"{gv}|{so}");
                }
            }
            catch (System.Exception ex)
            {
                err = $"เกิดข้อผิดผลาด {ex.Message}";
                Log.Error($"GET_MRP | MRP : {err}");
                return false;
            }
            Log.Information($"- ดึงข้อมูลจาก odoo สำเร็จ");
            return true;
        }

        public async static Task<bool> GET_MRP(string gv, string po_num)
        {
            Log.Information($"== ดึงข้อมูลจาก odoo ค้นหาจาก {gv}");

            try
            {
                var options = new RestClientOptions(tbOdoo.server)
                {
                    MaxTimeout = -1,
                };
                var client = new RestClient(options);
                var request = new RestRequest("/api/gv_num", Method.Get);
                request.AddHeader("key", tbOdoo.key);
                request.AddHeader("gv_num", gv);
                request.AddHeader("po_num", po_num);
                RestResponse response = await client.ExecuteAsync(request);
                Log.Information($"- response \n {response.Content}");


                if (response.StatusCode == System.Net.HttpStatusCode.Accepted)
                {
                    err = "Not found";
                    return false;
                }


                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    err = $"Incorrent \nStatus Code : {response.StatusCode}";
                    return false;
                }


                JArray key = JArray.Parse(response.Content);
                // Loop อ่านค่าจาก็ key


                foreach (JObject value in key.Children<JObject>())
                {
                    Log.Information("==================================================== GET  ODOO");
                    foreach (JProperty property in value.Children<JProperty>())
                    {
                        string propertyName = property.Name;
                        JToken propertyValue = property.Value;

                        Log.Information($"{propertyName} : {propertyValue}");
                    }


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
                    customer_product_code = value["customer_product_code"].ToString();
                    product_id = (int)value["product_id"];
                    default_code = value["default_code"].ToString();
                    product_name = value["product_name"].ToString();
                    product_roll_width = double.Parse(value["product_roll_width"].ToString());
                    product_roll_length = double.Parse(value["product_roll_length"].ToString());
                    mo_gusset = value["mo_gusset"].ToString();
                    mo_film = value["mo_film"].ToString();
                    mo_film_total = value["mo_film_total"].ToString();
                    mo_type = value["mo_type"].ToString();
                    mo_work = value["mo_work"].ToString();
                    mo_block = value["mo_block"].ToString();
                    product_qty = (double)value["product_qty"];
                    done_qty = (double)value["done_qty"];
                    manufactured_qty = (double)value["manufactured_qty"];
                    pending_qty = (double)value["pending_qty"];
                    product_uom_id = (int)value["product_uom_id"];
                    product_uom_name = value["product_uom_name"].ToString();
                    mo_po_qty = (double)value["mo_po_qty"];
                    uom_id = value["uom_id"].ToString();
                    mo_po_new = (double)value["mo_po_new"];
                    mo_order_qty = (double)value["mo_order_qty"];
                    pch_width = double.Parse(value["pch_width"].ToString());
                    pch_length = double.Parse(value["pch_length"].ToString());
                    shrink_mm = double.Parse(value["shrink_mm"].ToString());
                    break;
                }
            }
            catch (System.Exception ex)
            {
                err = $"เกิดข้อผิดผลาด {ex.Message}";
                Log.Error($"GET_MRP | MRP : {err}");
                Console.WriteLine(ex.Message);
                return false;
            }
            Log.Information($"- ดึงข้อมูลจาก odoo สำเร็จ");
            return true;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="gv_id">เลขที่ GV ไม่ใช่ชื่อ GV</param>
        /// <param name="wgh_id">เลขที่การชั่ง id auto increaement</param>
        /// <param name="machineOperator">ชื่อผู้ชั่ง</param>
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
        /// <param name="qty_pch">จำนวนใบ ไม่ว่าจะเลือกกล่องหรือม้วนให้คีย์ตัวนี้</param>
        /// <param name="meterRoll">ใส่เฉพาะกรณีเลือกงานม้วน ให้ใส่จำนวนเมตร</param>
        /// <param name="lot">เลขที่</param>
        /// <param name="seq">ลำดับกล่องลำดับม้วน</param>
        /// <param name="count_total">จำนวนทั้งหมด ทั้งงานกล่องและงานมัวน</param>
        /// <param name="qty_roll">จำนวนม้วน/LOT</param>
        /// <returns></returns>
        public async static Task<bool> CREATE_MRP(string gv_id, string wgh_id, string machineOperator, string country, string type, string side, string po, string date, string net, string tare, string gross, string weightPaper, string weightCore, string joint, string qty_pch, string meterRoll, string lot, string seq, string count_total, double qty_roll)
        {
            try
            {
                Log.Information("==================================================== SEND TO ODOO");
                Log.Information($"mrp_request_id : {gv_id}");
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
                var request = new RestRequest("/api/gv_num", Method.Post);
                request.AddHeader("key", tbOdoo.key);
                request.AddHeader("Content-Type", "text/plain");

                if (qty_roll == 0 && type == "roll")
                {
                    qty_roll = 1;
                }
                #region Body
                var body = "{\n" +
                  $"    |mrp_request_id|:|{gv_id}|,\n" +
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
                #endregion

                request.AddParameter("text/plain", body.Replace('|', '"'), ParameterType.RequestBody);
                RestResponse response = await client.ExecuteAsync(request);
                Log.Information($"{response.Content}");

                JObject key1 = new JObject();
                JArray jArray = new JArray();
                if (response.StatusCode != System.Net.HttpStatusCode.Created)
                {
                    key1 = JObject.Parse(response.Content);
                    jArray = JArray.Parse(key1["data"].ToString());
                    err = jArray["message"].ToString();
                    return false;
                }
            }
            catch (Exception ex)
            {
                err = $"เกิดข้อผิดผลาด {ex.Message}";

                Console.Write(ex.Message);
                return false;
            }
            Log.Information($"SEND SUCCESS RTFG NAME : {id}");
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
