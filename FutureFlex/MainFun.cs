using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Net;
    

namespace FutureFlex
{
    class MainFun
    {
        public static bool internetCheck() //////////////// เช็คการเชื่อมต่ออินเตอร์เน็ต
        {
            try
            {
                if (NetworkInterface.GetIsNetworkAvailable())
                {                  
                    return true;
                }
                else
                {                  
                    return false;
                }
            }
            catch (Exception ex)
            {
                LogsSend(2, ex.Message.ToString());
                LogsSend(2, "Can't Connect network");
                return false;
            }
        }
        // public static bool serverCheck() //////////////// เช็คการเชื่อมต่อ server
        public static bool ServerCheck()
        {
            try
            {
                Ping ping = new Ping();
                PingReply reply = ping.Send("198.168.1.91",5000);
                if (reply.Status != IPStatus.Success)
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }


        public static void OpenFormCenterScreen(Form frm,Panel pn) //////////////////////////  เปิด form ซ้อนกัน ตรงกลาง FrmMain
        {
            try
            {
                frm.TopLevel = false;
                pn.Controls.Clear();

                int x = (pn.Width - frm.Width) / 2;
                int y = (pn.Height - frm.Height) / 2;

                frm.Location = new Point(x, y);
                pn.Controls.Add(frm);
                frm.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                LogsSend(2, ex.ToString());
                return;
            }
        }

        public static void OpenGroupboxCenterScreen(Form frm, Panel pn) ////////////////////  เปิด groupbox ในฟอร์ม
        {
            try
            {

                frm.TopLevel = false;
                pn.Controls.Clear();

                int x = (pn.Width - frm.Width) / 2;
                int y = (pn.Height - frm.Height) / 2;

                frm.Location = new Point(x, y);
                pn.Controls.Add(frm);
                frm.Show();

            }
            catch (Exception ex)
            {
                LogsSend(2, ex.ToString());
                return;
            }
        }

        public static void LogsSend(int LogType,string eventlog)  ////////////////////  เก็บLog
        {
            /*
             *  LogType 
             *  1 = INFORMATION[i]     Ex. เปิดฟอร์ม,เลือกเมนู
             *  2 = ERROR      [E]     Ex. Excaption ของแต่ละ Event 
             *  3 = WARNNING   [W]     Ex. Return False ของแต่ละ Event
             *  4 = SUCCESS    [S]     Ex. Return True ของแต่ละ Event
             */

            try
            {                         
                string logFileName = "logs";
                long maxLogFileSize = 30000000; // 30MB in bytes

                FileInfo logFile = new FileInfo(logFileName);
                if (logFile.Length >= maxLogFileSize) ///// เช็คว่าไฟล์Log เกิน 30 MB ไหม
                {
                    string newLogFileName = "log_" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".txt";
                    File.Move(logFileName, newLogFileName);
                }
                else
                {  
                    string ti = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                    if (LogType == 1) ///// เช็คว่าเป็น Log ประเภทไหนเพื่อง่ายต่อการวิเคราะห์
                    {
                        File.AppendAllText(logFileName, ti + "  :  " + "INFO     |"+ eventlog + Environment.NewLine, System.Text.Encoding.UTF8);
                    }
                    else if (LogType == 2)
                    { 
                        File.AppendAllText(logFileName, ti + "  :  " + "ERROR    |" + eventlog + Environment.NewLine, System.Text.Encoding.UTF8);
                    }
                    else if (LogType == 3)
                    {
                        File.AppendAllText(logFileName, ti + "  :  " + "WARNNING |" + eventlog + Environment.NewLine, System.Text.Encoding.UTF8);
                    }
                    else if (LogType == 4)
                    {
                        File.AppendAllText(logFileName, ti + "  :  " + "SUCCESS  |"+  eventlog + Environment.NewLine, System.Text.Encoding.UTF8);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);              
                return;
            }
        }

        public static bool CHECK_OPEN_PGM()
        {
            Process[] chkPGM = Process.GetProcessesByName("FutureFlex");
            if (chkPGM.Length > 1)
            {
                MessageBox.Show("มีโปรแกรมเปิดอยู่แล้ว", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }        
         return true;
        }

    }
}
