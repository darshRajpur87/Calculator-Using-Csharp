namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddNumber_Click(object sender, EventArgs e)
        {
            int Number1 = int.Parse(textBox1.Text);
            int Number2 = int.Parse(textBox2.Text);
            int Additon = Number1 + Number2;
            AnswerTextbox.Text = Additon.ToString();
            AnswerTextbox.Visible = true;
            label4.Visible = true;
            label4.Text = "Addition Result";

        }

        private void SubtractNumber_Click(object sender, EventArgs e)
        {
            int Number1 = int.Parse(textBox1.Text);
            int Number2 = int.Parse(textBox2.Text);
            int Subtraction = Number1 - Number2;
            AnswerTextbox.Text = Subtraction.ToString();
            AnswerTextbox.Visible = true;
            label4.Visible = true;
            label4.Text = "Subtraction Result";
        }

        private void MultiplyNumber_Click(object sender, EventArgs e)
        {
            int Number1 = int.Parse(textBox1.Text);
            int Number2 = int.Parse(textBox2.Text);
            int Multiplication = Number1 * Number2;
            AnswerTextbox.Text = Multiplication.ToString();
            AnswerTextbox.Visible = true;
            label4.Visible = true;
            label4.Text = "Multiplication Result";

        }

        private void DivideNumber_Click(object sender, EventArgs e)
        {
            float Number1 = int.Parse(textBox1.Text);
            float Number2 = int.Parse(textBox2.Text);
            float Division = Number1 / Number2;
            AnswerTextbox.Text = Division.ToString();
            AnswerTextbox.Visible = true;
            label4.Visible = true;
            label4.Text = "Division Result";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
