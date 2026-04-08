namespace projeto_ferramentaria
{
    partial class Cargos
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
            enviarButton = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(56, 450);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(43, 19);
            menuToolStripMenuItem.Text = "Menu";
            menuToolStripMenuItem.Click += menuToolStripMenuItem_Click;
            // 
            // enviarButton
            // 
            enviarButton.Location = new Point(298, 235);
            enviarButton.Name = "enviarButton";
            enviarButton.Size = new Size(149, 28);
            enviarButton.TabIndex = 1;
            enviarButton.Text = "Enviar";
            enviarButton.UseVisualStyleBackColor = true;
            enviarButton.Click += enviarButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(333, 39);
            label1.Name = "label1";
            label1.Size = new Size(100, 37);
            label1.TabIndex = 2;
            label1.Text = "Cargos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(112, 147);
            label2.Name = "label2";
            label2.Size = new Size(168, 30);
            label2.TabIndex = 3;
            label2.Text = "Digite o Cargos:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10F);
            textBox1.Location = new Point(298, 152);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "digite o cargos..";
            textBox1.Size = new Size(237, 25);
            textBox1.TabIndex = 4;
            // 
            // Cargos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(enviarButton);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Cargos";
            Text = "Cargos";
            Load += Cargos_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private Button enviarButton;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
    }
}