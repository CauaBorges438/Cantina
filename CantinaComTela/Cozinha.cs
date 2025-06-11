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
    public partial class Cozinha : Form
    {
        public Cozinha()
        {
            InitializeComponent();
        }

        private void listBoxPreparando_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cozinha_Load(object sender, EventArgs e)
        {
            
            
            var pedidos = Serializar.Carregar();
            listBoxPreparando.Items.Clear();

            foreach (var pedido in pedidos)
            {
                if (pedido.Chapa && pedido.Status == Status.Preparando)
                {
                    listBoxPreparando.Items.Add(pedido);
                }
            }
        }
    }
}
    

