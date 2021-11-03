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
    public partial class Employee : Form
    {
        MilkTeaHouseDataContext mt = new MilkTeaHouseDataContext();
        public Employee()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void ExitBt_Click(object sender, EventArgs e)
        {

            NhanVien nv = (from NhanVien in mt.NhanViens
                            where NhanVien.Employee_ID == MaNVBn.Text
                            select NhanVien).SingleOrDefault<NhanVien>();
            nv.Employee_ID= MaNVBn.Text;
            nv.Name = TenNVBn.Text;
            nv.Gender = Gencb.Text;
            nv.Address =AddBn.Text;
            nv.Phone = PhoneBn.Text;
            nv.Email = EmailBn.Text;
            mt.SubmitChanges();
            MessageBox.Show("Bạn đã sửa nhân viên thành công!", "Thông báo");

        }

        private void AddBt_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
           nv.Employee_ID = MaNVBn.Text;
            nv.Name = TenNVBn.Text;
           nv.Gender = Gencb.Text;
            nv.Address = AddBn.Text;
            nv.Phone = PhoneBn.Text;
            nv.Email = EmailBn.Text;
            mt.NhanViens.InsertOnSubmit(nv);
            mt.SubmitChanges();

            MessageBox.Show("Bạn đã thêm nhân viên thành công!", "Thông báo");
        }

        private void DeleteBt_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn muốn xóa nhân viên ?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                // MilkTeaHouseDataContext data = new MilkTeaHouseDataContext();
                NhanVien nv = (from NhanVien in mt.NhanViens
                               where NhanVien.Employee_ID == MaNVBn.Text
                               select NhanVien).Single<NhanVien>();
                mt.NhanViens.DeleteOnSubmit(nv);
                mt.SubmitChanges();
                MessageBox.Show("Đã xóa nhân viên thành công!", "Thông báo");
            }
        }

        private void TimkiemBt_Click(object sender, EventArgs e)
        {
            var listemployee = (from p3 in mt.NhanViens
                               where (p3.Employee_ID.ToString().Contains(timkiemempTB.Text) || p3.Name.Contains(timkiemempTB.Text)
                                || p3.Gender.ToString().Contains(timkiemempTB.Text)) || p3.Address.ToString().Contains(timkiemempTB.Text) || p3.Phone.ToString().Contains(timkiemempTB.Text) || p3.Email.ToString().Contains(timkiemempTB.Text)
                               select new
                               {
                                   p3.Employee_ID,
                                   p3.Name,
                                   p3.Gender,
                                   p3.Address,
                                   p3.Phone,
                                   p3.Email
                               });
            DGVEmployee.DataSource = listemployee.ToList();
        }

        private void DGVEmployee_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            MaNVBn.Text = DGVEmployee.Rows[e.RowIndex].Cells[0].Value.ToString();
            TenNVBn.Text = DGVEmployee.Rows[e.RowIndex].Cells[1].Value.ToString();
            Gencb.Text = DGVEmployee.Rows[e.RowIndex].Cells[2].Value.ToString();
            AddBn.Text = DGVEmployee.Rows[e.RowIndex].Cells[3].Value.ToString();
            PhoneBn.Text = DGVEmployee.Rows[e.RowIndex].Cells[4].Value.ToString();
            EmailBn.Text = DGVEmployee.Rows[e.RowIndex].Cells[5].Value.ToString();

        }

        private void Employee_Click(object sender, EventArgs e)
        {

        }
        public void Load_Employee()
        {

            var listemployy = from p3 in mt.NhanViens

                              select new
                              {
                                  p3.Employee_ID,
                                  p3.Name,
                                  p3.Gender,
                                  p3.Address,
                                  p3.Phone,
                                  p3.Email
                              };
            //DGVEmployee.DataSource = listemployy.ToList();
            //DGVEmployee.Columns[0].HeaderText = " Mã nhân viên";
            //DGVEmployee.Columns[1].HeaderText = "Tên nhân viên";
            //DGVEmployee.Columns[3].HeaderText = "Giới tính";
            //DGVEmployee.Columns[4].HeaderText = "Địa chỉ";
            //DGVEmployee.Columns[5].HeaderText = "Số điện thoại";
            //DGVEmployee.Columns[6].HeaderText = "Email";
            DGVEmployee.DataSource = listemployy;

        }

        private void DGVEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = DGVEmployee.Rows[e.RowIndex];
           MaNVBn.Text = dr.Cells[0].Value.ToString();
            TenNVBn.Text = dr.Cells[1].Value.ToString();
          Gencb.Text = dr.Cells[2].Value.ToString();
            AddBn.Text = dr.Cells[3].Value.ToString();
           PhoneBn.Text = dr.Cells[4].Value.ToString();
            EmailBn.Text = dr.Cells[5].Value.ToString();

        }

        private void Employee_Load(object sender, EventArgs e)
        {
            Load_Employee();
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            hp.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            hp.Show();
            this.Hide();
        }
    }
}
