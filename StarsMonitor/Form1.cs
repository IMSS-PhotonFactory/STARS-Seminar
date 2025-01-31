using STARS_BasicTools;
using System.Text;

namespace StarsMonitor
{
    public partial class Form1 : Form
    {
        string keyFilePath = "";

        STARS_Driver? stars = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    keyFilePath = ofd.FileName;
                    textBox_key.Text = Path.GetFileName(ofd.FileName);
                    textBox_key.ReadOnly = true;
                }
                else
                {
                    checkBox1.Checked = false;
                }

            }
            else
            {
                textBox_key.ReadOnly = false;
            }

        }

        private void button_con_Click(object sender, EventArgs e)
        {
            disconnect();
            textBox1.Text = "Stopped";

            var param = new STARS_ConnectionParameter(textBox_ip.Text, (int)numericUpDown_port.Value, textBox_node.Text, textBox_key.Text, true);
            if (checkBox1.Checked)
            {
                param.KeyFilename = keyFilePath;
                param.UseKeyWord = false;
            }

            if (connect(param))
            {
                textBox1.Text = "Running";
                groupBox1.Enabled = false;
            }
            else
            {
                textBox1.Text = "ERROR";
            }
        }

        void disconnect()
        {
            if (stars != null && stars.IsConnected)
            {
                stars.MessageRecievedEvent -= Stars_MessageRecievedEvent;
                stars.Disconnect();
            }
        }

        bool connect(STARS_ConnectionParameter _param)
        {
            stars = new STARS_Driver(_param);

            if (stars.IsConnected)
            {
                stars.MessageRecievedEvent += Stars_MessageRecievedEvent;
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Stars_MessageRecievedEvent(object sender, MessageRecievedEventArgs e)
        {
            Invoke(new Action<string>((str) => addLog(str)), e.allMessage);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            disconnect();
            textBox1.Text = "Stopped";
            groupBox1.Enabled = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            disconnect();
        }

        private void addLog(string log)
        {
            while (listBox_log.Items.Count > (int)numericUpDown_limit.Value)
            {
                listBox_log.Items.RemoveAt(listBox_log.Items.Count - 1);
            }
            listBox_log.Items.Insert(0, $"{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")} {log}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //var sb = new StringBuilder();
            //foreach (var item in listBox_log.Items)
            //{
            //    sb.Append(item.ToString() + "\r\n");
            //}
            //Clipboard.SetText(sb.ToString());

            var log = listBox_log.Items.OfType<string>().ToArray();
            Clipboard.SetText(string.Join("\r\n", log));
        }
    }
}
