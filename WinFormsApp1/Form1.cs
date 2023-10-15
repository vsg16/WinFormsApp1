using System.Data;
using Class_shifrs;

namespace WinFormsApp1
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Polib my = new Polib();
            string my_polib = my.coding_eng(textBox1.Text.ToUpper());
            textBox2.Text = my_polib;

            my_polib = my.decoding_eng(textBox1.Text.ToUpper());
            textBox4.Text = my_polib;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OSB my_osb = new OSB();
            textBox3.Text = (my_osb.coding_eng(textBox1.Text.ToUpper())).ToString();
            string my_osb_new = my_osb.decoding_eng(textBox3.Text);
            textBox5.Text = my_osb_new;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
