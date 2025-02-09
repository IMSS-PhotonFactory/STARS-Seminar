using STARS;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        STARS.StarsInterface stars;

        string TextData;

        decimal dmmvalue = 0;
        decimal motorvalue = 0;
        bool motormoving = false;

        public Form1()
        {
            InitializeComponent();

            stars = new STARS.StarsInterface("myapp", "127.0.0.1", @"myapp.key", 6057);
            stars.Connect();
            stars.DataReceived += Stars_DataReceived;
            stars.CallbackOn();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stars.Send(textBox2.Text);
        }

        private void Stars_DataReceived(object? sender, StarsCbArgs e)
        {
            TextData = e.allMessage;

            if (e.from == "dmmemu")
            {
                if (e.command == "@GetValue" | e.command == "_ChangedValue")
                {
                    dmmvalue = decimal.Parse(e.parameters);
                }
            }
            else if (e.from == "motoremu")
            {
                if (e.command == "@GetValue" | e.command == "_ChangedValue")
                {
                    motorvalue = decimal.Parse(e.parameters);
                }
                else if (e.command == "@IsBusy" | e.command == "_ChangedIsBusy")
                {
                    if (e.parameters == "1")
                    {
                        motormoving = true;
                    }
                    else
                    {
                        motormoving = false;
                    }
                }
            }

            Invoke(new Action(TextDisplay));
        }

        void TextDisplay()
        {
            textBox1.Text = TextData;
            textBox3.Text = dmmvalue.ToString();
            textBox4.Text = motorvalue.ToString();
            if (motormoving == true)
            {
                textBox5.Text = "ìÆçÏíÜ";
            }
            else
            {
                textBox5.Text = "í‚é~íÜ";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            stars.DataReceived -= Stars_DataReceived;
            stars.Disconnect();
        }
    }
}
