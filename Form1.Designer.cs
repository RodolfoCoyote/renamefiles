namespace ProyectoUno
{
    partial class Init
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
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            textBox3 = new TextBox();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 66);
            label2.Name = "label2";
            label2.Size = new Size(445, 22);
            label2.TabIndex = 1;
            label2.Text = "Indica el nombre del nuevo proyecto (sin espacios):";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(463, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(222, 26);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(463, 62);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(222, 26);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(18, 21);
            label3.Name = "label3";
            label3.Size = new Size(342, 22);
            label3.TabIndex = 3;
            label3.Text = "Indica la palabra a reemplazar (ej. REF)";
            // 
            // button1
            // 
            button1.Location = new Point(302, 446);
            button1.Name = "button1";
            button1.Size = new Size(129, 43);
            button1.TabIndex = 5;
            button1.Text = "Continuar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(21, 114);
            button2.Name = "button2";
            button2.Size = new Size(106, 43);
            button2.TabIndex = 7;
            button2.Text = "Seleccionar carpeta";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(133, 125);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(552, 23);
            textBox3.TabIndex = 8;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 17;
            listBox1.Location = new Point(31, 205);
            listBox1.Name = "listBox1";
            listBox1.SelectionMode = SelectionMode.None;
            listBox1.Size = new Size(329, 225);
            listBox1.TabIndex = 9;
            // 
            // listBox2
            // 
            listBox2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 17;
            listBox2.Location = new Point(375, 205);
            listBox2.Name = "listBox2";
            listBox2.SelectionMode = SelectionMode.None;
            listBox2.Size = new Size(310, 225);
            listBox2.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(122, 183);
            label4.Name = "label4";
            label4.Size = new Size(124, 16);
            label4.TabIndex = 11;
            label4.Text = "Nombres actuales:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(463, 183);
            label5.Name = "label5";
            label5.Size = new Size(114, 16);
            label5.TabIndex = 12;
            label5.Text = "Nombres futuros:";
            // 
            // Init
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 501);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(textBox3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Init";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestor de nombres de archivos para proyectos.";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Button button1;
        private Button button2;
        private TextBox textBox3;
        private ListBox listBox1;
        private ListBox listBox2;
        private Label label4;
        private Label label5;
    }
}