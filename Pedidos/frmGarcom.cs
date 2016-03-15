using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Pedidos
{
    public partial class frmGarcom : Form
    {
        static Socket socket;
        static List<int> pedido = new List<int>();
        public int porta;
        public string ip;
        public Dictionary<int, string> produtos;
        public Dictionary<int, string> mesas;

        public frmGarcom()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ddlPrato.DataSource = new BindingSource(produtos, null);
            ddlMesa.DataSource = new BindingSource(mesas, null);

            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.SendTimeout = 8000;
            socket.ReceiveTimeout = 8000;
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            socket.Close();
            socket.Dispose();
            System.Windows.Forms.Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pedido.Add(Convert.ToInt32(ddlPrato.SelectedValue));
            lstPratos.Items.Add(ddlPrato.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[pedido.Count + 1];
            buffer[0] = Convert.ToByte(ddlMesa.SelectedValue);

            for (int i = 0; i < pedido.Count; i++)
            {
                buffer[i + 1] = (byte)pedido[i];
            }

            socket.SendTo(buffer, new IPEndPoint(IPAddress.Parse(ip), porta));
            lstPratos.Items.Clear();
            pedido.Clear();
        }

        private void lstPratos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPratos.SelectedIndex >= 0)
            {
                pedido.RemoveAt(lstPratos.SelectedIndex);
                lstPratos.Items.Remove(lstPratos.SelectedItem);
            }
        }
    }
}
