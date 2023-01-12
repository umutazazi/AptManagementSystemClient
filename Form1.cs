using System.Net.Sockets;
using System.Net;
using Microsoft.VisualBasic;
using System.Text;
using System.Drawing;
using System.Security.Policy;

namespace CinsApartmentManagementSystem
{
    public partial class Form1 : Form
    {
        Socket client;
        byte[] buffer = new byte[1024];
       
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9050);
            ConnectServer();
           
            
        }
        private void ConnectServer()
        {

            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9050);
            client.Connect(iep);
            statusTextBox.Text = "Connected to: " + client.RemoteEndPoint.ToString();

            client.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None,
            new AsyncCallback(ReceiveData), client);
           







        }
       
        
        void ReceiveData(IAsyncResult AR)
        {


            Socket socket = (Socket)AR.AsyncState;
            int recv = socket.EndReceive(AR);
            byte[] dataBuf = new byte[recv];
            Array.Copy(buffer,dataBuf,recv);
            string receivedData = Encoding.ASCII.GetString(dataBuf);
           
            getWeatherAndCurrency(receivedData);









        }
        void getWeatherAndCurrency(string data)
        {
            string degree;
            string city;
            string weather;
            string usd;
            string eur;

            string[] dataReceived = data.Split("\n");
            degree = dataReceived[0];
            city = dataReceived[1];
            weather = dataReceived[2];
            usd = dataReceived[3];
            eur = dataReceived[4];

           degreeLabel.Text = degree;
            cityLabel.Text = "Ýzmir";
            weatherLabel.Text = weather;
            usdLabel.Text = usd;
            eurLabel.Text = eur;










        }

        private void button1_Click(object sender, EventArgs e)
        {
            TcpChat tcpChat = new TcpChat();
            tcpChat.Show();
        }
    }
       




    }
