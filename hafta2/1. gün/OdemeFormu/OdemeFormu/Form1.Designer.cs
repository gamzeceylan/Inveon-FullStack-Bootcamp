namespace OdemeFormu
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
            lblTutar = new Label();
            tbxTutar = new TextBox();
            button1 = new Button();
            lblOdemeTipi = new Label();
            cmbOdeme = new ComboBox();
            lblSonuc = new Label();
            SuspendLayout();
            // 
            // lblTutar
            // 
            lblTutar.AutoSize = true;
            lblTutar.Location = new Point(272, 133);
            lblTutar.Name = "lblTutar";
            lblTutar.Size = new Size(34, 15);
            lblTutar.TabIndex = 0;
            lblTutar.Text = "Tutar";
            lblTutar.Click += lblTutar_Click;
            // 
            // tbxTutar
            // 
            tbxTutar.Location = new Point(352, 130);
            tbxTutar.Name = "tbxTutar";
            tbxTutar.Size = new Size(121, 23);
            tbxTutar.TabIndex = 1;
            tbxTutar.TextChanged += tbxTutar_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(352, 178);
            button1.Name = "button1";
            button1.Size = new Size(121, 31);
            button1.TabIndex = 2;
            button1.Text = "Ödeme Yap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblOdemeTipi
            // 
            lblOdemeTipi.AutoSize = true;
            lblOdemeTipi.Location = new Point(272, 80);
            lblOdemeTipi.Name = "lblOdemeTipi";
            lblOdemeTipi.Size = new Size(68, 15);
            lblOdemeTipi.TabIndex = 3;
            lblOdemeTipi.Text = "Ödeme Tipi";
            lblOdemeTipi.Click += lblOdemeTipi_Click;
            // 
            // cmbOdeme
            // 
            cmbOdeme.FormattingEnabled = true;
            cmbOdeme.Items.AddRange(new object[] { "Seçiniz" });
            cmbOdeme.Location = new Point(352, 80);
            cmbOdeme.Name = "cmbOdeme";
            cmbOdeme.Size = new Size(121, 23);
            cmbOdeme.TabIndex = 4;
            cmbOdeme.SelectedIndexChanged += cmbOdeme_SelectedIndexChanged;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(272, 276);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(49, 15);
            lblSonuc.TabIndex = 5;
            lblSonuc.Text = "Sonuç : ";
            lblSonuc.Click += lblSonuc_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 488);
            Controls.Add(lblSonuc);
            Controls.Add(cmbOdeme);
            Controls.Add(lblOdemeTipi);
            Controls.Add(button1);
            Controls.Add(tbxTutar);
            Controls.Add(lblTutar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTutar;
        private TextBox tbxTutar;
        private Button button1;
        private Label lblOdemeTipi;
        private ComboBox cmbOdeme;
        private Label lblSonuc;
    }
}