﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello world !");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello everyone !");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Very Good !");
            MessageBox.Show("Add something");
            MessageBox.Show("Add something else");
            MessageBox.Show("Add something new");
            MessageBox.Show("Add ...");
        }
    }
}
