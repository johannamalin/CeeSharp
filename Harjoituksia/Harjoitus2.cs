﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjoitus2
{
    public partial class Harjoitus2 : Form
    {
        public Harjoitus2()
        {
            InitializeComponent();
        }

        private void Harjoitus2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TulostaBT_Click(object sender, EventArgs e)
        {
            string teksti = ViestiTB.Text;
            TulostusLB.Text = teksti;
            TulostusLB.Visible = true;
        }
    }
}
