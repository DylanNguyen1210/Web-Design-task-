using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
       
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void OpenForm(Form Form)
        {
            Form.Owner = this;
            Form.StartPosition = FormStartPosition.Manual;
            Form.Location = this.Location;
            Form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenForm(new Form1());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenForm(new Form2());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenForm(new Form3());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenForm(new Form4());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenForm(new Form5());
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

    }
}
