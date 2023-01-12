using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinsApartmentManagementSystem
{

    public partial class TcpChat : Form
    {

        private byte[] data = new byte[1024];
         private int size = 1024;
         Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        
    




        public TcpChat()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
           
           

        }

        private void connectButton_Click(object sender, EventArgs e)
        {
           statusTextBox.Text = "Connecting...";
            Socket newsock = new Socket(AddressFamily.InterNetwork,
            SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9060);
            newsock.BeginConnect(iep, new AsyncCallback(Connected), newsock);
         
           


        }
        void Connected(IAsyncResult iar)
        {
            client = (Socket)iar.AsyncState;
            try
            {
                client.EndConnect(iar);
                statusTextBox.Text = "Connected to: " + client.RemoteEndPoint.ToString();
                client.BeginReceive(data, 0, size, SocketFlags.None,
                new AsyncCallback(ReceiveData), client);
            }
            catch (SocketException)
            {
                statusTextBox.Text = "Error connecting";
            }
        }
        
        
        void ReceiveData(IAsyncResult iar)
        {
            Socket remote = (Socket)iar.AsyncState;
            int recv = remote.EndReceive(iar);
            string stringData = Encoding.ASCII.GetString(data, 0, recv);
            listBox1.Items.Add(stringData);
        }
        
        private void sendButton_Click(object sender, EventArgs e)
        {
            byte[] message = Encoding.ASCII.GetBytes(textBox1.Text);
            textBox1.Clear();
            client.BeginSend(message, 0, message.Length, SocketFlags.None,
            new AsyncCallback(SendData), client);
            
            
        }

        void SendData(IAsyncResult iar)
        {
            
            Socket remote = (Socket)iar.AsyncState;
            int sent = remote.EndSend(iar);
            remote.BeginReceive(data, 0, size, SocketFlags.None,
            new AsyncCallback(ReceiveData), remote);
            
           
        }

        

        void AcceptConn(IAsyncResult iar)
        {
            Socket oldserver = (Socket)iar.AsyncState;
            client = oldserver.EndAccept(iar);
            listBox1.Items.Add("Connection from: " + client.RemoteEndPoint.ToString());
            Thread receiver = new Thread(new ThreadStart(ReceiveData));
            receiver.Start();
        }
       
       
        void ReceiveData()
        {
            int recv;
            string stringData;
            while (true)
            {
                recv = client.Receive(data);
                stringData = Encoding.ASCII.GetString(data, 0, recv);
                if (stringData == "bye")
                    break;
                listBox1.Items.Add(stringData);
            }
            stringData = "bye";
            byte[] message = Encoding.ASCII.GetBytes(stringData);
            client.Send(message);
            client.Close();
            listBox1.Items.Add("Connection stopped");
            return;
        }
















    }


}

























    








