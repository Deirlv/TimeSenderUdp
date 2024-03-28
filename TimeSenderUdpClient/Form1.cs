using System.Net.Sockets;
using System.Net;
using System.Text;
using static System.Windows.Forms.DataFormats;
using System.Globalization;

namespace TimeSenderUdpClient
{
    public partial class Form1 : Form
    {
        static IPAddress address = IPAddress.Parse("192.168.0.107");
        IPEndPoint endPoint = new IPEndPoint(address, 1040);
        DateTime time = DateTime.Now;

        public Form1()
        {
            Opacity = 0.5;
            ControlBox = false;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Task.Run(async () =>
            {
                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.IP);
                socket.Bind(endPoint);

                byte[] buffer = new byte[1024];

                do
                {
                    EndPoint endPointAny = new IPEndPoint(IPAddress.Any, 1040);
                    await socket.ReceiveFromAsync(new ArraySegment<byte>(buffer), SocketFlags.None, endPointAny)
                    .ContinueWith(t =>
                    {
                        SocketReceiveFromResult result = t.Result;
                        string d = Encoding.Default.GetString(buffer, 0, result.ReceivedBytes);
                        labelTime.BeginInvoke(new Action<string>(s => { labelTime.Text = s;}), d);
                    });
                } while (true);
            });
        }

        private void SetTime(string obj)
        {
            Opacity = 1;
            labelTime.Text = obj;
            time = DateTime.Parse(obj);
            timerTime.Enabled = true;
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            if (DateTime.TryParseExact(labelTime.Text, "HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out time))
            {
                time.AddSeconds(1);
                labelTime.Text = time.ToShortTimeString();
            }
            else
            {
                MessageBox.Show("Error with parsing time!");
                timerTime.Enabled = false;
            }
        }
    }
}
