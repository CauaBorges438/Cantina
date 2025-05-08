namespace CantinaComTela
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double totalPedido = 0;

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (listBoxProdutos.SelectedIndex != -1)
            {
                Cardapio produtoSelecionado = (Cardapio)listBoxProdutos.SelectedItem;
                listBoxPedido.Items.Add(produtoSelecionado);
                totalPedido += produtoSelecionado.Preco;

                total.Text = $"Total: R${totalPedido:f2}";
                listBoxProdutos.SelectedIndex = -1;
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
            if (listBoxPedido.SelectedIndex != -1)
            {
                Cardapio produtoSelecionado = (Cardapio)listBoxPedido.SelectedItem;
                listBoxPedido.Items.Remove(produtoSelecionado);
                totalPedido -= produtoSelecionado.Preco;

                total.Text = $"Total: R${totalPedido:f2}";
                listBoxProdutos.SelectedIndex = -1;
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
            listBoxPedido.Items.Clear();
            MessageBox.Show($"O total é R$ {totalPedido:f2}");
            total.Text= $"O total é R$ {totalPedido = 0}";
        }
    }
}
