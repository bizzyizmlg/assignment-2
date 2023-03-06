namespace Assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Converting weight textboxes into integers or numbers
            int currentWeight = Convert.ToInt32(textBox1.Text);
            int desiredWeight = Convert.ToInt32(textBox2.Text);

            // Subtracting the two weights
            int weightGoal = currentWeight - desiredWeight;

            // Show the results
            MessageBox.Show("You need to lose " + weightGoal.ToString() + " to reach your goal!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}