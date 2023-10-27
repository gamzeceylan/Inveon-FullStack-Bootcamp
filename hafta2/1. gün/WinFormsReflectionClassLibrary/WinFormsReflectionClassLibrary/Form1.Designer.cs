namespace WinFormsReflectionClassLibrary
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
            label2 = new Label();
            txtSayi1 = new TextBox();
            txtSayi2 = new TextBox();
            btnTopla = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(222, 81);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Sayı : 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(222, 123);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Sayı : 2";
            // 
            // txtSayi1
            // 
            txtSayi1.Location = new Point(364, 71);
            txtSayi1.Name = "txtSayi1";
            txtSayi1.Size = new Size(141, 23);
            txtSayi1.TabIndex = 2;
            // 
            // txtSayi2
            // 
            txtSayi2.Location = new Point(364, 123);
            txtSayi2.Name = "txtSayi2";
            txtSayi2.Size = new Size(141, 23);
            txtSayi2.TabIndex = 3;
            // 
            // btnTopla
            // 
            btnTopla.Location = new Point(430, 180);
            btnTopla.Name = "btnTopla";
            btnTopla.Size = new Size(75, 23);
            btnTopla.TabIndex = 4;
            btnTopla.Text = "Topla";
            btnTopla.UseVisualStyleBackColor = true;
            btnTopla.Click += btnTopla_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTopla);
            Controls.Add(txtSayi2);
            Controls.Add(txtSayi1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSayi1;
        private TextBox txtSayi2;
        private Button btnTopla;
    }
}