using STARS_BasicTools;
using System.Text;

namespace StarsDmmEmu
{
    public partial class Form1 : Form
    {
        string keyFilePath = "";

        STARS_Driver? stars = null;

        System.Timers.Timer timer = new System.Timers.Timer();

        decimal pv = 0;
        bool dirPositive = true;

        decimal amp;
        decimal step;

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
            if(e.to == stars.ConnectionParaneters.NodeName)
            {
                switch (e.command)
                {
                    case "GetValue":
                        stars.SendMessage($"{e.from} @GetValue {pv:0.000}");
                        break;
                    
                    default:
                        stars.SendMessage($"{e.from} @{e.command} Er: Command is not found or parameter is not enough.");
                        break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            disconnect();
            textBox1.Text = "Stopped";
            groupBox1.Enabled = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Stop();
            disconnect();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            amp = numericUpDown_amp.Value;
            step = numericUpDown_step.Value;

            timer.Interval = (int)numericUpDown_int.Value;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
        {
            timer.Stop();

            if (dirPositive)
            {
                pv += step;
                if (pv >= amp)
                {
                    pv = amp;
                    dirPositive = false;
                }
            }
            else
            {
                pv -= step;
                if (pv <= amp * -1)
                {
                    pv = amp * -1;
                    dirPositive = true;
                }
            }

            Invoke(new Action<decimal>((val) => textBox_val.Text = val.ToString("0.000")), pv);

            if(stars != null && stars.IsConnected)
            {
                stars.SendMessage($"System _ChangedValue {pv:0.000}");
            }

            timer.Start();
        }

        private void numericUpDown_int_ValueChanged(object sender, EventArgs e)
        {
            timer.Interval = (int)numericUpDown_int.Value;
        }

        private void numericUpDown_amp_ValueChanged(object sender, EventArgs e)
        {
            amp = numericUpDown_amp.Value;
        }

        private void numericUpDown_step_ValueChanged(object sender, EventArgs e)
        {
            step = numericUpDown_step.Value;
        }
    }
}
