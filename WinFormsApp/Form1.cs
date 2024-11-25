namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] movies = { "Titan", "Beautiful" };
        decimal[] prices = { 28.99M, 23.99M };
        decimal[] discounts = { 19.99M, 15.99M };
        decimal total = 0M;
        decimal result = 0M;
        private void Form1_Load(object sender, EventArgs e)
        {
            label7.Text = $"${prices[0]}";
            label8.Text = $"${discounts[0]}";

            label12.Text = $"${prices[1]}";
            label11.Text = $"${discounts[1]}";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            if (numericUpDown1.Value > 0)
            {
                result = discounts[0] * numericUpDown1.Value;
                total = total + result;
                form2.listBox1.Items.Add($"Name: {movies[0]} | Price: ${prices[0]} | Discount: ${discounts[0]} | Number: {numericUpDown1.Value} | Result: ${result}");
            }
            if (numericUpDown3.Value > 0)
            {
                result = discounts[1] * numericUpDown1.Value;
                total = total + result;
                form2.listBox1.Items.Add($"Name: {movies[1]} | Price: ${prices[1]} | Discount: ${discounts[1]} | Number: {numericUpDown1.Value} | Result: ${result}");

            }
            form2.label11.Text = $"Total: ${total}";
            form2.Show();
        }
    }
}
