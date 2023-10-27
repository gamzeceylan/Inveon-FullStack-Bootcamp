namespace SerializationInvenOrnek
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
            button2 = new Button();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            txtMaas = new TextBox();
            txtDepartman = new TextBox();
            txtTelefon = new TextBox();
            txtAd = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(520, 445);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(94, 31);
            button2.TabIndex = 35;
            button2.Text = "DeSerialized";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(297, 445);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 34;
            button1.Text = "Serialized";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(442, 229);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(228, 27);
            dateTimePicker1.TabIndex = 33;
            // 
            // txtMaas
            // 
            txtMaas.Location = new Point(441, 341);
            txtMaas.Margin = new Padding(3, 4, 3, 4);
            txtMaas.Name = "txtMaas";
            txtMaas.Size = new Size(114, 27);
            txtMaas.TabIndex = 32;
            // 
            // txtDepartman
            // 
            txtDepartman.Location = new Point(441, 293);
            txtDepartman.Margin = new Padding(3, 4, 3, 4);
            txtDepartman.Name = "txtDepartman";
            txtDepartman.Size = new Size(114, 27);
            txtDepartman.TabIndex = 31;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(441, 183);
            txtTelefon.Margin = new Padding(3, 4, 3, 4);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(114, 27);
            txtTelefon.TabIndex = 30;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(441, 131);
            txtAd.Margin = new Padding(3, 4, 3, 4);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(114, 27);
            txtAd.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(243, 341);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 28;
            label5.Text = "Maaş :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(243, 297);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 27;
            label4.Text = "Departman :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(243, 243);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 26;
            label3.Text = "Doğum Tarihi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(243, 183);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 25;
            label2.Text = "Telefon :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(243, 125);
            label1.Name = "label1";
            label1.Size = new Size(31, 20);
            label1.TabIndex = 24;
            label1.Text = "Ad:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtMaas);
            Controls.Add(txtDepartman);
            Controls.Add(txtTelefon);
            Controls.Add(txtAd);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private TextBox txtMaas;
        private TextBox txtDepartman;
        private TextBox txtTelefon;
        private TextBox txtAd;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}