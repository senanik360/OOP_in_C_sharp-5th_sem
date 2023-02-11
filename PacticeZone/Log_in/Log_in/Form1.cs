using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Log_in
{
    public partial class Form1 : Form
    {
        string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
        public static string text1,text2;
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\Documents\C#\PacticeZone\Log_in\DB.mdf;Integrated Security=True;Connect Timeout=30");

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                string query = "select * from LOGIN where Phone = '"+textBox1.Text.Trim()+"' and Pass = '"+textBox2.Text.Trim()+"'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                DataTable sdtbl = new DataTable();
                sda.Fill(sdtbl);
                if (sdtbl.Rows.Count == 1)
                {
                    DashBoard dashboard = new DashBoard();
                    this.Hide();
                    dashboard.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username or password.!\n Try again please.");
                    textBox1.Clear();
                    textBox2.Clear();
                }

                /*text1 = textBox1.Text;
                text2 = textBox2.Text;
                Form f1 = new Form2();
                f1.Show();*/
            }
            else
                MessageBox.Show("Fields cannot be empty!");
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
           if (Regex.IsMatch(textBox1.Text, pattern) == false)
            {
               
                errorProvider3.SetError(this.textBox1, "Invalid Email !");
                textBox1.Focus();
            }
            else  if (string.IsNullOrEmpty(textBox1.Text) == true)
            {
                textBox1.Focus();
                errorProvider1.SetError(this.textBox1, "This section canncon be empty !");
            }
            
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text) == true)
            {
                errorProvider2.SetError(this.textBox2, "This section canncon be empty !");
                textBox1.Focus();
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '*')
            {
               // button2.BringToFront();
                textBox2.PasswordChar = '\0';
            }
           else if (textBox2.PasswordChar == '\0')
            {
               // button1.BringToFront();
                textBox2.PasswordChar = '*';
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
