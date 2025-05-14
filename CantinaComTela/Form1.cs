using System.Windows.Forms;

namespace CantinaComTela
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double totalPedido = 0;
        List<Cardapio> pedido = new();

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            int quant = (int)quantidade.Value;
            
            if (listBoxProdutos.SelectedIndex != -1 && quantidade.Value > 0)
            {
                Cardapio produtoSelecionado = (Cardapio)listBoxProdutos.SelectedItem;
                Cardapio novoItem = new Cardapio(produtoSelecionado.Produto, produtoSelecionado.Preco);
                novoItem.Quantidade= (int)quantidade.Value;
                listBoxPedido.Items.Add(novoItem);
                totalPedido += produtoSelecionado.Preco * quant;

                total.Text = $"Total: R${totalPedido:f2}";
                listBoxProdutos.SelectedIndex = -1;
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

            listBoxProdutos.Items.Add(new Cardapio("Coxinha", 5.00));

            listBoxProdutos.Items.Add(new Cardapio("Pastel", 6.00));

            listBoxProdutos.Items.Add(new Cardapio("Refrigerante", 4.50));

            listBoxProdutos.Items.Add(new Cardapio("Suco", 3.00));

            listBoxProdutos.Items.Add(new Cardapio("Brigadeiro", 3.00));
        }

        private void btnRemover_Click_1(object sender, EventArgs e)
        {
            int quant = (int)quantidade.Value;
            if (listBoxPedido.SelectedIndex != -1 && quantidade.Value > 0)
            {
                Cardapio produtoSelecionado = (Cardapio)listBoxPedido.SelectedItem;
                listBoxPedido.Items.Remove(produtoSelecionado);
                totalPedido -= produtoSelecionado.Preco;

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
            int quant = (int)quantidade.Value;
            if (listBoxPedido.Items.Count != 0 && txtNome.Text.Length > 0)
            {
                
                MessageBox.Show(@$"O total é R$ {quant}x {totalPedido:f2}

{txtNome.Text} 
{dateTimePicker1.Text} 
{dateTimePicker3.Text}");
                total.Text = $"O total é R$ {totalPedido = 0}";
                listBoxPedido.Items.Clear();
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
    }
}
