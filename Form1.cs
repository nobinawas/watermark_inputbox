﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaceHoler_WatherMark
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NameTextBox_Enter(object sender, EventArgs e)
        {
            if (NameTextBox.Text == "Input User Name")
            {
                NameTextBox.Text = "";
                NameTextBox.ForeColor = Color.Black;

            }
        }

        private void NameTextBox_Leave(object sender, EventArgs e)
        {
            if (NameTextBox.Text=="")
            {
                NameTextBox.Text = "User Name";
                NameTextBox.ForeColor = Color.Black;

            }
        }
    }
}
