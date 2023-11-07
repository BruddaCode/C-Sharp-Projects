namespace Herriepot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            int freq = 37;
            while (freq < 20000)
            {
                Console.Beep(freq, 50);
                rtbText1.Text = rtbText1.Text + freq.ToString() + "\t";
                freq += 100;
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case 'a':
                    Console.Beep(500, 200);
                    break;
            }
        }
    }
}