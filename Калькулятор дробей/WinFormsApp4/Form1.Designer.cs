namespace WinFormsApp4
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
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = SystemColors.ButtonFace;
            button1.Location = new Point(615, 193);
            button1.Name = "button1";
            button1.Size = new Size(126, 50);
            button1.TabIndex = 0;
            button1.Text = "Рассчитать";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBox1.Location = new Point(115, 146);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(52, 23);
            textBox1.TabIndex = 1;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBox2.Location = new Point(296, 146);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(52, 23);
            textBox2.TabIndex = 2;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            comboBox1.BackColor = SystemColors.Info;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "+", "-", "/", "*" });
            comboBox1.Location = new Point(182, 165);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(40, 23);
            comboBox1.TabIndex = 3;
            comboBox1.KeyPress += comboBox1_KeyPress;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBox3.BackColor = SystemColors.MenuBar;
            textBox3.Enabled = false;
            textBox3.Location = new Point(407, 168);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 23);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBox4.Location = new Point(115, 190);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(52, 23);
            textBox4.TabIndex = 5;
            textBox4.KeyPress += textBox4_KeyPress;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBox5.Location = new Point(296, 190);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(52, 23);
            textBox5.TabIndex = 6;
            textBox5.KeyPress += textBox5_KeyPress;
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBox6.Location = new Point(58, 165);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(47, 23);
            textBox6.TabIndex = 7;
            textBox6.Text = "0";
            textBox6.KeyPress += textBox6_KeyPress;
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBox7.Location = new Point(243, 165);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(47, 23);
            textBox7.TabIndex = 8;
            textBox7.Text = "0";
            textBox7.KeyPress += textBox7_KeyPress;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = SystemColors.ButtonFace;
            button2.Location = new Point(615, 137);
            button2.Name = "button2";
            button2.Size = new Size(126, 50);
            button2.TabIndex = 9;
            button2.Text = "Очистить";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.BackColor = SystemColors.ButtonFace;
            button3.Location = new Point(615, 364);
            button3.Name = "button3";
            button3.Size = new Size(126, 50);
            button3.TabIndex = 10;
            button3.Text = "Выйти";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button4.BackColor = SystemColors.ButtonFace;
            button4.Location = new Point(615, 249);
            button4.Name = "button4";
            button4.Size = new Size(126, 50);
            button4.TabIndex = 11;
            button4.Text = "Вывести в Word";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button5.BackColor = SystemColors.ButtonFace;
            button5.Location = new Point(615, 308);
            button5.Name = "button5";
            button5.Size = new Size(126, 50);
            button5.TabIndex = 12;
            button5.Text = "Вывести в Excel";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(127, 146);
            label1.Name = "label1";
            label1.Size = new Size(28, 37);
            label1.TabIndex = 13;
            label1.Text = "_";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(308, 146);
            label2.Name = "label2";
            label2.Size = new Size(28, 37);
            label2.TabIndex = 14;
            label2.Text = "_";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(365, 160);
            label3.Name = "label3";
            label3.Size = new Size(26, 28);
            label3.TabIndex = 15;
            label3.Text = "=";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(182, 20);
            label4.Name = "label4";
            label4.Size = new Size(397, 54);
            label4.TabIndex = 16;
            label4.Text = "Калькулятор дробей";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 308);
            label5.Name = "label5";
            label5.Size = new Size(469, 125);
            label5.TabIndex = 17;
            label5.Text = "Эта программа предназначена для \r\nвычисления простейших дробей с целыми числами.\r\nПрограмма не допускает знаки корня, \r\nзнаки возведения в степень, знаки сравнения,\r\n знак бесконечности, и др.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(780, 480);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}