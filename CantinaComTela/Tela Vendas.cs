using System.Diagnostics.Eventing.Reader;
using System.Net.Http.Headers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static CantinaComTela.Carrinho;
using static CantinaComTela.Pedido;

namespace CantinaComTela
{
    public partial class formsVenda : Form
    {
        private Carrinho carrinho;
        public formsVenda()
        {
            InitializeComponent();
            carrinho = new Carrinho();
        }

        private double totalPedido = 0;
        List<Cardapio> pedidos2 = new();
        public string formaPagamento;
        public string cliente;
        public string paraViagem;
        public string hora;



        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            int quant = (int)quantidade.Value;

            if (listBoxProdutos.SelectedIndex != -1 && quantidade.Value > 0)
            {
                Cardapio produtoSelecionado = (Cardapio)listBoxProdutos.SelectedItem;
                Cardapio novoItem = new Cardapio(produtoSelecionado.Produto, produtoSelecionado.Preco, produtoSelecionado.IsChapa);
                novoItem.Quantidade = (int)quantidade.Value;
                listBoxPedido.Items.Add(novoItem);
                pedidos2.Add(novoItem);
                carrinho.Adicionar(novoItem);
                totalPedido += produtoSelecionado.Preco * quant;

                total.Text = $"Total: R${totalPedido:f2}";
                listBoxProdutos.SelectedIndex = -1;
                AtualizarListBox2();
                AtualizarTotal();
                quantidade.Value = 1;
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
            listBoxProdutos.Items.Add(new Cardapio("Pão de Queijo", 3.50, false));

            listBoxProdutos.Items.Add(new Cardapio("Coxinha", 5.00, false));

            listBoxProdutos.Items.Add(new Cardapio("Pastel de Carne", 6.00, true));

            listBoxProdutos.Items.Add(new Cardapio("Pastel de Queijo", 5.50, true));

            listBoxProdutos.Items.Add(new Cardapio("Suco Natural (300ml)", 4.00, false));

            listBoxProdutos.Items.Add(new Cardapio("Refrigerante Lata", 4.50, false));

            listBoxProdutos.Items.Add(new Cardapio("Hambúrguer Simples ", 8.00, true));

            listBoxProdutos.Items.Add(new Cardapio("Hambúrguer com Queijo ", 9.00, true));

            listBoxProdutos.Items.Add(new Cardapio("X-Tudo ", 12.00, true));

            listBoxProdutos.Items.Add(new Cardapio("Água Mineral (500ml)", 2.50, false));

            pagamentoBox1.Items.Add("Pix");
            pagamentoBox1.Items.Add("Dinheiro");
            pagamentoBox1.Items.Add("Crédito");
            pagamentoBox1.Items.Add("Débito");
            pagamentoBox1.Items.Add("VR");
            pagamentoBox1.SelectedIndex = 0;

            comboBox1.Items.Add("Não");
            comboBox1.Items.Add("Sim");
            comboBox1.SelectedIndex = 0;
        }

