using NATS.Client;
using System.Runtime.InteropServices;
using System;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace AvG
{
    public partial class Form1 : Form
    {
        private static bool _exit = false;
        private static IConnection _connection;
        [DllImport("kernel32.dll", EntryPoint = "AllocConsole", SetLastError = true)]
        private static extern bool AllocConsole();
        private static int _messagecount = 25;

        public Form1()
        {
            InitializeComponent();
        }

        private IConnection ConnectToNats()
        {
            ConnectionFactory factory = new ConnectionFactory();

            var options = ConnectionFactory.GetDefaultOptions();
            options.Url = "nats://localhost:4222";

            return factory.CreateConnection(options);
        }

        private void producer_erstellen_button_Click(object sender, EventArgs e)
        {

            using (_connection = ConnectToNats())
            {
                this.Close();
                Process.Start("AvG.exe");
                AllocConsole();

                Console.WriteLine("Raumname:");
                string raumname = Console.ReadLine();

                Console.Clear();
                Console.WriteLine("Connected");
                Console.WriteLine($"Raumname: {raumname}");

                for (int i = 1; i < _messagecount; i++)
                {
                    Random rnd = new Random();
                    string message =rnd.Next(1, 99).ToString();
                    Console.WriteLine($"CO2-Wert: {message}");

                    if (Int16.Parse(message) < 20)
                    {
                        byte[] data1 = Encoding.UTF8.GetBytes($"{message} niedrig: Fenster schließen");
                        _connection.Publish(raumname, data1);
                        Thread.Sleep(6000);

                    }
                    else if (int.Parse(message) > 80)
                    {
                        byte[] data2 = Encoding.UTF8.GetBytes($"{message} zu hoch: Fenster öffnen");
                        _connection.Publish(raumname, data2);
                        Thread.Sleep(6000);

                    }
                    else
                    {
                        byte[] data = Encoding.UTF8.GetBytes(message);

                        _connection.Publish(raumname, data);

                        Thread.Sleep(6000);
                    }

                }
            }
        }

        private static void LogMessage(string message)
        {
            Console.WriteLine($"{DateTime.Now.ToString("HH:mm:ss.fffff")} - {message}");
        }

        public static void Subscribe(string raum)
        {
            EventHandler<MsgHandlerEventArgs> handler = (sender, args) =>
            {
                string data = Encoding.UTF8.GetString(args.Message.Data);
                LogMessage($"CO2-Wert: {data}");

            };

            IAsyncSubscription s = _connection.SubscribeAsync(raum, handler);
            


        }

        private void consumer_erstellen_button_Click(object sender, EventArgs e)
        {
            using (_connection = ConnectToNats())
            {
                this.Close();
                Process.Start("AvG.exe");
                AllocConsole();

                Console.WriteLine("Raumname:");
                string raumname = Console.ReadLine();
                Subscribe(raumname);

                Console.Clear();
                Console.WriteLine("Connected");
                Console.WriteLine($"Raumname: {raumname}");
                Console.WriteLine("Consumer started");
                Console.ReadKey(true);
                _exit = true;

                _connection.Drain(5000);
            }
        }

        private void fenster_oeffnen_Click(object sender, EventArgs e)
        {

            using (_connection = ConnectToNats())
            {
                this.Close();
                Process.Start("AvG.exe");
                AllocConsole();

                Console.WriteLine("Raumname:");
                string raumname = Console.ReadLine();
                Subscribe(raumname);

                Console.Clear();
                Console.WriteLine("Connected");
                Console.WriteLine($"Raumname: {raumname}");


                byte[] data = Encoding.UTF8.GetBytes("Fenster öffnen");

                _connection.Publish(raumname, data);


            }
        }

        private void fenster_schließen_Click(object sender, EventArgs e)
        {
            using (_connection = ConnectToNats())
            {
                this.Close();
                Process.Start("AvG.exe");
                AllocConsole();

                Console.WriteLine("Raumname:");
                string raumname = Console.ReadLine();
                Subscribe(raumname);

                Console.Clear();
                Console.WriteLine("Connected");
                Console.WriteLine($"Raumname: {raumname}");


                byte[] data = Encoding.UTF8.GetBytes("Fenster schließen");

                _connection.Publish(raumname, data);


            }

        }
    }
}