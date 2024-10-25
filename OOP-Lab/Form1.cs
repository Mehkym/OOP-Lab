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
                    MessageBox.Show("����� ������� ���� �������");
                    ClearAll();
                    return;
                }
                if (gipotenyza <= 0)
                {
                    MessageBox.Show("ó�������� ������ ���� ��������");
                    ClearAll();
                    return;
                }
                if (gipotenyza <= catet1)
                {
                    MessageBox.Show("ó�������� ������ ���� ����� ������");
                    ClearAll();
                    return;
                }
                double catet2 = Math.Sqrt(gipotenyza * gipotenyza - catet1 * catet1);
                textBox3.Text = catet2.ToString();
            }
            catch
            {
                MessageBox.Show("��� ������ �� ��������");
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
