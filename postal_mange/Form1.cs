using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace postal_mange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //public string u_name, e_mail,p;
        // public int ph_no;

        public string u_name;
        public string e_mail;
        public int ph_no;

        public Form1(string un, int ph, string em)
        {
            InitializeComponent();

            u_name = "LOL";
            e_mail = "TEST";
            ph_no = 123;
            //p = "Username: " + u_name + "  E_mail :" + e_mail + "  ph_no: " + ph_no;
            /*u_name = un;
            e_mail = em;
            ph_no = ph;*/

            
        }



        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Username: " + u_name + "  E_mail :" + e_mail + "  ph_no: " + ph_no);
            Form2 s = new Form2 (u_name, e_mail, ph_no);  
            this.Hide();
            s.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form3().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form4().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int p_id = rnd.Next(1, 100000);
            try
            {
                
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=9490";

                
                //string Query = "insert into world.delivery values ('" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + p_id + "','" + u_name +"');";
                string Query = "insert into world.delivery values ('" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + p_id + "','" + "LOL" + "');";
                string Query2 = "insert into world.transport values ('" + p_id + "','" + "LOL" + "','" + this.textBox1.Text + "');";


                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                MessageBox.Show("Pay at the reception and collect paid_id");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();

               MySqlConnection MyConn3 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand3 = new MySqlCommand(Query2, MyConn3);
                MySqlDataReader MyReader3;
                MyConn3.Open();
                MyReader3 = MyCommand3.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                while (MyReader3.Read())
                {
                }
                MyConn3.Close();

           }
           catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "---> RANDOM NUMBER REPREAT   ");
            }

            //now depending on the values of pickup and drop we pur check constrain in the transport table.
        }
    }
}
