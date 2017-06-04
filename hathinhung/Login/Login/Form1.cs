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
using Login.Model;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyContext db = new MyContext();
            var res = db.LOGINs.SingleOrDefault(x => x.USERNAME == textBox1.Text && x.PASSWORD == textBox2.Text);
            if (res == null)
            {
                MessageBox.Show("Invalid user name or password!");
            }
            else
            {
                this.Hide();
                new MENU().Show();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
