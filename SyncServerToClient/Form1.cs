using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SyncServerToClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static List<TcpClient> clients = new List<TcpClient>();
        private async void Form1_Load(object sender, EventArgs e)
        {
            TcpListener server = new TcpListener(IPAddress.Any, 5000);
            server.Start();
            Console.WriteLine("Server started...");

            while (true)
            {
                TcpClient client = await server.AcceptTcpClientAsync();
                clients.Add(client);
                Console.WriteLine($"Client connected. IP : {client.Client.RemoteEndPoint}");
                _ = HandleClient(client);
            }
        }
        static async Task HandleClient(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];

            while (true)
            {
                try
                {
                    int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                    if (bytesRead == 0) break;

                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    Console.WriteLine($"{client.Client.RemoteEndPoint} Received: {message}");

                    // ส่งข้อมูลไปยัง Clients อื่น ๆ
                    Broadcast($"{message}\n", client);
                }
                catch
                {
                    break;
                }
            }

            Console.WriteLine($"Client {client.Client.RemoteEndPoint} disconnected.");
            clients.Remove(client);
            client.Close();
        }

        static void Broadcast(string message, TcpClient excludeClient)
        {
            byte[] data = Encoding.UTF8.GetBytes(message);

            foreach (var client in clients)
            {
                if (client != excludeClient)
                {
                    NetworkStream stream = client.GetStream();
                    stream.WriteAsync(data, 0, data.Length);
                }
            }
        }
    }
}
