using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace postal_mange
{
    public partial class Form2 : Form
    {
        private string e_mail;
        private int ph_no;
        private string u_name;

        public Form2()
        {
            InitializeComponent();
        }
        public String unm, ema;
        public int phno;
        public Form2(string u_name, string e_mail, int ph_no)
        {
           /* unm = "LOL";
            ema = "TEST";
            phno = 123;*/
            unm = u_name;
            ema = e_mail;
            phno = ph_no;

            //textBox1.Text = unm;
            // textBox2.Text = ema;
            // textBox3.Text = phno.ToString();
            label5.Text = unm.ToString();
            label6.Text = ema.ToString();
            label7.Text = phno.ToString();

            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().ShowDialog();
        }
    }
}
