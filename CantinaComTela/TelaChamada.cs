using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CantinaComTela
{
    public partial class TelaChamada : Form
    {
        public TelaChamada()
        {
            InitializeComponent();
            timer1.Interval = 5000;
            timer1.Tick += timer1_Tick;
        }

        private void TelaChamada_Load(object sender, EventArgs e)
        {
            timer1.Start();
            foreach (var item in Pedido.BaseDePedidos.Pedidos)
            {
                label3.Text = item.Cliente;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
