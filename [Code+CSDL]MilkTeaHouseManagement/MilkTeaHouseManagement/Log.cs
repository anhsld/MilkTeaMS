using System;
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
    public partial class Log : Form
    {
        MilkTeaHouseDataContext mt = new MilkTeaHouseDataContext();

        public Log()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MilkTeaHouseManagemant_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn muốn thoát ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool i = false;
            foreach (var login in mt.DangNhaps)
            {
                  if (txtUsername.Text == login.Username && txtPass.Text == login.Password)
               // if (txtUsername.Text == " admin " && txtPass.Text == "admin123")
                {
                    i = true;
                   HomePage si = new HomePage();
                
                   
                    si.ShowDialog();
                    this.Show();
                    this.Hide();

                }
            }
            if (i == false)
            {
                txtUsername.Hide();
                txtPass.Hide();
                MessageBox.Show("Login fail!", "Fail");
                
            }
        }

        private void Log_Load(object sender, EventArgs e)
        {

        }

        private void Log_Load_1(object sender, EventArgs e)
        {

        }
    }
}
