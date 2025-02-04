using STARS_BasicTools;
using System.Text;

namespace StarsMotorEmu
{
    public partial class Form1 : Form
    {
        string keyFilePath = "";

        STARS_Driver? stars = null;

        System.Timers.Timer timer = new System.Timers.Timer();

        decimal pv = 0;
        decimal sv = 0;

        decimal step;

        volatile bool isMoving = false;

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
            if (e.to == stars.ConnectionParaneters.NodeName)
            {
                switch (e.command)
                {
                    case "GetValue":
                        stars.SendMessage($"{e.from} @GetValue {pv:0.000}");
                        break;

                    case "SetValue":
                        if(isMoving)
                        {
                            stars.SendMessage($"{e.from} @{e.command} Er: Busy");
                            break;
                        }
                        
                        if(decimal.TryParse(e.parameters, out decimal value))
                        {
                            stars.SendMessage($"{e.from} @SetValue {e.parameters}"); 
                            MoveAxis(value);
                        }
                        else
                        {
                            stars.SendMessage($"{e.from} @{e.command} Er: Command is not found or parameter is not enough.");
                        }
                        
                        break;

                    case "IsBusy":
                        stars.SendMessage($"{e.from} @IsBusy {Convert.ToInt32(isMoving)}");
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
            disconnect();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            textBox_val.Text = pv.ToString("0");
            textBox_stat.Text = "Stopped";

            step = numericUpDown_step.Value;

            timer.Interval = (int)numericUpDown_int.Value;
            timer.Elapsed += Timer_Elapsed;
        }

        private void Timer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
        {
            timer.Stop();

            if (sv > pv)
            {
                pv += step;
                if (pv >= sv)
                {
                    pv = sv;
                }
            }
            else
            {
                pv -= step;
                if (pv <= sv)
                {
                    pv = sv;
                }
            }

            Invoke(new Action<decimal>((val) => textBox_val.Text = val.ToString("0")), pv);

            if (stars != null && stars.IsConnected)
            {
                stars.SendMessage($"System _ChangedValue {pv:0}");
            }

            if(pv == sv) 
            {
                isMoving = false;
            }
            else
            {
                timer.Start();
            }
        }

        private void numericUpDown_step_ValueChanged(object sender, EventArgs e)
        {
            step = numericUpDown_step.Value;
        }

        async void  MoveAxis(decimal target)
        {
            sv = target;
            isMoving = true;

            stars.SendMessage($"System _ChangedIsBusy 1");
            Invoke(new Action(() => textBox_stat.Text = "Moving"));

            timer.Start();

            await Task.Run(() =>
            {
                while (isMoving) { Thread.Sleep(10); }
            });

            stars.SendMessage($"System _ChangedIsBusy 0");
            Invoke(new Action(() => textBox_stat.Text = "Stopped"));
        }
    }
}
