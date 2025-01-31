namespace CheckEnvironment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var stars = new STARS.StarsInterface("term", "127.0.0.1");

                var stars_tool = new STARS_BasicTools.STARS_Driver(new STARS_BasicTools.STARS_ConnectionParameter());

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!\r\n" + ex.ToString(), "Initialize Faild");
                Close();
            }

            MessageBox.Show("Environment check passed successfully.", "Initialize Passed");
            Close();
        }
    }
}
