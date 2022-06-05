namespace Ucak_rezervasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            listBox1.Items.Add(" Rota: " + comboBox1.Text + "-" + comboBox2.Text + " Tarih: " + dateTimePicker1.Text + " Yolcu Bilgileri ~ Ad: " + textBox1.Text + " TC : " + maskedTextBox1.Text + " Telefon : " + maskedTextBox2.Text );

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label8.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text= label8.Text;
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}