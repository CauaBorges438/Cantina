namespace CantinaComTela
{
    partial class Cozinha
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
            listBoxPreparando = new ListBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBoxPreparando
            // 
            listBoxPreparando.FormattingEnabled = true;
            listBoxPreparando.ItemHeight = 15;
            listBoxPreparando.Location = new Point(40, 169);
            listBoxPreparando.Name = "listBoxPreparando";
            listBoxPreparando.Size = new Size(433, 394);
            listBoxPreparando.TabIndex = 0;
            listBoxPreparando.SelectedIndexChanged += listBoxPreparando_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._260a98d8_86c4_417f_9ef5_c8acc317b738_removebg_preview;
            pictureBox1.Location = new Point(426, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(244, 157);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // Cozinha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1111, 674);
            Controls.Add(pictureBox1);
            Controls.Add(listBoxPreparando);
            Name = "Cozinha";
            Text = "Form1";
            Load += Cozinha_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxPreparando;
        private PictureBox pictureBox1;
    }
}