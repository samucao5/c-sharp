namespace ListView
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
            ListViewItem listViewItem4 = new ListViewItem(new string[] { "001", "chave de fenda", "5", "Bosch" }, -1);
            ListViewItem listViewItem5 = new ListViewItem(new string[] { "002", "chave de grifo", "3", "Eda" }, -1);
            ListViewItem listViewItem6 = new ListViewItem(new string[] { "003", "martelo", "2", "MTX" }, -1);
            listView1 = new System.Windows.Forms.ListView();
            id_ferramenta = new ColumnHeader();
            nome_ferramenta = new ColumnHeader();
            estoque = new ColumnHeader();
            marca = new ColumnHeader();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.BorderStyle = BorderStyle.FixedSingle;
            listView1.CheckBoxes = true;
            listView1.Columns.AddRange(new ColumnHeader[] { id_ferramenta, nome_ferramenta, estoque, marca });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listViewItem4.StateImageIndex = 0;
            listViewItem5.StateImageIndex = 0;
            listViewItem6.StateImageIndex = 0;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem4, listViewItem5, listViewItem6 });
            listView1.Location = new Point(178, 44);
            listView1.Name = "listView1";
            listView1.Size = new Size(406, 184);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // id_ferramenta
            // 
            id_ferramenta.Text = "id_ferramenta";
            id_ferramenta.Width = 100;
            // 
            // nome_ferramenta
            // 
            nome_ferramenta.Text = "nome_ferramenta";
            nome_ferramenta.TextAlign = HorizontalAlignment.Center;
            nome_ferramenta.Width = 100;
            // 
            // estoque
            // 
            estoque.Text = "estoque";
            estoque.TextAlign = HorizontalAlignment.Center;
            estoque.Width = 100;
            // 
            // marca
            // 
            marca.Text = "marca";
            marca.TextAlign = HorizontalAlignment.Center;
            marca.Width = 100;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(291, 9);
            label1.Name = "label1";
            label1.Size = new Size(199, 32);
            label1.TabIndex = 1;
            label1.Text = "Ferramentaria";
            // 
            // button1
            // 
            button1.Location = new Point(61, 292);
            button1.Name = "button1";
            button1.Size = new Size(101, 23);
            button1.TabIndex = 2;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(61, 331);
            button2.Name = "button2";
            button2.Size = new Size(101, 23);
            button2.TabIndex = 3;
            button2.Text = "Remover";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(199, 292);
            button3.Name = "button3";
            button3.Size = new Size(101, 23);
            button3.TabIndex = 4;
            button3.Text = "obter";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(199, 331);
            button4.Name = "button4";
            button4.Size = new Size(101, 23);
            button4.TabIndex = 5;
            button4.Text = "selecionando";
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
            Controls.Add(label1);
            Controls.Add(listView1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private ColumnHeader id_ferramenta;
        private ColumnHeader nome_ferramenta;
        private ColumnHeader estoque;
        private ColumnHeader marca;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
