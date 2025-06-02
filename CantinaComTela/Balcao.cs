using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CantinaComTela.Pedido;

namespace CantinaComTela
{
    public partial class Balcao : Form
    {
        public Balcao()
        {
            InitializeComponent();
        }

        private void listBoxPedido_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxEntregue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEntregar_Click(object sender, EventArgs e)
        {
            if (listBoxPedido.SelectedItem is Pedido pedidoSelecionado)
            {
                pedidoSelecionado.Status = "- Entregue";
                listBoxEntregue.Items.Add(pedidoSelecionado);
                listBoxPedido.Items.Remove(pedidoSelecionado);
                Serializar.Salvar(BaseDePedidos.Pedidos);
            }
        }

        private void Balcao_Load(object sender, EventArgs e)
        {
            listBoxPedido.Items.Clear();
            BaseDePedidos.Pedidos = Serializar.Carregar();
            foreach (var pedido in BaseDePedidos.Pedidos)
            {
                if (pedido.Status != "Entregue")
                    listBoxPedido.Items.Add(pedido);
                else
                    listBoxEntregue.Items.Add(pedido);
            }
        }
    }
}

