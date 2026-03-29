namespace MaskedTextBox
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
            maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.BackColor = SystemColors.Control;
            maskedTextBox1.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBox1.Font = new Font("Segoe UI", 12F);
            maskedTextBox1.Location = new Point(334, 41);
            maskedTextBox1.Mask = "(99) 00000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(125, 29);
            maskedTextBox1.TabIndex = 0;
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(50, 98);
            button1.Name = "button1";
            button1.Size = new Size(127, 23);
            button1.TabIndex = 1;
            button1.Text = "Enviar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15F);
            label1.Location = new Point(50, 47);
            label1.Name = "label1";
            label1.Size = new Size(278, 23);
            label1.TabIndex = 2;
            label1.Text = "Digite seu numero de telefone:";
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(50, 321);
            button2.Name = "button2";
            button2.Size = new Size(127, 23);
            button2.TabIndex = 3;
            button2.Text = "Ver senha";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.BackColor = SystemColors.Control;
            maskedTextBox2.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBox2.Font = new Font("Segoe UI", 12F);
            maskedTextBox2.Location = new Point(217, 260);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.PasswordChar = '*';
            maskedTextBox2.Size = new Size(188, 29);
            maskedTextBox2.TabIndex = 4;
            maskedTextBox2.MaskInputRejected += maskedTextBox2_MaskInputRejected;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15F);
            label2.Location = new Point(50, 266);
            label2.Name = "label2";
            label2.Size = new Size(161, 23);
            label2.TabIndex = 5;
            label2.Text = "Digite sua senha:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(maskedTextBox2);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(maskedTextBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private Button button1;
        private Label label1;
        private Button button2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private Label label2;
    }
}
