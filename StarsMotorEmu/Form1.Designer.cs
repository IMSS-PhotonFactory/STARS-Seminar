namespace StarsMotorEmu
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
            groupBox1 = new GroupBox();
            numericUpDown_port = new NumericUpDown();
            textBox_key = new TextBox();
            textBox_node = new TextBox();
            textBox_ip = new TextBox();
            checkBox1 = new CheckBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button_con = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            button3 = new Button();
            groupBox2 = new GroupBox();
            textBox_stat = new TextBox();
            textBox_val = new TextBox();
            numericUpDown_step = new NumericUpDown();
            numericUpDown_int = new NumericUpDown();
            label7 = new Label();
            label8 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_port).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_step).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_int).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numericUpDown_port);
            groupBox1.Controls.Add(textBox_key);
            groupBox1.Controls.Add(textBox_node);
            groupBox1.Controls.Add(textBox_ip);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(665, 152);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "STARS Setting";
            // 
            // numericUpDown_port
            // 
            numericUpDown_port.Location = new Point(482, 43);
            numericUpDown_port.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            numericUpDown_port.Name = "numericUpDown_port";
            numericUpDown_port.Size = new Size(162, 29);
            numericUpDown_port.TabIndex = 8;
            numericUpDown_port.TextAlign = HorizontalAlignment.Center;
            numericUpDown_port.Value = new decimal(new int[] { 6057, 0, 0, 0 });
            // 
            // textBox_key
            // 
            textBox_key.Location = new Point(482, 81);
            textBox_key.Name = "textBox_key";
            textBox_key.Size = new Size(162, 29);
            textBox_key.TabIndex = 7;
            textBox_key.Text = "stars";
            textBox_key.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_node
            // 
            textBox_node.Location = new Point(162, 81);
            textBox_node.Name = "textBox_node";
            textBox_node.Size = new Size(162, 29);
            textBox_node.TabIndex = 6;
            textBox_node.Text = "motoremu";
            textBox_node.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_ip
            // 
            textBox_ip.Location = new Point(162, 37);
            textBox_ip.Name = "textBox_ip";
            textBox_ip.Size = new Size(162, 29);
            textBox_ip.TabIndex = 5;
            textBox_ip.Text = "127.0.0.1";
            textBox_ip.TextAlign = HorizontalAlignment.Center;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(539, 116);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(105, 25);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Use Keyfile";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(339, 84);
            label4.Name = "label4";
            label4.Size = new Size(137, 21);
            label4.TabIndex = 3;
            label4.Text = "Password / Keyfile";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 84);
            label3.Name = "label3";
            label3.Size = new Size(94, 21);
            label3.TabIndex = 2;
            label3.Text = "Node Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(415, 45);
            label2.Name = "label2";
            label2.Size = new Size(48, 21);
            label2.TabIndex = 1;
            label2.Text = "Port#";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 40);
            label1.Name = "label1";
            label1.Size = new Size(138, 21);
            label1.TabIndex = 0;
            label1.Text = "IP address / FQDN";
            // 
            // button_con
            // 
            button_con.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            button_con.Location = new Point(692, 38);
            button_con.Name = "button_con";
            button_con.Size = new Size(101, 33);
            button_con.TabIndex = 9;
            button_con.Text = "Connect";
            button_con.UseVisualStyleBackColor = true;
            button_con.Click += button_con_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            button1.Location = new Point(692, 79);
            button1.Name = "button1";
            button1.Size = new Size(101, 33);
            button1.TabIndex = 10;
            button1.Text = "Disconnect";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            textBox1.Location = new Point(692, 120);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(101, 29);
            textBox1.TabIndex = 11;
            textBox1.Text = "Stopped";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            button3.Location = new Point(692, 287);
            button3.Name = "button3";
            button3.Size = new Size(101, 33);
            button3.TabIndex = 16;
            button3.Text = "QUIT";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox_stat);
            groupBox2.Controls.Add(textBox_val);
            groupBox2.Controls.Add(numericUpDown_step);
            groupBox2.Controls.Add(numericUpDown_int);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            groupBox2.Location = new Point(15, 176);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(781, 102);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Value";
            // 
            // textBox_stat
            // 
            textBox_stat.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            textBox_stat.Location = new Point(194, 50);
            textBox_stat.Name = "textBox_stat";
            textBox_stat.ReadOnly = true;
            textBox_stat.Size = new Size(135, 29);
            textBox_stat.TabIndex = 24;
            textBox_stat.Text = "Stopped";
            textBox_stat.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_val
            // 
            textBox_val.Font = new Font("Yu Gothic UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            textBox_val.Location = new Point(18, 35);
            textBox_val.Name = "textBox_val";
            textBox_val.ReadOnly = true;
            textBox_val.Size = new Size(162, 46);
            textBox_val.TabIndex = 23;
            textBox_val.TextAlign = HorizontalAlignment.Center;
            // 
            // numericUpDown_step
            // 
            numericUpDown_step.Increment = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDown_step.Location = new Point(593, 51);
            numericUpDown_step.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDown_step.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown_step.Name = "numericUpDown_step";
            numericUpDown_step.Size = new Size(102, 29);
            numericUpDown_step.TabIndex = 21;
            numericUpDown_step.TextAlign = HorizontalAlignment.Right;
            numericUpDown_step.Value = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDown_step.ValueChanged += numericUpDown_step_ValueChanged;
            // 
            // numericUpDown_int
            // 
            numericUpDown_int.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown_int.Location = new Point(438, 51);
            numericUpDown_int.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDown_int.Name = "numericUpDown_int";
            numericUpDown_int.Size = new Size(102, 29);
            numericUpDown_int.TabIndex = 20;
            numericUpDown_int.TextAlign = HorizontalAlignment.Right;
            numericUpDown_int.Value = new decimal(new int[] { 200, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(546, 53);
            label7.Name = "label7";
            label7.Size = new Size(41, 21);
            label7.TabIndex = 19;
            label7.Text = "Step";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(335, 53);
            label8.Name = "label8";
            label8.Size = new Size(97, 21);
            label8.TabIndex = 17;
            label8.Text = "Interval / ms";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 326);
            Controls.Add(groupBox2);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(button_con);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Stars MOTOR Emu";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_port).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_step).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_int).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private NumericUpDown numericUpDown_port;
        private TextBox textBox_key;
        private TextBox textBox_node;
        private TextBox textBox_ip;
        private CheckBox checkBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button_con;
        private Button button1;
        private TextBox textBox1;
        private Button button3;
        private GroupBox groupBox2;
        private TextBox textBox_val;
        private NumericUpDown numericUpDown_step;
        private NumericUpDown numericUpDown_int;
        private Label label7;
        private Label label8;
        private TextBox textBox_stat;
    }
}
