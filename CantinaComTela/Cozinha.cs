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

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBoxPreparando.SelectedItem is Pedido pedidoSelecionado)
            {
               
                pedidoSelecionado.Status = Status.Pronto;

                
                var todos = Serializar.Carregar();

                
                var pedidoOriginal = todos.FirstOrDefault(p =>
                    p.Cliente == pedidoSelecionado.Cliente &&
                    p.Hora == pedidoSelecionado.Hora &&
                    p.Itens == pedidoSelecionado.Itens
                );

                if (pedidoOriginal != null)
                {
                    pedidoOriginal.Status = Status.Pronto;
                    Serializar.Salvar(todos);
                }
                listBoxPreparando.Items.Remove(pedidoSelecionado);

                MessageBox.Show("Pedido enviado ao Balcão.");
            }
            else
            {
                MessageBox.Show("Selecione um pedido.");
            }
        }
    }
    
}
    

