namespace MenuStrip
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
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            opção1ToolStripMenuItem = new ToolStripMenuItem();
            opção1ToolStripMenuItem1 = new ToolStripMenuItem();
            abrirJanelaToolStripMenuItem = new ToolStripMenuItem();
            marcarToolStripMenuItem = new ToolStripMenuItem();
            opção2ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.Items.AddRange(new ToolStripItem[] { opção1ToolStripMenuItem, opção2ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(126, 450);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // opção1ToolStripMenuItem
            // 
            opção1ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { opção1ToolStripMenuItem1 });
            opção1ToolStripMenuItem.Name = "opção1ToolStripMenuItem";
            opção1ToolStripMenuItem.Size = new Size(113, 19);
            opção1ToolStripMenuItem.Text = "opção 1";
            // 
            // opção1ToolStripMenuItem1
            // 
            opção1ToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { abrirJanelaToolStripMenuItem, marcarToolStripMenuItem });
            opção1ToolStripMenuItem1.Name = "opção1ToolStripMenuItem1";
            opção1ToolStripMenuItem1.Size = new Size(180, 22);
            opção1ToolStripMenuItem1.Text = "opção 1";
            // 
            // abrirJanelaToolStripMenuItem
            // 
            abrirJanelaToolStripMenuItem.Name = "abrirJanelaToolStripMenuItem";
            abrirJanelaToolStripMenuItem.Size = new Size(132, 22);
            abrirJanelaToolStripMenuItem.Text = "abrir janela";
            abrirJanelaToolStripMenuItem.Click += abrirJanelaToolStripMenuItem_Click;
            // 
            // marcarToolStripMenuItem
            // 
            marcarToolStripMenuItem.Name = "marcarToolStripMenuItem";
            marcarToolStripMenuItem.Size = new Size(132, 22);
            marcarToolStripMenuItem.Text = "marcar";
            marcarToolStripMenuItem.Click += marcarToolStripMenuItem_Click;
            // 
            // opção2ToolStripMenuItem
            // 
            opção2ToolStripMenuItem.Name = "opção2ToolStripMenuItem";
            opção2ToolStripMenuItem.Size = new Size(113, 19);
            opção2ToolStripMenuItem.Text = "opção 2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private ToolStripMenuItem opção1ToolStripMenuItem;
        private ToolStripMenuItem opção1ToolStripMenuItem1;
        private ToolStripMenuItem opção2ToolStripMenuItem;
        private ToolStripMenuItem abrirJanelaToolStripMenuItem;
        private ToolStripMenuItem marcarToolStripMenuItem;
    }
}
