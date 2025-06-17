namespace Lab6_Dydelf
{
    partial class Ustawienia
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label7 = new Label();
            label6 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(194, 196);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(194, 284);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(685, 196);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(401, 196);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(528, 284);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(528, 196);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(449, 292);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 13;
            label4.Text = "Czas Gry";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(198, 164);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 14;
            label1.Text = "Wymiary planszy";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(401, 164);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 15;
            label2.Text = "Ilość Dydelfów";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(528, 164);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 16;
            label3.Text = "Ilość Szopów";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(685, 164);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 17;
            label5.Text = "Ilość Krokodyli";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(164, 287);
            label7.Name = "label7";
            label7.Size = new Size(14, 15);
            label7.TabIndex = 18;
            label7.Text = "Y";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(155, 204);
            label6.Name = "label6";
            label6.Size = new Size(14, 15);
            label6.TabIndex = 19;
            label6.Text = "X";
            // 
            // button1
            // 
            button1.Location = new Point(659, 284);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 20;
            button1.Text = "Zastosuj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Ustawienia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 581);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Ustawienia";
            Text = "Ustawienia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label7;
        private Label label6;
        private Button button1;
    }
}