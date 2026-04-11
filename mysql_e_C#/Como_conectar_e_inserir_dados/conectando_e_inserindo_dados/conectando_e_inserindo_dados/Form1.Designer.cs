namespace conectando_e_inserindo_dados
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
            label3 = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtTel = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 0;
            label1.Text = "nome do contato:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 97);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 1;
            label2.Text = "email do contato:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 141);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 2;
            label3.Text = "telefone do contato:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(9, 62);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "digite seu nome...";
            txtNome.Size = new Size(164, 23);
            txtNome.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(9, 115);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "digite seu email...";
            txtEmail.Size = new Size(164, 23);
            txtEmail.TabIndex = 4;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(9, 159);
            txtTel.Name = "txtTel";
            txtTel.PlaceholderText = "digite seu telefone...";
            txtTel.Size = new Size(164, 23);
            txtTel.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(53, 215);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(210, 265);
            Controls.Add(button1);
            Controls.Add(txtTel);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(label3);
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
        private Label label3;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtTel;
        private Button button1;
    }
}
