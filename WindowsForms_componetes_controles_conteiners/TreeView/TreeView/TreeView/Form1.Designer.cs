namespace TreeView
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
            TreeNode treeNode1 = new TreeNode("filho2");
            TreeNode treeNode2 = new TreeNode("filho3");
            TreeNode treeNode3 = new TreeNode("filho1", new TreeNode[] { treeNode1, treeNode2 });
            TreeNode treeNode4 = new TreeNode("valor1", new TreeNode[] { treeNode3 });
            TreeNode treeNode5 = new TreeNode("valor2");
            TreeNode treeNode6 = new TreeNode("valor3");
            treeView1 = new System.Windows.Forms.TreeView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(2, -1);
            treeView1.Name = "treeView1";
            treeNode1.Name = "filho2";
            treeNode1.Text = "filho2";
            treeNode2.Name = "filho3";
            treeNode2.Text = "filho3";
            treeNode3.Name = "filho1";
            treeNode3.Text = "filho1";
            treeNode4.Name = "valor1";
            treeNode4.Text = "valor1";
            treeNode5.Name = "valor2";
            treeNode5.Text = "valor2";
            treeNode6.Name = "valor3";
            treeNode6.Text = "valor3";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode4, treeNode5, treeNode6 });
            treeView1.Size = new Size(239, 450);
            treeView1.TabIndex = 0;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // button1
            // 
            button1.Location = new Point(385, 75);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "mostrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(385, 104);
            button2.Name = "button2";
            button2.Size = new Size(131, 23);
            button2.TabIndex = 2;
            button2.Text = "Adicionar raiz";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(385, 134);
            button3.Name = "button3";
            button3.Size = new Size(131, 23);
            button3.TabIndex = 3;
            button3.Text = "Adicionar filho";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(385, 163);
            button4.Name = "button4";
            button4.Size = new Size(131, 23);
            button4.TabIndex = 4;
            button4.Text = "Adicionar filho 2";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(treeView1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
