namespace OOP_Lab
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
                double catet1 = double.Parse(textBox1.Text);
                double gipotenyza = double.Parse(textBox2.Text);
                if (catet1 <= 0) 
                {
                    MessageBox.Show("Катет повинен бути додатнім");
                    ClearAll();
                    return;
                }
                if (gipotenyza <= 0)
                {
                    MessageBox.Show("Гіпотенуза повина бути додатння");
                    ClearAll();
                    return;
                }
                if (gipotenyza <= catet1)
                {
                    MessageBox.Show("Гіпотенуза повина бути більша катета");
                    ClearAll();
                    return;
                }
                double catet2 = Math.Sqrt(gipotenyza * gipotenyza - catet1 * catet1);
                textBox3.Text = catet2.ToString();
            }
            catch
            {
                MessageBox.Show("Дані введені не коректно");
                ClearAll();
            }
        }
        void ClearAll() 
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
