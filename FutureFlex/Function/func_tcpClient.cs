using System;
using System.Configuration;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FutureFlex.Function
{
    internal class func_tcpClient
    {
        private static TcpClient client;
        private static NetworkStream stream;
        private static CancellationTokenSource cts;
        public static string ERR { get; set; }

        public static string ReceiveData { get; set; }

        public static bool ConnectState { get; set; } = false;
        public static bool ErrState { get; set; } = false;
        public static string IpServer { get; set; } = ConfigurationManager.AppSettings["IP_SERVER"];
        public static async Task<bool> Connect()
        {
            try
            {
                client = new TcpClient();
                await client.ConnectAsync(IpServer, 5000);
                Console.WriteLine("Connected to server.");
                stream = client.GetStream();
                ConnectState = true;
                ErrState = false;
                cts = new CancellationTokenSource();

                // Task สำหรับรับข้อมูล
                _ = Task.Run(async () =>
                {
                    byte[] buffer = new byte[1024];
                    while (!cts.Token.IsCancellationRequested)
                    {
                        try
                        {
                            int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length, cts.Token);
                            if (bytesRead == 0) break;
                            string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                            ReceiveData = message;
                            Console.WriteLine($"Received from server: {message}");
                        }
                        catch (OperationCanceledException)
                        {
                            break; // Task ถูกยกเลิก
                        }
                        catch (Exception ex)
                        {
                            if (ex.Message == "Unable to read data from the transport connection: An existing connection was forcibly closed by the remote host.")
                            {
                                Console.WriteLine("***** Server is offline");
                                ErrState = true;
                            }
                            break;
                        }
                    }
                }, cts.Token);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error connecting: {ex.Message}");
                return false;
            }
            return true;
        }

        private static async Task ReceiveDataAsync(CancellationToken token)
        {
            byte[] buffer = new byte[1024];
            try
            {
                while (!token.IsCancellationRequested)
                {
                    int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length, token);
                    if (bytesRead == 0) break;

                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    ReceiveData = message;
                    Console.WriteLine($"Received from server: {message}");
                }
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Receive task canceled.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error receiving data: {ex.Message}");
                ErrState = true;
                ERR = ex.Message;

            }
        }
        public static async Task<bool> SendDataAsync(string message)
        {
            try
            {
                Console.WriteLine("Sending data");
                byte[] data = Encoding.UTF8.GetBytes(message);
                stream.WriteTimeout = 2000;
                await stream.WriteAsync(data, 0, data.Length);
                Console.WriteLine("Message sent to server.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error sending data: {ex.Message}");
                ERR = ex.Message;
                return false;
            }
            return true;
        }

        public static bool SendDataAsyncTest(string message)
        {
            try
            {
                byte[] data = Encoding.UTF8.GetBytes(message);
                stream.WriteTimeout = 2000;
                stream.Write(data, 0, data.Length);
                Console.WriteLine("Message sent to server.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error sending data: {ex.Message}");
                ERR = ex.Message;
                return false;
            }
            return true;
        }

        public static async Task<bool> Disconnect()
        {
            try
            {
                // ยกเลิก Task ที่กำลังทำงาน
                if (cts != null)
                {
                    cts.Cancel(); // แจ้งยกเลิก Task
                    await Task.Delay(500); // รอให้ Task สิ้นสุด (กรณี Task ยังทำงานอยู่)
                    if (cts != null)
                    {
                        cts.Dispose();
                        cts = null;
                    }
                }

                // ปิด NetworkStream หากยังไม่ถูก Dispose
                if (stream != null)
                {
                    stream.Close();
                    stream.Dispose();
                    stream = null;
                }

                // ปิด TcpClient หากยังไม่ถูก Dispose
                if (client != null)
                {
                    client.Close();
                    client.Dispose();
                    client = null;
                }
                ConnectState = false;
                Console.WriteLine("Disconnected from server.");
            }
            catch (ObjectDisposedException ex)
            {
                Console.WriteLine($"Resource already disposed: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error disconnecting: {ex.Message}");
                return false;
            }
            finally
            {

            }

            return true;
        }

    }
}
