using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace TimeSenderServer
{
    public partial class Form1 : Form
    {
        Thread thread;
    
        public Form1()
        {
            InitializeComponent();
        }

        private async void SendFunc(object? obj)
        {        
            while (true)
            {
                IPAddress address = IPAddress.Parse("192.168.0.107");
                IPEndPoint endPoint = new IPEndPoint(address, 1040);
                Socket sendSocket = obj as Socket;
                string sent = $"{numericUpDownHours.Value}:{numericUpDownMinutes.Value}:{numericUpDownSeconds.Value}";
                byte[] buff = Encoding.Default.GetBytes(sent);
                await sendSocket.SendToAsync(new ArraySegment<byte>(buff), SocketFlags.None, endPoint);
                sendSocket.Shutdown(SocketShutdown.Send);
                sendSocket.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDownHours.Value = DateTime.Now.Hour;
            numericUpDownMinutes.Value = DateTime.Now.Minute;
            numericUpDownSeconds.Value = DateTime.Now.Second;
        }

        private async void buttonSend_Click(object sender, EventArgs e)
        {
            if (thread != null)
                return;
            EndPoint endPoint = new IPEndPoint(IPAddress.Any, 11000);
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.IP);
            socket.Bind(endPoint);
            thread = new Thread(SendFunc);
            thread.IsBackground = true;
            thread.Start(socket);
            Text = "Server is working!";
        }
    }
}
