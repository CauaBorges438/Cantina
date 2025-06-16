namespace CantinaComTela
{
    partial class Balcao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxEntregue = new ListBox();
            pictureBox1 = new PictureBox();
            listBoxPedido = new ListBox();
            btnEntregar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBoxEntregue
            // 
            listBoxEntregue.FormattingEnabled = true;
            listBoxEntregue.ItemHeight = 15;
            listBoxEntregue.Location = new Point(12, 425);
            listBoxEntregue.Name = "listBoxEntregue";
            listBoxEntregue.Size = new Size(1024, 139);
            listBoxEntregue.TabIndex = 1;
            listBoxEntregue.SelectedIndexChanged += listBoxEntregue_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._260a98d8_86c4_417f_9ef5_c8acc317b738_removebg_preview;
            pictureBox1.Location = new Point(399, -10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(244, 157);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // listBoxPedido
            // 
            listBoxPedido.FormattingEnabled = true;
            listBoxPedido.ItemHeight = 15;
            listBoxPedido.Location = new Point(12, 153);
            listBoxPedido.Name = "listBoxPedido";
            listBoxPedido.Size = new Size(1024, 244);
            listBoxPedido.TabIndex = 23;
            listBoxPedido.SelectedIndexChanged += listBoxPedido_SelectedIndexChanged;
            // 
            // btnEntregar
            // 
            btnEntregar.BackColor = Color.FromArgb(225, 255, 0);
            btnEntregar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEntregar.Location = new Point(399, 612);
            btnEntregar.Name = "btnEntregar";
            btnEntregar.Size = new Size(244, 50);
            btnEntregar.TabIndex = 24;
            btnEntregar.Text = "Entregar";
            btnEntregar.UseVisualStyleBackColor = false;
            btnEntregar.Click += btnEntregar_Click;
            // 
            // Balcao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1048, 698);
            Controls.Add(btnEntregar);
            Controls.Add(listBoxPedido);
            Controls.Add(pictureBox1);
            Controls.Add(listBoxEntregue);
            Name = "Balcao";
            Load += Balcao_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ListBox listBoxEntregue;
        private PictureBox pictureBox1;
        private ListBox listBoxPedido;
        private Button btnEntregar;
    }
}