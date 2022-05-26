namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double X = 0;
        double Y = 0;
        string Operation = "";
        double Result = 0;

        private void numbers_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                richTextBox1.Text += btn.Text;
            }
        }

        private void Calculating(string opp)
        {
            Operation = opp;
            X += double.Parse(richTextBox1.Text);
            richTextBox1.Text = " ";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            Operation = "+";
            X += double.Parse(richTextBox1.Text);
            richTextBox1.Text = " ";
        }
        private void minus_Click(object sender, EventArgs e)
        {
            Operation = "-";
            X = double.Parse(richTextBox1.Text);
            richTextBox1.Text = " ";
            //Calculating("-");
        }

        private void mult_Click(object sender, EventArgs e)
        {
            Operation = "*";
            X = double.Parse(richTextBox1.Text);
            richTextBox1.Text = " ";
        }

        private void div_Click(object sender, EventArgs e)
        {
            Operation = "/";
            X = double.Parse(richTextBox1.Text);
            richTextBox1.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + ",";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "";
            X = 0;
            Y = 0;
            Result = 0;
        }

        private void equal_Click(object sender, EventArgs e)
        {
            Y = double.Parse(richTextBox1.Text);

            switch (Operation)
            {
                case "+":
                    Result = X + Y;
                    break;

                case "-":
                    Result = X - Y;
                    break;

                case "*":
                    Result = X * Y;
                    break;

                case "/":

                    if (Y == 0)
                        MessageBox.Show("Cannot divide to zero");

                    else
                        Result = X / Y;

                    break;

            }
            richTextBox1.Text = Result.ToString();
        }

    }
}