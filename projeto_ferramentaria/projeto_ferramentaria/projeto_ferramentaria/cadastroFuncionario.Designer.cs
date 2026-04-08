namespace projeto_ferramentaria
{
    partial class cadastroFuncionarios
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
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            maskedTextBox1 = new MaskedTextBox();
            comboBox3 = new ComboBox();
            textBox2 = new TextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 20);
            menuToolStripMenuItem.Text = "Menu";
            menuToolStripMenuItem.Click += menuToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(298, 51);
            label1.Name = "label1";
            label1.Size = new Size(134, 30);
            label1.TabIndex = 1;
            label1.Text = "Funcionarios";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(25, 112);
            label2.Name = "label2";
            label2.Size = new Size(205, 30);
            label2.TabIndex = 2;
            label2.Text = "Nome Funcionarios:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(25, 157);
            label3.Name = "label3";
            label3.Size = new Size(155, 30);
            label3.TabIndex = 3;
            label3.Text = "Matricula CSN:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(25, 201);
            label4.Name = "label4";
            label4.Size = new Size(182, 30);
            label4.TabIndex = 4;
            label4.Text = "Data Nascimento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F);
            label5.Location = new Point(25, 247);
            label5.Name = "label5";
            label5.Size = new Size(77, 30);
            label5.TabIndex = 5;
            label5.Text = "Cargo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F);
            label6.Location = new Point(25, 295);
            label6.Name = "label6";
            label6.Size = new Size(111, 30);
            label6.TabIndex = 6;
            label6.Text = "Area CSN:";
            // 
            // button1
            // 
            button1.Location = new Point(298, 362);
            button1.Name = "button1";
            button1.Size = new Size(143, 38);
            button1.TabIndex = 7;
            button1.Text = "Enviar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(245, 119);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Digite o nome do funcionario...";
            textBox1.Size = new Size(196, 23);
            textBox1.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Eletricista" });
            comboBox1.Location = new Point(245, 247);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(196, 23);
            comboBox1.TabIndex = 10;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "CSN" });
            comboBox2.Location = new Point(245, 302);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(196, 23);
            comboBox2.TabIndex = 11;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(245, 208);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(61, 23);
            maskedTextBox1.TabIndex = 12;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "CSP", "CSN" });
            comboBox3.Location = new Point(245, 164);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(52, 23);
            comboBox3.TabIndex = 13;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(303, 164);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Matricula da CSN...";
            textBox2.Size = new Size(138, 23);
            textBox2.TabIndex = 9;
            // 
            // cadastroFuncionarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox3);
            Controls.Add(maskedTextBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "cadastroFuncionarios";
            Text = "Cadastro Funcionario";
            Load += cadastroFuncionarios_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private MaskedTextBox maskedTextBox1;
        private ComboBox comboBox3;
        private TextBox textBox2;
    }
}