﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkTeaHouseManagement
{
    public partial class Loading : Form
    {
        
        public Loading()
        {
            InitializeComponent();
        }

        private void Trangchu_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void gunaCirclePictureBox1_Click(object sender, EventArgs e)
        {

        }
        int startpoint;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            Myprogress.Value = startpoint;
            if (Myprogress.Value == 100)
            {
                Myprogress.Value = 0;
                timer1.Stop();
                this.Hide();
                Log log = new Log();
                log.Show();
        }   }

        private void Myprogress_Click(object sender, EventArgs e)
        {

        }
    }
}
