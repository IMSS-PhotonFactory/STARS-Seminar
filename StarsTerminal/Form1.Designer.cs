namespace StarsTerminal
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
            button_del = new Button();
            button_add = new Button();
            button_update = new Button();
            comboBox1 = new ComboBox();
            label6 = new Label();
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
            groupBox_send = new GroupBox();
            comboBox_from3 = new ComboBox();
            button13 = new ButtonPlus();
            textBox_para3 = new TextBox();
            comboBox_com3 = new ComboBox();
            comboBox_to3 = new ComboBox();
            comboBox_from2 = new ComboBox();
            button12 = new ButtonPlus();
            textBox_para2 = new TextBox();
            comboBox_com2 = new ComboBox();
            comboBox_to2 = new ComboBox();
            button11 = new ButtonPlus();
            button10 = new ButtonPlus();
            textBox_free3 = new TextBox();
            textBox_free2 = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            comboBox_from = new ComboBox();
            label7 = new Label();
            button8 = new ButtonPlus();
            textBox_para = new TextBox();
            comboBox_com = new ComboBox();
            comboBox_to = new ComboBox();
            button7 = new ButtonPlus();
            textBox_free = new TextBox();
            button9 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_port).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_limit).BeginInit();
            groupBox_send.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button_del);
            groupBox1.Controls.Add(button_add);
            groupBox1.Controls.Add(button_update);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label6);
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
            groupBox1.Size = new Size(665, 196);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "STARS Setting";
            // 
            // button_del
            // 
            button_del.Location = new Point(307, 28);
            button_del.Name = "button_del";
            button_del.Size = new Size(75, 29);
            button_del.TabIndex = 13;
            button_del.Text = "Del";
            button_del.UseVisualStyleBackColor = true;
            button_del.Click += Delete_Click;
            // 
            // button_add
            // 
            button_add.Location = new Point(213, 28);
            button_add.Name = "button_add";
            button_add.Size = new Size(75, 29);
            button_add.TabIndex = 12;
            button_add.Text = "Add";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += Add_Click;
            // 
            // button_update
            // 
            button_update.Location = new Point(403, 27);
            button_update.Name = "button_update";
            button_update.Size = new Size(75, 29);
            button_update.TabIndex = 11;
            button_update.Text = "Update";
            button_update.UseVisualStyleBackColor = true;
            button_update.Click += button4_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(77, 28);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 29);
            comboBox1.TabIndex = 10;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 32);
            label6.Name = "label6";
            label6.Size = new Size(53, 21);
            label6.TabIndex = 9;
            label6.Text = "Preset";
            // 
            // numericUpDown_port
            // 
            numericUpDown_port.Location = new Point(482, 87);
            numericUpDown_port.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            numericUpDown_port.Name = "numericUpDown_port";
            numericUpDown_port.Size = new Size(162, 29);
            numericUpDown_port.TabIndex = 8;
            numericUpDown_port.TextAlign = HorizontalAlignment.Center;
            numericUpDown_port.Value = new decimal(new int[] { 6057, 0, 0, 0 });
            // 
            // textBox_key
            // 
            textBox_key.Location = new Point(482, 125);
            textBox_key.Name = "textBox_key";
            textBox_key.Size = new Size(162, 29);
            textBox_key.TabIndex = 7;
            textBox_key.Text = "stars";
            textBox_key.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_node
            // 
            textBox_node.Location = new Point(162, 125);
            textBox_node.Name = "textBox_node";
            textBox_node.Size = new Size(162, 29);
            textBox_node.TabIndex = 6;
            textBox_node.Text = "term1";
            textBox_node.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_ip
            // 
            textBox_ip.Location = new Point(162, 81);
            textBox_ip.Name = "textBox_ip";
            textBox_ip.Size = new Size(162, 29);
            textBox_ip.TabIndex = 5;
            textBox_ip.Text = "127.0.0.1";
            textBox_ip.TextAlign = HorizontalAlignment.Center;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(539, 160);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(105, 25);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Use Keyfile";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += Preset_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(339, 128);
            label4.Name = "label4";
            label4.Size = new Size(137, 21);
            label4.TabIndex = 3;
            label4.Text = "Password / Keyfile";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 128);
            label3.Name = "label3";
            label3.Size = new Size(94, 21);
            label3.TabIndex = 2;
            label3.Text = "Node Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(415, 89);
            label2.Name = "label2";
            label2.Size = new Size(48, 21);
            label2.TabIndex = 1;
            label2.Text = "Port#";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 84);
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
            button1.Click += Discon_Click;
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
            listBox_log.Location = new Point(12, 508);
            listBox_log.Name = "listBox_log";
            listBox_log.ScrollAlwaysVisible = true;
            listBox_log.Size = new Size(781, 256);
            listBox_log.TabIndex = 12;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label5.Location = new Point(12, 778);
            label5.Name = "label5";
            label5.Size = new Size(116, 21);
            label5.TabIndex = 13;
            label5.Text = "Log linit (Lines)";
            // 
            // numericUpDown_limit
            // 
            numericUpDown_limit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            numericUpDown_limit.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            numericUpDown_limit.Location = new Point(134, 776);
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
            button2.Location = new Point(236, 772);
            button2.Name = "button2";
            button2.Size = new Size(101, 33);
            button2.TabIndex = 15;
            button2.Text = "Copy log";
            button2.UseVisualStyleBackColor = true;
            button2.Click += LogCopy_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            button3.Location = new Point(692, 772);
            button3.Name = "button3";
            button3.Size = new Size(101, 33);
            button3.TabIndex = 16;
            button3.Text = "QUIT";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Quit_Click;
            // 
            // groupBox_send
            // 
            groupBox_send.Controls.Add(comboBox_from3);
            groupBox_send.Controls.Add(button13);
            groupBox_send.Controls.Add(textBox_para3);
            groupBox_send.Controls.Add(comboBox_com3);
            groupBox_send.Controls.Add(comboBox_to3);
            groupBox_send.Controls.Add(comboBox_from2);
            groupBox_send.Controls.Add(button12);
            groupBox_send.Controls.Add(textBox_para2);
            groupBox_send.Controls.Add(comboBox_com2);
            groupBox_send.Controls.Add(comboBox_to2);
            groupBox_send.Controls.Add(button11);
            groupBox_send.Controls.Add(button10);
            groupBox_send.Controls.Add(textBox_free3);
            groupBox_send.Controls.Add(textBox_free2);
            groupBox_send.Controls.Add(label11);
            groupBox_send.Controls.Add(label10);
            groupBox_send.Controls.Add(label9);
            groupBox_send.Controls.Add(label8);
            groupBox_send.Controls.Add(comboBox_from);
            groupBox_send.Controls.Add(label7);
            groupBox_send.Controls.Add(button8);
            groupBox_send.Controls.Add(textBox_para);
            groupBox_send.Controls.Add(comboBox_com);
            groupBox_send.Controls.Add(comboBox_to);
            groupBox_send.Controls.Add(button7);
            groupBox_send.Controls.Add(textBox_free);
            groupBox_send.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            groupBox_send.Location = new Point(12, 214);
            groupBox_send.Name = "groupBox_send";
            groupBox_send.Size = new Size(781, 288);
            groupBox_send.TabIndex = 17;
            groupBox_send.TabStop = false;
            groupBox_send.Text = "Send Message";
            // 
            // comboBox_from3
            // 
            comboBox_from3.FormattingEnabled = true;
            comboBox_from3.Items.AddRange(new object[] { "System", "term1", "term2" });
            comboBox_from3.Location = new Point(18, 245);
            comboBox_from3.Name = "comboBox_from3";
            comboBox_from3.Size = new Size(121, 29);
            comboBox_from3.TabIndex = 36;
            // 
            // button13
            // 
            button13.EntryNumber = 2;
            button13.Location = new Point(700, 245);
            button13.Name = "button13";
            button13.Size = new Size(75, 29);
            button13.TabIndex = 35;
            button13.Text = "Send";
            button13.UseVisualStyleBackColor = true;
            button13.Click += Command_Click;
            // 
            // textBox_para3
            // 
            textBox_para3.Location = new Point(399, 245);
            textBox_para3.Name = "textBox_para3";
            textBox_para3.Size = new Size(295, 29);
            textBox_para3.TabIndex = 34;
            textBox_para3.KeyUp += textBox_para3_KeyUp;
            // 
            // comboBox_com3
            // 
            comboBox_com3.FormattingEnabled = true;
            comboBox_com3.Items.AddRange(new object[] { "GetValue", "SetValue", "hello", "listnodes", "gettime" });
            comboBox_com3.Location = new Point(272, 245);
            comboBox_com3.Name = "comboBox_com3";
            comboBox_com3.Size = new Size(121, 29);
            comboBox_com3.TabIndex = 33;
            // 
            // comboBox_to3
            // 
            comboBox_to3.FormattingEnabled = true;
            comboBox_to3.Items.AddRange(new object[] { "System", "term1", "term2" });
            comboBox_to3.Location = new Point(145, 245);
            comboBox_to3.Name = "comboBox_to3";
            comboBox_to3.Size = new Size(121, 29);
            comboBox_to3.TabIndex = 32;
            // 
            // comboBox_from2
            // 
            comboBox_from2.FormattingEnabled = true;
            comboBox_from2.Items.AddRange(new object[] { "System", "term1", "term2" });
            comboBox_from2.Location = new Point(18, 210);
            comboBox_from2.Name = "comboBox_from2";
            comboBox_from2.Size = new Size(121, 29);
            comboBox_from2.TabIndex = 31;
            // 
            // button12
            // 
            button12.EntryNumber = 1;
            button12.Location = new Point(700, 210);
            button12.Name = "button12";
            button12.Size = new Size(75, 29);
            button12.TabIndex = 30;
            button12.Text = "Send";
            button12.UseVisualStyleBackColor = true;
            button12.Click += Command_Click;
            // 
            // textBox_para2
            // 
            textBox_para2.Location = new Point(399, 210);
            textBox_para2.Name = "textBox_para2";
            textBox_para2.Size = new Size(295, 29);
            textBox_para2.TabIndex = 29;
            textBox_para2.KeyUp += textBox_para2_KeyUp;
            // 
            // comboBox_com2
            // 
            comboBox_com2.FormattingEnabled = true;
            comboBox_com2.Items.AddRange(new object[] { "GetValue", "SetValue", "hello", "listnodes", "gettime" });
            comboBox_com2.Location = new Point(272, 210);
            comboBox_com2.Name = "comboBox_com2";
            comboBox_com2.Size = new Size(121, 29);
            comboBox_com2.TabIndex = 28;
            // 
            // comboBox_to2
            // 
            comboBox_to2.FormattingEnabled = true;
            comboBox_to2.Items.AddRange(new object[] { "System", "term1", "term2" });
            comboBox_to2.Location = new Point(145, 210);
            comboBox_to2.Name = "comboBox_to2";
            comboBox_to2.Size = new Size(121, 29);
            comboBox_to2.TabIndex = 27;
            // 
            // button11
            // 
            button11.EntryNumber = 2;
            button11.Location = new Point(700, 118);
            button11.Name = "button11";
            button11.Size = new Size(75, 29);
            button11.TabIndex = 26;
            button11.Text = "Send";
            button11.UseVisualStyleBackColor = true;
            button11.Click += Free_Click;
            // 
            // button10
            // 
            button10.EntryNumber = 1;
            button10.Location = new Point(700, 84);
            button10.Name = "button10";
            button10.Size = new Size(75, 29);
            button10.TabIndex = 25;
            button10.Text = "Send";
            button10.UseVisualStyleBackColor = true;
            button10.Click += Free_Click;
            // 
            // textBox_free3
            // 
            textBox_free3.Location = new Point(18, 119);
            textBox_free3.Name = "textBox_free3";
            textBox_free3.Size = new Size(676, 29);
            textBox_free3.TabIndex = 24;
            textBox_free3.KeyUp += textBox_free3_KeyUp;
            // 
            // textBox_free2
            // 
            textBox_free2.Location = new Point(18, 84);
            textBox_free2.Name = "textBox_free2";
            textBox_free2.Size = new Size(676, 29);
            textBox_free2.TabIndex = 23;
            textBox_free2.KeyUp += textBox_free2_KeyUp;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(399, 151);
            label11.Name = "label11";
            label11.Size = new Size(160, 21);
            label11.TabIndex = 22;
            label11.Text = "Parameters (optional)";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(272, 151);
            label10.Name = "label10";
            label10.Size = new Size(83, 21);
            label10.TabIndex = 21;
            label10.Text = "Command";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(145, 151);
            label9.Name = "label9";
            label9.Size = new Size(25, 21);
            label9.TabIndex = 20;
            label9.Text = "To";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 151);
            label8.Name = "label8";
            label8.Size = new Size(46, 21);
            label8.TabIndex = 19;
            label8.Text = "From";
            // 
            // comboBox_from
            // 
            comboBox_from.FormattingEnabled = true;
            comboBox_from.Items.AddRange(new object[] { "System", "term1", "term2" });
            comboBox_from.Location = new Point(18, 175);
            comboBox_from.Name = "comboBox_from";
            comboBox_from.Size = new Size(121, 29);
            comboBox_from.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 25);
            label7.Name = "label7";
            label7.Size = new Size(113, 21);
            label7.TabIndex = 17;
            label7.Text = "Free command";
            // 
            // button8
            // 
            button8.EntryNumber = 0;
            button8.Location = new Point(700, 175);
            button8.Name = "button8";
            button8.Size = new Size(75, 29);
            button8.TabIndex = 16;
            button8.Text = "Send";
            button8.UseVisualStyleBackColor = true;
            button8.Click += Command_Click;
            // 
            // textBox_para
            // 
            textBox_para.Location = new Point(399, 175);
            textBox_para.Name = "textBox_para";
            textBox_para.Size = new Size(295, 29);
            textBox_para.TabIndex = 15;
            textBox_para.KeyUp += textBox_para_KeyUp;
            // 
            // comboBox_com
            // 
            comboBox_com.FormattingEnabled = true;
            comboBox_com.Items.AddRange(new object[] { "GetValue", "SetValue", "hello", "listnodes", "gettime" });
            comboBox_com.Location = new Point(272, 175);
            comboBox_com.Name = "comboBox_com";
            comboBox_com.Size = new Size(121, 29);
            comboBox_com.TabIndex = 14;
            // 
            // comboBox_to
            // 
            comboBox_to.FormattingEnabled = true;
            comboBox_to.Items.AddRange(new object[] { "System", "term1", "term2" });
            comboBox_to.Location = new Point(145, 175);
            comboBox_to.Name = "comboBox_to";
            comboBox_to.Size = new Size(121, 29);
            comboBox_to.TabIndex = 13;
            // 
            // button7
            // 
            button7.EntryNumber = 0;
            button7.Location = new Point(700, 49);
            button7.Name = "button7";
            button7.Size = new Size(75, 29);
            button7.TabIndex = 12;
            button7.Text = "Send";
            button7.UseVisualStyleBackColor = true;
            button7.Click += Free_Click;
            // 
            // textBox_free
            // 
            textBox_free.Location = new Point(18, 49);
            textBox_free.Name = "textBox_free";
            textBox_free.Size = new Size(676, 29);
            textBox_free.TabIndex = 6;
            textBox_free.KeyUp += textBox_free_KeyUp;
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button9.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            button9.Location = new Point(343, 772);
            button9.Name = "button9";
            button9.Size = new Size(101, 33);
            button9.TabIndex = 18;
            button9.Text = "Clear log";
            button9.UseVisualStyleBackColor = true;
            button9.Click += LogClr_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 811);
            Controls.Add(button9);
            Controls.Add(groupBox_send);
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
            Text = "Stars Terminal";
            FormClosing += Form1_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_port).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_limit).EndInit();
            groupBox_send.ResumeLayout(false);
            groupBox_send.PerformLayout();
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
        private Button button_del;
        private Button button_add;
        private Button button_update;
        private ComboBox comboBox1;
        private Label label6;
        private GroupBox groupBox_send;
        private ButtonPlus button7;
        private TextBox textBox_free;
        private ButtonPlus button8;
        private TextBox textBox_para;
        private ComboBox comboBox_com;
        private ComboBox comboBox_to;
        private Button button9;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private ComboBox comboBox_from;
        private Label label7;
        private ButtonPlus button11;
        private ButtonPlus button10;
        private TextBox textBox_free3;
        private TextBox textBox_free2;
        private ComboBox comboBox_from3;
        private ButtonPlus button13;
        private TextBox textBox_para3;
        private ComboBox comboBox_com3;
        private ComboBox comboBox_to3;
        private ComboBox comboBox_from2;
        private ButtonPlus button12;
        private TextBox textBox_para2;
        private ComboBox comboBox_com2;
        private ComboBox comboBox_to2;
    }
}
