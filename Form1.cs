using System;
using System.Windows.Forms;

namespace ProvaDNI
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

        private void button1_Click(object sender, EventArgs e)
        {
            int dni = Convert.ToInt32(textBox1.Text);

            char letter = functionDNI(dni);

            textBox2.Text = "" + letter;


        }
        private char functionDNI(int dni)
        {
            char letter = 'A';

            return letter;
        }
    }
}
