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
            listBoxEntregue.SelectedItems.Clear();
            if (listBoxEntregue.Items.Count > 5)
            {
                listBoxEntregue.Items.RemoveAt(5);

            }

        }

        private void btnEntregar_Click(object sender, EventArgs e)
        {
            if (listBoxEntregue.Items.Count >= 6)
            {
                listBoxEntregue.Items.RemoveAt(5);
                
            }
            if (listBoxPedido.SelectedItem is Pedido pedidoSelecionado)
            {
                pedidoSelecionado.Status = "- Entregue";
                listBoxEntregue.Items.Insert(0,pedidoSelecionado);
                listBoxPedido.Items.Remove(pedidoSelecionado);
                Serializar.Salvar(BaseDePedidos.Pedidos);
            }

        }

        private void Balcao_Load(object sender, EventArgs e)
        {

            //if (listBoxEntregue.Items.Count >= 6)
            //{
            //    listBoxEntregue.Items.RemoveAt(5);

            //}



            foreach (var pedido in BaseDePedidos.Pedidos)
            {

                if (pedido.Status == "- Entregue")
                { 
                BaseDePedidos.Pedidos = Serializar.CarregarUltimosPedidos();
                listBoxEntregue.Items.Add(pedido);
                }
                else
                {
                    BaseDePedidos.Pedidos = Serializar.Carregar();
                    listBoxPedido.Items.Add(pedido);
                }

            }
        }
    }
}

