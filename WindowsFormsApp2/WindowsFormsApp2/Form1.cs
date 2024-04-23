using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        String firstname, lastname,phonenumber;
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            firstname = textBox1.Text;
            lastname = textBox2.Text;
            phonenumber =textBox3.Text;
            firstname = firstname.Trim();
            lastname = lastname.Trim();
            phonenumber=phonenumber.Trim();
            if (string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(lastname) || string.IsNullOrEmpty(phonenumber)

                )
                MessageBox.Show("complete boxes");
            else
            {
                string d = firstname + "," + lastname + "," + phonenumber + "\n";
                string f = "test.csv";
                File.AppendAllText(f, d);
                MessageBox.Show("information saved succesfully");
            }

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
        }
    }

