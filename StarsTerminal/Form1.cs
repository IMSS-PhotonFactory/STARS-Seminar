using Microsoft.VisualBasic.Devices;
using STARS_BasicTools;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace StarsTerminal
{
    public partial class Form1 : Form
    {
        string configFile = "config.jspn";
        string configFilePath = "config.jspn";

        string keyFilePath = "";

        STARS_Driver? stars = null;

        List<ConnectionPreset> presetCon = new List<ConnectionPreset>();

        List<TextBoxGroup> tbGroup = new List<TextBoxGroup>();

        bool stopUpdate = false;

        public Form1()
        {
            InitializeComponent();

            groupBox_send.Enabled = false;

            tbGroup.Add(new TextBoxGroup() { Free = textBox_free, From = comboBox_from, To = comboBox_to, Com = comboBox_com, Param = textBox_para });
            tbGroup.Add(new TextBoxGroup() { Free = textBox_free2, From = comboBox_from2, To = comboBox_to2, Com = comboBox_com2, Param = textBox_para2 });
            tbGroup.Add(new TextBoxGroup() { Free = textBox_free3, From = comboBox_from3, To = comboBox_to3, Com = comboBox_com3, Param = textBox_para3 });

            var currentPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            if(currentPath == null)
            {
                currentPath = @".\";
            }

            configFilePath = Path.Combine(currentPath, configFile);

            presetCon = LoadConfig(configFilePath);
            updateListView(presetCon);
            if (presetCon.Count > 0)
            {
                SetPreset();
            }
        }

        List<ConnectionPreset> LoadConfig(string _filepath)
        {
            List<ConnectionPreset>? res = new List<ConnectionPreset>();

            if (File.Exists(_filepath))
            {
                try
                {
                    using (var sr = new StreamReader(_filepath))
                    {
                        res = JsonSerializer.Deserialize<List<ConnectionPreset>>(sr.ReadToEnd());
                    }
                }
                catch (Exception)
                {
                    res = new List<ConnectionPreset> { };
                    return res;
                }
            }

            if(res == null)
            {
                res = new List<ConnectionPreset>();
            }

            return res;
        }

        void SaveConfig(string _filepath, List<ConnectionPreset> _config)
        {
            using (var sw = new StreamWriter(_filepath, false))
            {
                sw.WriteLine(JsonSerializer.Serialize(_config, new JsonSerializerOptions { WriteIndented = true }));
                sw.Close();
            }
        }

        void updateListView(List<ConnectionPreset> _presetCon, int _select = 0)
        {
            comboBox1.Items.Clear();
            foreach (ConnectionPreset preset in _presetCon)
            {
                comboBox1.Items.Add(preset.Name);
            }

            if (comboBox1.Items.Count > 0)
            {
                if (_select < comboBox1.Items.Count)
                {
                    comboBox1.SelectedIndex = _select;
                }
                else
                {
                    comboBox1.SelectedIndex = 0;
                }
            }
        }

        private void Preset_CheckedChanged(object sender, EventArgs e)
        {
            if (stopUpdate)
            {
                if (checkBox1.Checked)
                {
                    textBox_key.Text = Path.GetFileName(keyFilePath);
                    textBox_key.ReadOnly = true;
                }
                else
                {
                    textBox_key.ReadOnly = false;
                }

                return;
            }

            if (checkBox1.Checked)
            {
                if (!stopUpdate)
                {
                    OpenFileDialog ofd = new OpenFileDialog();
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        keyFilePath = ofd.FileName;
                    }
                    else
                    {
                        checkBox1.Checked = false;
                        return;
                    }

                }

                textBox_key.Text = Path.GetFileName(keyFilePath);
                textBox_key.ReadOnly = true;
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
                groupBox_send.Enabled = true;

                if (stars != null)
                {
                    foreach (var item in tbGroup)
                    {
                        if (item.From != null)
                        {
                            item.From.Items.Clear();
                            item.From.Items.Add(stars.ConnectionParaneters.NodeName); ;
                            item.From.SelectedIndex = 0;
                        }
                    }
                }
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

        private void Discon_Click(object sender, EventArgs e)
        {
            disconnect();
            textBox1.Text = "Stopped";
            groupBox1.Enabled = true;
            groupBox_send.Enabled = false;
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

        private void Quit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LogCopy_Click(object sender, EventArgs e)
        {
            var log = listBox_log.Items.OfType<string>().ToArray();
            Clipboard.SetText(string.Join("\r\n", log));
        }

        private void LogClr_Click(object sender, EventArgs e)
        {
            listBox_log.Items.Clear();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            var f = new InputPresetName();
            if (f.ShowDialog() == DialogResult.OK)
            {
                var data = new ConnectionPreset()
                {
                    Name = f.InputName,
                    IPaddr = textBox_ip.Text,
                    Port = (int)numericUpDown_port.Value,
                    NodeName = textBox_node.Text,
                    KeyWord = textBox_key.Text,
                    KeyPath = keyFilePath,
                    UseKeyWord = checkBox1.Checked
                };

                presetCon.Add(data);
                SaveConfig(configFilePath, presetCon);
                updateListView(presetCon, presetCon.Count - 1);
            }

            f.Dispose();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count < 1)
            {
                return;
            }

            if (MessageBox.Show($"Delete this preset [ {presetCon[comboBox1.SelectedIndex].Name} ] ?", "Check", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                presetCon.RemoveAt(comboBox1.SelectedIndex);
                SaveConfig(configFilePath, presetCon);
                updateListView(presetCon);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var target = comboBox1.SelectedIndex;
            string name = comboBox1.Text;
            
            var f = new InputPresetName(name);
            if (f.ShowDialog() == DialogResult.OK)
            {
                var data = new ConnectionPreset()
                {
                    Name = f.InputName,
                    IPaddr = textBox_ip.Text,
                    Port = (int)numericUpDown_port.Value,
                    NodeName = textBox_node.Text,
                    KeyWord = textBox_key.Text,
                    KeyPath = keyFilePath,
                    UseKeyWord = checkBox1.Checked
                };

                presetCon[target] = data;
                SaveConfig(configFilePath, presetCon);
                updateListView(presetCon, target);
            }

            f.Dispose();
        }

        void SetPreset()
        {
            stopUpdate = true;

            textBox_ip.Text = presetCon[comboBox1.SelectedIndex].IPaddr;
            numericUpDown_port.Value = presetCon[comboBox1.SelectedIndex].Port;
            textBox_node.Text = presetCon[comboBox1.SelectedIndex].NodeName;
            textBox_key.Text = presetCon[comboBox1.SelectedIndex].KeyWord;
            keyFilePath = presetCon[comboBox1.SelectedIndex].KeyPath;
            checkBox1.Checked = presetCon[comboBox1.SelectedIndex].UseKeyWord;

            stopUpdate = false;
        }

        void SendBridge(string _com)
        {
            if (stars != null)
            {
                stars.SendMessage(_com);
                Invoke(new Action<string>((str) => addLog(str)), _com);
            }
        }

        private void Free_Click(object sender, EventArgs e)
        {
            var num = ((ButtonPlus)sender).EntryNumber;
            SendBridge($"{tbGroup[num].From.SelectedItem}>{tbGroup[num].Free.Text}");
        }

        private void textBox_free_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button7.PerformClick();
            }
        }

        private void textBox_free2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button10.PerformClick();
            }
        }

        private void textBox_free3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button11.PerformClick();
            }
        }

        private void Command_Click(object sender, EventArgs e)
        {
            var num = ((ButtonPlus)sender).EntryNumber;
            if (textBox_para.Text.Replace(" ", string.Empty) == "")
            {
                SendBridge($"{tbGroup[num].From.SelectedItem}>{tbGroup[num].To.SelectedItem} {tbGroup[num].Com.SelectedItem}");
            }
            else
            {
                SendBridge($"{tbGroup[num].From.SelectedItem}>{tbGroup[num].To.SelectedItem} {tbGroup[num].Com.SelectedItem} {tbGroup[num].Param.Text}");
            }
        }

        private void textBox_para_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button8.PerformClick();
            }
        }

        private void textBox_para2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button12.PerformClick();
            }
        }

        private void textBox_para3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button13.PerformClick();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Items.Count > 0)
            {
                SetPreset();
            }
        }
    }

    public class ConnectionPreset
    {
        public string Name { set; get; } = "Local Term1";
        public string IPaddr { set; get; } = "127.0.0.1";
        public int Port { set; get; } = 6057;
        public string NodeName { set; get; } = "term1";
        public string KeyWord { set; get; } = "stars";
        public string KeyPath { set; get; } = "";
        public bool UseKeyWord { set; get; } = true;

        public ConnectionPreset() { }
    }

    public class TextBoxGroup
    {
        public TextBox? Free { set; get; } = null;
        public ComboBox? From { set; get; } = null;
        public ComboBox? To { set; get; } = null;
        public ComboBox? Com { set; get; } = null;
        public TextBox? Param { set; get; } = null;

        public TextBoxGroup() { }
    }

    public class ButtonPlus : Button
    {
        public int EntryNumber { set; get; } = 0;

        public ButtonPlus() { }
    }
}
