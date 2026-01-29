namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label3.Text = $"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()}";
            timer1.Start();
        }
        //1 EUR = 1.95583 BGN
        double course = 1.95583;
        double amount;
        double result;
        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out amount))
            {
                if (radioButton1.Checked)
                {
                    if (amount >= 10000)
                    {
                        MessageBox.Show($"Трябва да декларирате произхода на  парите,които искате да обмените в БНБ: {amount:F2} Лева в {(amount / course):F2} евро", "Предупреждение");
                    }
                    result = amount / course;
                    label2.Text = $"{amount:F2} BGN = {result:F2} EUR";
                }
                else if (radioButton2.Checked)
                {
                    result = amount * course;
                    label2.Text = $"{amount:F2} EUR = {result:F2} BGN";
                }
                else
                {
                    MessageBox.Show("Моля изберете опция");
                }
            }
            else
            {
                MessageBox.Show("Невалиден вход.Моля опитайте отново!", "Предупреждение");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            if (radioButton1.Checked)
            {
                label2.Text = "0.00 BGN = 0.00 EUR";
            }
            else if (radioButton2.Checked)
            {
                label2.Text = "0.00 EUR = 0.00 BGN";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = $"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Clipboard.SetText(label2.Text);
            if (radioButton1.Checked)
            {
                Clipboard.SetText($"{amount:F2} BGN / {result:F2} EUR");
            }
            else if (radioButton2.Checked)
            {
                Clipboard.SetText($"{amount:F2} EUR / {result:F2} BGN");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Clipboard.GetText();
            textBox1.Paste();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double n1;
            double n2;
            double result;
            if (double.TryParse(textBox2.Text, out n1) && double.TryParse(textBox3.Text, out n2))
            {
                result = n1 + n2;
                label6.Text = $"Резултат: {result:F5}";
            }
            else
            {
                MessageBox.Show("Невалидни данни за вход!Моля опитайте отново.");
                textBox2.Text = "";
                textBox3.Text = "";
                label6.Text = "Резултат:";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double n1;
            double n2;
            double result;
            if (double.TryParse(textBox2.Text, out n1) && double.TryParse(textBox3.Text, out n2))
            {
                result = n1 - n2;
                label6.Text = $"Резултат: {result:F5}";
            }
            else
            {
                MessageBox.Show("Невалидни данни за вход!Моля опитайте отново.");
                textBox2.Text = "";
                textBox3.Text = "";
                label6.Text = "Резултат:";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double n1;
            double n2;
            double result;
            if (double.TryParse(textBox2.Text, out n1) && double.TryParse(textBox3.Text, out n2))
            {
                result = n1 * n2;
                label6.Text = $"Резултат: {result:F5}";
            }
            else
            {
                MessageBox.Show("Невалидни данни за вход!Моля опитайте отново.");
                textBox2.Text = "";
                textBox3.Text = "";
                label6.Text = "Резултат:";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double n1;
            double n2;
            double result;
            if (double.TryParse(textBox2.Text, out n1) && double.TryParse(textBox3.Text, out n2))
            {
                if (n2 == 0)
                {
                    MessageBox.Show("Делението на 0 НЕ е възможно");
                    textBox2.Text = "";
                    textBox3.Text = "";
                    label6.Text = "Резултат:";
                }
                else
                {
                    result = n1 / n2;
                    label6.Text = $"Резултат: {result:F5}";
                }
            }
            else
            {
                MessageBox.Show("Невалидни данни за вход!Моля опитайте отново.");
                textBox2.Text = "";
                textBox3.Text = "";
                label6.Text = "Резултат:";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
            label6.Text = "Резултат:";
        }
    }
}
