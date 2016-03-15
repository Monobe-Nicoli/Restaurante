using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Cozinha;
using Pedidos;

namespace EP1_Restaurante
{
    public partial class frmRestaurante : Form
    {
        static Random random = new Random();
        frmGarcom garcom = new frmGarcom();
        frmCozinha cozinha = new frmCozinha();
        static Dictionary<int, string> produtos = new Dictionary<int, string>() {
            {12, "Coxinha"},
            {32, "Coca-Cola"},
            {1, "Torta"},
            {70, "Peixe"},
            {8, "Batata frita"},
            {73, "Chá gelado"}
        };
        static Dictionary<int, string> mesas = new Dictionary<int, string>() {
            {9, "Mesa 1"},
            {8, "Mesa 2"},
            {7, "Mesa 3"},
            {6, "Mesa 4"},
            {5, "Mesa 5"}
        };

        public frmRestaurante()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in produtos)
            {
                listaProdutos.Items.Add(String.Format("{0} - {1}", item.Key, item.Value));
            }
        }

        private void EnviarListaProduto()
        {
            garcom.produtos = produtos;
            cozinha.produtos = produtos;

            garcom.mesas = mesas;
            cozinha.mesas = mesas;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var idRandom = random.Next(1, 250);

            while (produtos.ContainsKey(idRandom))
                idRandom = random.Next(1, 250);

            produtos.Add(idRandom, txtNome.Text);
            listaProdutos.Items.Add(String.Format("{0} - {1}", idRandom, txtNome.Text));
            EnviarListaProduto();
        }

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            int port = int.TryParse(txtPorta.Text, out port) ? port : 0;
            garcom.ip = String.IsNullOrEmpty(txtIp.Text) ? "127.0.0.1" : txtIp.Text;

            garcom.porta = port;
            cozinha.porta = port;
            EnviarListaProduto();

            garcom.Show();
            cozinha.Show();

            this.Hide();
        }
    }
}
