﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test001
{
    public partial class home_page : Form
    {
        public home_page(string user_name)
        {
            InitializeComponent();
            lb_user_name.Text = user_name;
        }

        private void Home_page_Load(object sender, EventArgs e)
        {
        }

        private void Btn_signout_Click(object sender, EventArgs e)
        {
            this.Close();
            login lg = new login();
            lg.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 lg1 = new Form1();
            lg1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 lg2 = new Form2();
            lg2.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 lg3 = new Form3();
            lg3.Show();

        }
    }
}
