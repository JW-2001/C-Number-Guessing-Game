namespace Guess_number
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

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private Boolean rndint(int number)
		{
			Random rnd = new Random();
			int number2 = rnd.Next(1, 10);
			lbl1.Text = "The number was " + number2.ToString();
			if (number == number2) { return true; }
			else { return false; }
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (rndint(int.Parse(textBox1.Text)))
			{
				checkBox1.Checked = true;
			}
			else
			{
				checkBox1.Checked = false;
			}
		}
	}
}