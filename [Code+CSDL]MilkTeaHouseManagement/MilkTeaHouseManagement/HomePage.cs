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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProductBt_Click(object sender, EventArgs e)
        {
            Products prd = new Products();
            prd.Show();
            this.Hide();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void CustomerBt_Click(object sender, EventArgs e)
        {
            Customer ctm = new Customer();
            ctm.Show();
            this.Hide();
        }

        private void SInvoiceBt_Click(object sender, EventArgs e)
        {
            Invoice ivk = new Invoice();
            ivk.Show();
            this.Hide();
        }

        private void EmployeeBt_Click(object sender, EventArgs e)
        {
            Employee epl = new Employee();
            epl.Show();
            this.Hide();
        }

        private void ProductBt_Click_1(object sender, EventArgs e)
        {
            Products prd = new Products();
            prd.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Payment pm = new Payment();
            pm.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Log lg = new Log();
            lg.Show();
            this.Hide();
        }
    }
}