        private void btnRemover_Click_1(object sender, EventArgs e)
        {

            int quant = (int)quantidade.Value;
            if (listBoxPedido.SelectedIndex != -1 && quantidade.Value > 0)
            {
                Cardapio produtoSelecionado = (Cardapio)listBoxPedido.SelectedItem;
                listBoxPedido.Items.Remove(produtoSelecionado);

                carrinho.Remover(produtoSelecionado);
                totalPedido -= produtoSelecionado.Preco * produtoSelecionado.Quantidade;

                total.Text = $"Total: R${totalPedido:f2}";
                listBoxProdutos.SelectedIndex = -1;
                quantidade.Value = 0;
                AtualizarListBox2();
                AtualizarTotal();
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
            

            if (listBoxPedido.Items.Count != 0 && txtNome.Text.Length > 0 && (textBox2.Text != "" && pagamentoBox1.SelectedIndex == 1))
            {
                var produtos = carrinho.ObterProdutos();
                var produtosChapa = produtos.Where(p => p.IsChapa).ToList();
                var produtosNaoChapa = produtos.Where(p => !p.IsChapa).ToList();

                string nomeCliente = txtNome.Text;
                string paraViagem = comboBox1.SelectedItem?.ToString() ?? "Não";
                string agora = dateTimePicker3.Text;

                
                if (produtosChapa.Any())
                {
                    Pedido pedidoChapa = new Pedido
                    {
                        Cliente = nomeCliente,
                        ParaViagem = paraViagem,
                        Hora = agora,
                        Itens = string.Join(", ", produtosChapa.Select(p => $"{p.Quantidade} x {p.Produto} - R$ {(p.Preco * p.Quantidade):F2}")),
                        Status = Status.Preparando,
                        Chapa = true
                    };

                    BaseDePedidos.Pedidos.Add(pedidoChapa);
                }

                
                if (produtosNaoChapa.Any())
                {
                    Pedido pedidoNormal = new Pedido
                    {
                        Cliente = nomeCliente,
                        ParaViagem = paraViagem,
                        Hora = agora,
                        Itens = string.Join(", ", produtosNaoChapa.Select(p => $"{p.Quantidade} x {p.Produto} - R$ {(p.Preco * p.Quantidade):F2}")),
                        Status = Status.Preparando,
                        Chapa = false
                    };

                    BaseDePedidos.Pedidos.Add(pedidoNormal);
                }

               
                Serializar.Salvar(BaseDePedidos.Pedidos);
                string Pedido = string.Join("\n", pedidos2);

                MessageBox.Show(@$"Cliente: {txtNome.Text}
{Pedido}

O total é R$ {totalPedido:f2}

Para viagem: {comboBox1.Text}

Forma de Pagamento: {pagamentoBox1.Text}

{DateTime.Now}  {dateTimePicker3.Text}
");


                total.Text = $"O total é R$ {totalPedido = 0}";
                listBoxPedido.Items.Clear();
                pedidos2.Clear();
                comboBox1.SelectedIndex = 0;
                textBox2.Clear();
                textBox3.Clear();
                txtNome.Text = "";
                pagamentoBox1.SelectedIndex = 0;
                carrinho.Limpar();
                AtualizarListBox2();
                AtualizarTotal();
            }


            else if (listBoxPedido.Items.Count != 0 && txtNome.Text.Length > 0 && pagamentoBox1.SelectedIndex != 1)
            {
                var produtos = carrinho.ObterProdutos();
                var produtosChapa = produtos.Where(p => p.IsChapa).ToList();
                var produtosNaoChapa = produtos.Where(p => !p.IsChapa).ToList();

                string nomeCliente = txtNome.Text;
                string paraViagem = comboBox1.SelectedItem?.ToString() ?? "Não";
                string agora = dateTimePicker3.Text;


                if (produtosChapa.Any())
                {
                    Pedido pedidoChapa = new Pedido
                    {
                        Cliente = nomeCliente,
                        ParaViagem = paraViagem,
                        Hora = agora,
                        Itens = string.Join(", ", produtosChapa.Select(p => $"{p.Quantidade} x {p.Produto} - R$ {(p.Preco * p.Quantidade):F2}")),
                        Status = Status.Preparando,
                        Chapa = true
                    };

                    BaseDePedidos.Pedidos.Add(pedidoChapa);
                }


                if (produtosNaoChapa.Any())
                {
                    Pedido pedidoNormal = new Pedido
                    {
                        Cliente = nomeCliente,
                        ParaViagem = paraViagem,
                        Hora = agora,
                        Itens = string.Join(", ", produtosNaoChapa.Select(p => $"{p.Quantidade} x {p.Produto} - R$ {(p.Preco * p.Quantidade):F2}")),
                        Status = Status.Preparando,
                        Chapa = false
                    };

                    BaseDePedidos.Pedidos.Add(pedidoNormal);
                }


                Serializar.Salvar(BaseDePedidos.Pedidos);
                string Pedido = string.Join("\n", pedidos2);

                MessageBox.Show(@$"Cliente: {txtNome.Text}
{Pedido}

O total é R$ {totalPedido:f2}

Para viagem: {comboBox1.Text}

Forma de Pagamento: {pagamentoBox1.Text}

{DateTime.Now}  {dateTimePicker3.Text}
");


                total.Text = $"O total é R$ {totalPedido = 0}";
                listBoxPedido.Items.Clear();
                pedidos2.Clear();
                comboBox1.SelectedIndex = 0;
                textBox2.Clear();
                textBox3.Clear();
                txtNome.Text = "";
                pagamentoBox1.SelectedIndex = 0;
                carrinho.Limpar();
                AtualizarListBox2();
                AtualizarTotal();
            }

            else if (txtNome.Text.Length <= 0)
            {
                MessageBox.Show("Coloque um nome");
            }

            else if (listBoxPedido.Items.Count <= 0)
            {
                MessageBox.Show("Precisa de um item do cardápio");
            }

            else
            {
                MessageBox.Show("Não tem o valor suficiente");
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
                textBox3.Visible = true;
                label4.Visible = true;
                btnTroco.Visible = true;
                label3.Visible = true;
                textBox2.Visible = true;
                textBox2.ReadOnly = true;
            }
            else
            {
                textBox3.Visible = false;
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


        }

        private void btnTroco_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox3.Text, out double pago))
            {

                if (pago >= totalPedido)
                {
                    pago = pago - totalPedido;
                    textBox2.Text = pago.ToString("F2");
                }

                else
                {
                    MessageBox.Show("Valor menor que o total");
                }
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            var txt = sender as System.Windows.Forms.TextBox;

            if (char.IsControl(e.KeyChar))
                return;

            if (char.IsDigit(e.KeyChar))
                return;

            if (e.KeyChar == ',' && !txt.Text.Contains(","))
                return;

            e.Handled = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {



        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnBalcao_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is Balcao)
                {
                    f.Close();
                    break;
                }
            }

            Balcao novaJanela = new Balcao();
            novaJanela.Show();
        }

        private void AtualizarListBox2()
        {
            listBoxPedido.Items.Clear();
            foreach (var item in carrinho.ObterProdutos())
            {
                listBoxPedido.Items.Add(item);
            }
        }
        private void AtualizarTotal()
        {
            total.Text = $"Total: R${totalPedido:F2}";
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is Cozinha)
                {
                    f.Close();
                    break;
                }
            }

            Cozinha novaJanela = new Cozinha();
            novaJanela.Show();
        }
    }
}
