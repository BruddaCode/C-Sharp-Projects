namespace calculator
{
    public partial class Form1 : Form
    {
        methFunc methFunc;
        public Form1()
        {
            InitializeComponent();
            methFunc = new methFunc();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tbRes.Text = methFunc.add(tbG1.Text, tbG2.Text);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            tbRes.Text = methFunc.minus(tbG1.Text, tbG2.Text);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            tbRes.Text = methFunc.multiply(tbG1.Text, tbG2.Text);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            tbRes.Text = methFunc.divide(tbG1.Text, tbG2.Text);
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            tbRes.Text = methFunc.power(tbG1.Text, tbG2.Text);
        }

        private void btnRoot_Click(object sender, EventArgs e)
        {
            tbRes.Text = methFunc.root(tbG1.Text, tbG2.Text);
        }
    }
}