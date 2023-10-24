namespace Factorial
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
                int fmb = int.Parse(textBox1.Text);
                if (fmb >= 0)
                {
                    int f = 1;
                    for (int i = fmb; i > 0; i--)
                    {
                        f *= i;
                    }
                    label2.Text = f.ToString();
                }
                else
                {
                    label2.Text = "Please enter a positive number";
                }
            }
            catch (Exception)
            {
                label2.Text = "Please enter a numeric value";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            textBox1.Text = "";
        }
    }
}