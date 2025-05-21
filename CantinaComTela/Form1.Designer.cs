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
            pagamentoBox1 = new ComboBox();
            btnEncerrar = new Button();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            btnTroco = new Button();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)quantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBoxProdutos
            // 
            listBoxProdutos.BackColor = Color.White;
            listBoxProdutos.Font = new Font("Agrandir", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBoxProdutos.ForeColor = Color.FromArgb(17, 25, 12);
            listBoxProdutos.FormattingEnabled = true;
            listBoxProdutos.Location = new Point(77, 158);
            listBoxProdutos.Name = "listBoxProdutos";
            listBoxProdutos.Size = new Size(307, 164);
            listBoxProdutos.TabIndex = 0;
            listBoxProdutos.SelectedIndexChanged += listBoxProdutos_SelectedIndexChanged;
            // 
            // listBoxPedido
            // 
            listBoxPedido.BackColor = Color.White;
            listBoxPedido.Font = new Font("Agrandir", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBoxPedido.ForeColor = Color.FromArgb(17, 25, 12);
            listBoxPedido.FormattingEnabled = true;
            listBoxPedido.Location = new Point(664, 158);
            listBoxPedido.Name = "listBoxPedido";
            listBoxPedido.Size = new Size(321, 164);
            listBoxPedido.TabIndex = 1;
            listBoxPedido.SelectedIndexChanged += listBoxPedido_SelectedIndexChanged;
            // 
            // btnRemover
            // 
            btnRemover.BackColor = Color.FromArgb(225, 255, 0);
            btnRemover.Font = new Font("Agrandir", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemover.Location = new Point(463, 255);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(149, 23);
            btnRemover.TabIndex = 2;
            btnRemover.Text = "< Remover";
            btnRemover.UseVisualStyleBackColor = false;
            btnRemover.Click += btnRemover_Click_1;
            // 
            // lblProdutos
            // 
            lblProdutos.AutoSize = true;
            lblProdutos.Font = new Font("Agrandir", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProdutos.Location = new Point(191, 127);
            lblProdutos.Name = "lblProdutos";
            lblProdutos.Size = new Size(120, 16);
            lblProdutos.TabIndex = 3;
            lblProdutos.Text = "Produtos da cantina";
            lblProdutos.Click += txtProdutos_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.FromArgb(225, 255, 0);
            btnAdicionar.Font = new Font("Agrandir", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionar.Location = new Point(463, 193);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(149, 23);
            btnAdicionar.TabIndex = 4;
            btnAdicionar.Text = "Adicionar >";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.FromArgb(225, 255, 0);
            btnSair.Font = new Font("Agrandir", 8.249999F, FontStyle.Bold);
            btnSair.Location = new Point(439, 562);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(217, 26);
            btnSair.TabIndex = 5;
            btnSair.Text = "Finalizar compra";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // lblCarrinho
            // 
            lblCarrinho.AutoSize = true;
            lblCarrinho.Font = new Font("Agrandir", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCarrinho.Location = new Point(821, 127);
            lblCarrinho.Name = "lblCarrinho";
            lblCarrinho.Size = new Size(58, 16);
            lblCarrinho.TabIndex = 6;
            lblCarrinho.Text = "Carrinho";
            // 
            // total
            // 
            total.AutoSize = true;
            total.Font = new Font("Agrandir", 8.249999F, FontStyle.Bold);
            total.Location = new Point(597, 485);
            total.Name = "total";
            total.Size = new Size(62, 15);
            total.TabIndex = 7;
            total.Text = "Total: R$ 0";
            total.Click += total_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Agrandir", 8.249999F, FontStyle.Bold);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(177, 563);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(83, 22);
            dateTimePicker1.TabIndex = 8;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // quantidade
            // 
            quantidade.Font = new Font("Agrandir", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            quantidade.Location = new Point(217, 332);
            quantidade.Name = "quantidade";
            quantidade.Size = new Size(43, 23);
            quantidade.TabIndex = 9;
            quantidade.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Font = new Font("Agrandir", 8.249999F, FontStyle.Bold);
            dateTimePicker3.Format = DateTimePickerFormat.Time;
            dateTimePicker3.Location = new Point(290, 563);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(68, 22);
            dateTimePicker3.TabIndex = 11;
            dateTimePicker3.ValueChanged += dateTimePicker3_ValueChanged;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Agrandir", 8.249999F, FontStyle.Bold);
            txtNome.Location = new Point(864, 331);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(121, 22);
            txtNome.TabIndex = 12;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agrandir", 8.249999F, FontStyle.Bold);
            label1.Location = new Point(809, 334);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 13;
            label1.Text = "NOME:";
            label1.Click += label1_Click;
            // 
            // pagamentoBox1
            // 
            pagamentoBox1.Font = new Font("Agrandir", 8.249999F, FontStyle.Bold);
            pagamentoBox1.FormattingEnabled = true;
            pagamentoBox1.Location = new Point(864, 363);
            pagamentoBox1.Name = "pagamentoBox1";
            pagamentoBox1.Size = new Size(121, 23);
            pagamentoBox1.TabIndex = 14;
            pagamentoBox1.SelectedIndexChanged += pagamentoBox1_SelectedIndexChanged;
            // 
            // btnEncerrar
            // 
            btnEncerrar.BackColor = Color.FromArgb(225, 255, 0);
            btnEncerrar.Font = new Font("Agrandir", 8.249999F, FontStyle.Bold);
            btnEncerrar.Location = new Point(767, 565);
            btnEncerrar.Name = "btnEncerrar";
            btnEncerrar.Size = new Size(107, 23);
            btnEncerrar.TabIndex = 15;
            btnEncerrar.Text = "Sair";
            btnEncerrar.UseVisualStyleBackColor = false;
            btnEncerrar.Click += btnEncerrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Agrandir", 8.249999F, FontStyle.Bold);
            label2.Location = new Point(716, 367);
            label2.Name = "label2";
            label2.Size = new Size(139, 15);
            label2.TabIndex = 16;
            label2.Text = "FORMA DE PAGAMENTO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Agrandir", 8.249999F, FontStyle.Bold);
            label3.Location = new Point(805, 437);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 17;
            label3.Text = "TROCO:";
            label3.Visible = false;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Agrandir", 8.249999F, FontStyle.Bold);
            textBox2.Location = new Point(864, 463);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 22);
            textBox2.TabIndex = 19;
            textBox2.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Agrandir", 8.249999F, FontStyle.Bold);
            label4.Location = new Point(808, 401);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 20;
            label4.Text = "VALOR:";
            label4.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._260a98d8_86c4_417f_9ef5_c8acc317b738_removebg_preview;
            pictureBox1.Location = new Point(412, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(244, 157);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // btnTroco
            // 
            btnTroco.BackColor = Color.FromArgb(225, 255, 0);
            btnTroco.Font = new Font("Agrandir", 8.249999F, FontStyle.Bold);
            btnTroco.Location = new Point(864, 433);
            btnTroco.Name = "btnTroco";
            btnTroco.Size = new Size(121, 23);
            btnTroco.TabIndex = 22;
            btnTroco.Text = "Troco";
            btnTroco.UseVisualStyleBackColor = false;
            btnTroco.Visible = false;
            btnTroco.Click += btnTroco_Click;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Agrandir", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(864, 399);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(121, 23);
            textBox3.TabIndex = 23;
            textBox3.KeyPress += textBox3_KeyPress;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(864, 492);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 24;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Agrandir", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(802, 495);
            label5.Name = "label5";
            label5.Size = new Size(51, 16);
            label5.TabIndex = 25;
            label5.Text = "Viagem:";
            label5.Click += label5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1046, 629);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(btnTroco);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnEncerrar);
            Controls.Add(pagamentoBox1);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private ComboBox pagamentoBox1;
        private Button btnEncerrar;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private PictureBox pictureBox1;
        private Button btnTroco;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private Label label5;
    }
}
