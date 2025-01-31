namespace StarsMonitor
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
            listBox_log = new ListBox();
            label5 = new Label();
            numericUpDown_limit = new NumericUpDown();
            button2 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_port).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_limit).BeginInit();
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
            textBox_node.Text = "Debugger";
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
            // listBox_log
            // 
            listBox_log.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox_log.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            listBox_log.FormattingEnabled = true;
            listBox_log.ItemHeight = 21;
            listBox_log.Location = new Point(12, 170);
            listBox_log.Name = "listBox_log";
            listBox_log.ScrollAlwaysVisible = true;
            listBox_log.Size = new Size(781, 235);
            listBox_log.TabIndex = 12;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label5.Location = new Point(12, 417);
            label5.Name = "label5";
            label5.Size = new Size(116, 21);
            label5.TabIndex = 13;
            label5.Text = "Log linit (Lines)";
            // 
            // numericUpDown_limit
            // 
            numericUpDown_limit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            numericUpDown_limit.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            numericUpDown_limit.Location = new Point(134, 415);
            numericUpDown_limit.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown_limit.Name = "numericUpDown_limit";
            numericUpDown_limit.Size = new Size(96, 29);
            numericUpDown_limit.TabIndex = 14;
            numericUpDown_limit.TextAlign = HorizontalAlignment.Right;
            numericUpDown_limit.Value = new decimal(new int[] { 10000, 0, 0, 0 });
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            button2.Location = new Point(236, 411);
            button2.Name = "button2";
            button2.Size = new Size(101, 33);
            button2.TabIndex = 15;
            button2.Text = "Copy log";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            button3.Location = new Point(692, 411);
            button3.Name = "button3";
            button3.Size = new Size(101, 33);
            button3.TabIndex = 16;
            button3.Text = "QUIT";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(numericUpDown_limit);
            Controls.Add(label5);
            Controls.Add(listBox_log);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(button_con);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Stars Monitor";
            FormClosing += Form1_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_port).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_limit).EndInit();
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
        private ListBox listBox_log;
        private Label label5;
        private NumericUpDown numericUpDown_limit;
        private Button button2;
        private Button button3;
    }
}
