using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace Cozinha
{
    public partial class frmCozinha : Form
    {
        static Socket socket;
        static bool alive;
        static byte[] textoRecebido;
        static frmBalcao frm;
        public int porta;
        static Thread threadServer;

        public Dictionary<int, string> produtos;

        public Dictionary<int, string> mesas;
        public frmCozinha()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, porta);
            socket.Bind(ipep);

            socket.SendTimeout = 8000;
            socket.ReceiveTimeout = 8000;

            alive = true;

            threadServer = new Thread(ThreadServer);
            threadServer.Start();

            frm = new frmBalcao();
            frm.Show();
        }

        void ThreadServer()
        {
            byte[] buffer = new byte[1024];

            while (alive)
            {
                try
                {
                    socket.Receive(buffer);
                    textoRecebido = buffer;

                    Invoke(new Action<byte[]>(dePara), new object[] { textoRecebido });
                    buffer = new byte[1024];
                }
                catch (SocketException ex)
                {
                    if (ex.ErrorCode != 10060)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        void dePara(byte[] textoRecebido)
        {
            byte idMesa = textoRecebido[0];
            string nomeMesa = String.Empty;

            foreach (KeyValuePair<int, string> item in mesas)
            {
                if (item.Key == idMesa)
                    nomeMesa = item.Value;
            }

            for (int i = 0; i < textoRecebido.Count(); i++)
            {
                if (textoRecebido[i] != 0 && i != 0)
                {
                    foreach (KeyValuePair<int, string> item in produtos)
                    {
                        if (item.Key == textoRecebido[i])
                            listaPedidos.Items.Add(String.Format("{0} - {1}", item.Value, nomeMesa));
                    }
                }
            }
        }

        private void listaPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listaPedidos.SelectedItem != null)
            {
                frm.monta(listaPedidos.SelectedItem.ToString());
                listaPedidos.Items.Remove(listaPedidos.SelectedItem);
            }
        }

        private void frmCozinha_FormClosing(object sender, FormClosingEventArgs e)
        {
            alive = false;
            threadServer.Join();
            socket.Dispose();
            socket.Close();
            System.Windows.Forms.Application.Exit();
        }
    }
}
