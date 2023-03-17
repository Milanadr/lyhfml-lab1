namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                MessageBox.Show("Вибрано функцію: синус");
            else if (radioButton2.Checked)
                MessageBox.Show("Вибрано функцію: косинус");
            else if (radioButton1.Checked)
                MessageBox.Show("Вибрано функцію: експонента");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Отримання вихідних даних із TextBox
            double x = Convert.ToDouble(textBox2.Text);
            double y = Convert.ToDouble(textBox1.Text);
            double z = Convert.ToDouble(textBox3.Text);
            // Введення вихідних даних у вікно результатів
            textBox4.Text = "Результати роботи програми" + " Дмитренка І.І." + Environment.NewLine;
            textBox4.Text += "При X = " + textBox2.Text + Environment.NewLine;
            textBox4.Text += "При Y = " + textBox1.Text + Environment.NewLine;
            textBox4.Text += "При Z = " + textBox3.Text + Environment.NewLine;
            // Обчислення виразу
            double u;
            if ((z ? x) == 0)

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}