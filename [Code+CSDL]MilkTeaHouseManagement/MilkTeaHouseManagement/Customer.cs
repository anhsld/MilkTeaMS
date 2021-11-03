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
    public partial class Customer : Form
    {
        MilkTeaHouseDataContext mt = new MilkTeaHouseDataContext();
        public Customer()
        {
            InitializeComponent();
        }

        private void Cusomer_Click(object sender, EventArgs e)
        {

        }
        public void Load_Customer()
        {

            var listcustomer = from p3 in mt.KhachHangs
                              select new
                              {
                                  p3.Customer_ID,
                                  p3.Name,
                                  p3.Gender,
                                  p3.Address,
                                  p3.Phone,
                                  p3.Email
                              };
            DGVCustomer.DataSource = listcustomer.ToList();
            //DGVCustomer.Columns[0].HeaderText = " Mã khách hàng";
            //DGVCustomer.Columns[1].HeaderText = "Tên khách hàng";
            //DGVCustomer.Columns[3].HeaderText = "Giới tính";
            //DGVCustomer.Columns[4].HeaderText = "Địa chỉ";
            //DGVCustomer.Columns[5].HeaderText = "Số điện thoại";
            //DGVCustomer.Columns[6].HeaderText = "Email";

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuProgressBar2_progressChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void MilkTeaHouseManagemant_Click(object sender, EventArgs e)
        {

        }

        private void TimkiemBt_Click(object sender, EventArgs e)
        {
            var listproduct = (from p3 in mt.KhachHangs
                               where (p3.Customer_ID.ToString().Contains(timkiemcusTB.Text) || p3.Name.Contains(timkiemcusTB.Text)
                                || p3.Gender.ToString().Contains(timkiemcusTB.Text)) || p3.Address.ToString().Contains(timkiemcusTB.Text) || p3.Phone.ToString().Contains(timkiemcusTB.Text) || p3.Email.ToString().Contains(timkiemcusTB.Text)
                               select new
                               {
                                   p3.Customer_ID,
                                   p3.Name,
                                   p3.Gender,
                                   p3.Address,
                                   p3.Phone,
                                   p3.Email
                               });
            DGVCustomer.DataSource = listproduct.ToList();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.Customer_ID = MaKh.Text;
            kh.Name = TenKH.Text;
            kh.Gender = Gencb.Text;
            kh.Address = AddKH.Text;
            kh.Phone = PhoneBn.Text;
            kh.Email = EmailBn.Text;
            mt.KhachHangs.InsertOnSubmit(kh);
            mt.SubmitChanges();

            MessageBox.Show("Bạn đã thêm khách hàng thành công!", "Thông báo");
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            KhachHang kh = (from KhachHang in mt.KhachHangs
                          where KhachHang.Customer_ID == MaKh.Text
                          select KhachHang).Single<KhachHang>();
            kh.Customer_ID = MaKh.Text;
            kh.Name = TenKH.Text;
            kh.Gender = Gencb.Text;
            kh.Address = AddKH.Text;
            kh.Phone = PhoneBn.Text;
            kh.Email = EmailBn.Text;
            mt.SubmitChanges();
            MessageBox.Show("Bạn đã sửa khách hàng thành công!", "Thông báo");
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn muốn xóa khách hàng ?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {

                KhachHang kh = (from KhachHang in mt.KhachHangs
                                where KhachHang.Customer_ID == MaKh.Text
                                select KhachHang).Single<KhachHang>();
                mt.KhachHangs.DeleteOnSubmit(kh);
                mt.SubmitChanges();
                MessageBox.Show("Đã xóa khách hàng thành công!", "Thông báo");
            }

        }

        private void DGVCustomer_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
           MaKh.Text = DGVCustomer.Rows[e.RowIndex].Cells[0].Value.ToString();
           TenKH.Text = DGVCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
           Gencb.Text = DGVCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
            AddKH.Text = DGVCustomer.Rows[e.RowIndex].Cells[3].Value.ToString();
            PhoneBn.Text = DGVCustomer.Rows[e.RowIndex].Cells[4].Value.ToString();
            EmailBn.Text = DGVCustomer.Rows[e.RowIndex].Cells[5].Value.ToString();

        }

        private void DGVCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            Load_Customer();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            hp.Show();
            this.Hide();
        }
    }
    }

