namespace OdemeFormApp
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
            label1 = new Label();
            cmbOdemeYontemleri = new ComboBox();
            label2 = new Label();
            txtTutar = new TextBox();
            btnOdemeYap = new Button();
            lblSonuc = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(226, 89);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 0;
            label1.Text = "Ödeme Yöntemi : ";
            // 
            // cmbOdemeYontemleri
            // 
            cmbOdemeYontemleri.FormattingEnabled = true;
            cmbOdemeYontemleri.Items.AddRange(new object[] { "Seçiniz", "KrediKarti", "MailOrder", "SmsOdeme" });
            cmbOdemeYontemleri.Location = new Point(382, 86);
            cmbOdemeYontemleri.Name = "cmbOdemeYontemleri";
            cmbOdemeYontemleri.Size = new Size(121, 23);
            cmbOdemeYontemleri.TabIndex = 1;
            cmbOdemeYontemleri.SelectedIndexChanged += cmbOdemeYontemleri_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(226, 156);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 2;
            label2.Text = "Tutar : ";
            // 
            // txtTutar
            // 
            txtTutar.Location = new Point(382, 153);
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(121, 23);
            txtTutar.TabIndex = 3;
            // 
            // btnOdemeYap
            // 
            btnOdemeYap.Location = new Point(382, 228);
            btnOdemeYap.Name = "btnOdemeYap";
            btnOdemeYap.Size = new Size(121, 23);
            btnOdemeYap.TabIndex = 4;
            btnOdemeYap.Text = "Ödeme Yap";
            btnOdemeYap.UseVisualStyleBackColor = true;
            btnOdemeYap.Click += btnOdemeYap_Click;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(219, 327);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(49, 15);
            lblSonuc.TabIndex = 5;
            lblSonuc.Text = "Sonuç : ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSonuc);
            Controls.Add(btnOdemeYap);
            Controls.Add(txtTutar);
            Controls.Add(label2);
            Controls.Add(cmbOdemeYontemleri);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbOdemeYontemleri;
        private Label label2;
        private TextBox txtTutar;
        private Button btnOdemeYap;
        private Label lblSonuc;
    }
}