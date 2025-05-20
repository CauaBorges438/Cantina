using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CantinaComTela
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double totalPedido = 0;
        List<Cardapio> pedidos = new();

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            int quant = (int)quantidade.Value;

            if (listBoxProdutos.SelectedIndex != -1 && quantidade.Value > 0)
            {
                Cardapio produtoSelecionado = (Cardapio)listBoxProdutos.SelectedItem;
                Cardapio novoItem = new Cardapio(produtoSelecionado.Produto, produtoSelecionado.Preco);
                novoItem.Quantidade = (int)quantidade.Value;
                listBoxPedido.Items.Add(novoItem);
                pedidos.Add(novoItem);
                totalPedido += produtoSelecionado.Preco * quant;

                total.Text = $"Total: R${totalPedido:f2}";
                listBoxProdutos.SelectedIndex = -1;
                quantidade.Value = 0;
            }
            else
            {
                Console.WriteLine("Quantidade inválida");
            }
        }

        private void listBoxProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxPedido_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBoxProdutos.Items.Add(new Cardapio("Pão de Queijo", 3.50));

            listBoxProdutos.Items.Add(new Cardapio("Coxinha", 5.00));

            listBoxProdutos.Items.Add(new Cardapio("Pastel de Carne", 6.00));

            listBoxProdutos.Items.Add(new Cardapio("Pastel de Queijo", 5.50));

            listBoxProdutos.Items.Add(new Cardapio("Suco Natural (300ml)", 4.00));

            listBoxProdutos.Items.Add(new Cardapio("Refrigerante Lata", 4.50));

            listBoxProdutos.Items.Add(new Cardapio("Hambúrguer Simples ", 8.00));

            listBoxProdutos.Items.Add(new Cardapio("Hambúrguer com Queijo ", 9.00));

            listBoxProdutos.Items.Add(new Cardapio("X-Tudo ", 12.00));

            listBoxProdutos.Items.Add(new Cardapio("Água Mineral (500ml)", 2.50));

            pagamentoBox1.Items.Add("Pix");
            pagamentoBox1.Items.Add("Dinheiro");
            pagamentoBox1.Items.Add("Crédito");
            pagamentoBox1.Items.Add("Débito");
            pagamentoBox1.Items.Add("VR");
            pagamentoBox1.SelectedIndex = 0;

        }

        private void btnRemover_Click_1(object sender, EventArgs e)
        {
            int quant = (int)quantidade.Value;
            if (listBoxPedido.SelectedIndex != -1 && quantidade.Value > 0)
            {
                Cardapio produtoSelecionado = (Cardapio)listBoxPedido.SelectedItem;
                listBoxPedido.Items.Remove(produtoSelecionado);
                totalPedido -= produtoSelecionado.Preco * produtoSelecionado.Quantidade;

                total.Text = $"Total: R${totalPedido:f2}";
                listBoxProdutos.SelectedIndex = -1;
                quantidade.Value = 0;
            }
            else
            {
                Console.WriteLine("Quantidade inválida");
            }
        }

        private void txtProdutos_Click(object sender, EventArgs e)
        {

        }

        private void total_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {

            if (listBoxPedido.Items.Count != 0 && txtNome.Text.Length > 0)
            {
                string Pedido = string.Join("\n", pedidos);

                MessageBox.Show(@$"Consumidor: {txtNome.Text}
{Pedido}

O total é R$ {totalPedido:f2}
");
                total.Text = $"O total é R$ {totalPedido = 0}";
                listBoxPedido.Items.Clear();
                txtNome.Text = "";
                pagamentoBox1.SelectedIndex = 0;


            }
            else if (txtNome.Text.Length <= 0)
            {
                MessageBox.Show("Coloque um nome");
            }
            else
            {
                MessageBox.Show("Não tem pedido");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pagamentoBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pagamentoBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            if (pagamentoBox1.SelectedIndex == 1)
            {
                textBox1.Visible = true;
                label4.Visible = true;
                btnTroco.Visible = true;
                label3.Visible = true;
                textBox2.Visible = true;
            }
            else
            {
                textBox1.Visible = false;
                label4.Visible = false;
                btnTroco.Visible = false;
                label3.Visible = false;
                textBox2.Visible = false;
            }


        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double pago))
            {

                if (pago >= totalPedido)
                {
                    pago = pago - totalPedido;
                    textBox2.Text = pago.ToString();
                }

                else
                {
                    MessageBox.Show("O valor é menor que o total");
                }

            }
        
        }

        private void btnTroco_Click(object sender, EventArgs e)
        {

        }
    }
}
