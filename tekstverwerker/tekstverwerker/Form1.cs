namespace tekstverwerker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            String line;

            try
            {
                StreamReader sr = new StreamReader("D:\\schoolwerk mbo4\\C#\\tekstverwerker\\tekstverwerker\\text.txt");

                line = sr.ReadLine();
                while (line != null)
                {
                    rtbTekst.Text = rtbTekst.Text + line + "\n";
                    line = sr.ReadLine();
                }
            }
            catch(Exception ex)
            {
                rtbTekst.Text = ex.Message;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}