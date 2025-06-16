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
            {
                listBoxEntregue.Enabled = false;
                listBoxEntregue.SelectedItems.Clear();

                BaseDePedidos.Pedidos = Serializar.CarregarUltimosPedidos(); //<-- aqui é o problema

                if (listBoxEntregue.Items.Count > 5)
                {
                    listBoxEntregue.Items.RemoveAt(4);
                }

                while (listBoxEntregue.Items.Count > 5)
                {
                    listBoxPedido.Items.RemoveAt(0);
                }
            }

        }

        private void btnEntregar_Click(object sender, EventArgs e)
        {
            TelaChamada chamada = new TelaChamada();
            BaseDePedidos Pedidos=new BaseDePedidos();
            chamada.Show();
            if (listBoxEntregue.Items.Count > 4)
            {
                listBoxEntregue.Items.RemoveAt(4);
                
            }
            if (listBoxPedido.SelectedItem is Pedido pedidoSelecionado)
            {
                pedidoSelecionado.Status = Status.Entregue;
                listBoxEntregue.Items.Insert(0,pedidoSelecionado);
                listBoxPedido.Items.Remove(pedidoSelecionado);
                Serializar.Salvar(BaseDePedidos.Pedidos);
            }

        }

        private void Balcao_Load(object sender, EventArgs e)
        {

            listBoxPedido.Items.Clear();
            listBoxEntregue.Items.Clear();

            var todos = Serializar.Carregar();
            BaseDePedidos.Pedidos = todos;

            var entregues = todos.Where(p => p.Status == Status.Entregue).TakeLast(5);
            var pendentes = todos.Where(p =>
                (p.Status == Status.Preparando && !p.Chapa) ||
                (p.Status == Status.Pronto));

            foreach (var pedido in pendentes)
                listBoxPedido.Items.Add(pedido);

            foreach (var pedido in entregues)
                listBoxEntregue.Items.Add(pedido);

        }
        
    }
}

