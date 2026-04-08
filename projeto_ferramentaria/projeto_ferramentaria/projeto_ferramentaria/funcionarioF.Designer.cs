namespace projeto_ferramentaria
{
    partial class funcionarioF
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
            label7 = new Label();
            textBox1 = new TextBox();
            comboBox3 = new ComboBox();
            textBox2 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox4 = new ComboBox();
            button1 = new Button();
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
            label1.Location = new Point(255, 49);
            label1.Name = "label1";
            label1.Size = new Size(266, 30);
            label1.TabIndex = 1;
            label1.Text = "Funcionario Ferramentaria";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(12, 115);
            label2.Name = "label2";
            label2.Size = new Size(228, 30);
            label2.TabIndex = 2;
            label2.Text = "Nome do Funcionario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(12, 168);
            label3.Name = "label3";
            label3.Size = new Size(161, 30);
            label3.TabIndex = 3;
            label3.Text = "Matricula CSN: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(12, 213);
            label4.Name = "label4";
            label4.Size = new Size(215, 30);
            label4.TabIndex = 4;
            label4.Text = "Data De Nascimento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F);
            label5.Location = new Point(12, 258);
            label5.Name = "label5";
            label5.Size = new Size(77, 30);
            label5.TabIndex = 5;
            label5.Text = "Cargo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F);
            label6.Location = new Point(12, 302);
            label6.Name = "label6";
            label6.Size = new Size(214, 30);
            label6.TabIndex = 6;
            label6.Text = "Local Ferramentaria: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F);
            label7.Location = new Point(12, 347);
            label7.Name = "label7";
            label7.Size = new Size(111, 30);
            label7.TabIndex = 7;
            label7.Text = "Area CSN:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(255, 122);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Digite o nome do funcionario...";
            textBox1.Size = new Size(196, 23);
            textBox1.TabIndex = 9;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "CSP", "CSN" });
            comboBox3.Location = new Point(255, 168);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(52, 23);
            comboBox3.TabIndex = 15;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(313, 168);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Matricula da CSN...";
            textBox2.Size = new Size(138, 23);
            textBox2.TabIndex = 14;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(255, 220);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.PromptChar = '*';
            maskedTextBox1.Size = new Size(61, 23);
            maskedTextBox1.TabIndex = 16;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Eletricista" });
            comboBox1.Location = new Point(255, 265);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(196, 23);
            comboBox1.TabIndex = 17;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "CSN" });
            comboBox2.Location = new Point(255, 354);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(196, 23);
            comboBox2.TabIndex = 18;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "LTQ", "Praça Som" });
            comboBox4.Location = new Point(255, 309);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(196, 23);
            comboBox4.TabIndex = 19;
            // 
            // button1
            // 
            button1.Location = new Point(341, 401);
            button1.Name = "button1";
            button1.Size = new Size(180, 28);
            button1.TabIndex = 20;
            button1.Text = "Enviar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // funcionarioF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(comboBox4);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(maskedTextBox1);
            Controls.Add(comboBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "funcionarioF";
            Text = "funcionarioF";
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
        private Label label7;
        private TextBox textBox1;
        private ComboBox comboBox3;
        private TextBox textBox2;
        private MaskedTextBox maskedTextBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox4;
        private Button button1;
    }
}