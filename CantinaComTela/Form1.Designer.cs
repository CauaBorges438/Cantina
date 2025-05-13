namespace CantinaComTela
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxProdutos = new ListBox();
            listBoxPedido = new ListBox();
            btnRemover = new Button();
            lblProdutos = new Label();
            btnAdicionar = new Button();
            btnSair = new Button();
            lblCarrinho = new Label();
            total = new Label();
            dateTimePicker1 = new DateTimePicker();
            quantidade = new NumericUpDown();
            dateTimePicker3 = new DateTimePicker();
            txtNome = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)quantidade).BeginInit();
            SuspendLayout();
            // 
            // listBoxProdutos
            // 
            listBoxProdutos.FormattingEnabled = true;
            listBoxProdutos.ItemHeight = 15;
            listBoxProdutos.Location = new Point(116, 158);
            listBoxProdutos.Name = "listBoxProdutos";
            listBoxProdutos.Size = new Size(268, 154);
            listBoxProdutos.TabIndex = 0;
            listBoxProdutos.SelectedIndexChanged += listBoxProdutos_SelectedIndexChanged;
            // 
            // listBoxPedido
            // 
            listBoxPedido.FormattingEnabled = true;
            listBoxPedido.ItemHeight = 15;
            listBoxPedido.Location = new Point(704, 158);
            listBoxPedido.Name = "listBoxPedido";
            listBoxPedido.Size = new Size(281, 154);
            listBoxPedido.TabIndex = 1;
            listBoxPedido.SelectedIndexChanged += listBoxPedido_SelectedIndexChanged;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(474, 255);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(124, 23);
            btnRemover.TabIndex = 2;
            btnRemover.Text = "< Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click_1;
            // 
            // lblProdutos
            // 
            lblProdutos.AutoSize = true;
            lblProdutos.Location = new Point(191, 127);
            lblProdutos.Name = "lblProdutos";
            lblProdutos.Size = new Size(113, 15);
            lblProdutos.TabIndex = 3;
            lblProdutos.Text = "Produtos da cantina";
            lblProdutos.Click += txtProdutos_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(474, 193);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(124, 23);
            btnAdicionar.TabIndex = 4;
            btnAdicionar.Text = "Adicionar >";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(439, 432);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(173, 24);
            btnSair.TabIndex = 5;
            btnSair.Text = "Finalizar compra";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // lblCarrinho
            // 
            lblCarrinho.AutoSize = true;
            lblCarrinho.Location = new Point(821, 127);
            lblCarrinho.Name = "lblCarrinho";
            lblCarrinho.Size = new Size(53, 15);
            lblCarrinho.TabIndex = 6;
            lblCarrinho.Text = "Carrinho";
            // 
            // total
            // 
            total.AutoSize = true;
            total.Font = new Font("Segoe UI", 14F);
            total.Location = new Point(612, 369);
            total.Name = "total";
            total.Size = new Size(0, 25);
            total.TabIndex = 7;
            total.Click += total_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(141, 427);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(83, 23);
            dateTimePicker1.TabIndex = 8;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // quantidade
            // 
            quantidade.Location = new Point(217, 332);
            quantidade.Name = "quantidade";
            quantidade.Size = new Size(43, 23);
            quantidade.TabIndex = 9;
            quantidade.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Format = DateTimePickerFormat.Time;
            dateTimePicker3.Location = new Point(252, 427);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(66, 23);
            dateTimePicker3.TabIndex = 11;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(704, 430);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(281, 23);
            txtNome.TabIndex = 12;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(653, 437);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 13;
            label1.Text = "NOME:";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1578, 685);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Controls.Add(dateTimePicker3);
            Controls.Add(quantidade);
            Controls.Add(dateTimePicker1);
            Controls.Add(total);
            Controls.Add(lblCarrinho);
            Controls.Add(btnSair);
            Controls.Add(btnAdicionar);
            Controls.Add(lblProdutos);
            Controls.Add(btnRemover);
            Controls.Add(listBoxPedido);
            Controls.Add(listBoxProdutos);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)quantidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxProdutos;
        private ListBox listBoxPedido;
        private Button btnRemover;
        private Label lblProdutos;
        private Button btnAdicionar;
        private Button btnSair;
        private Label lblCarrinho;
        private Label total;
        private DateTimePicker dateTimePicker1;
        private NumericUpDown quantidade;
        private DateTimePicker dateTimePicker3;
        private TextBox txtNome;
        private Label label1;
    }
}
