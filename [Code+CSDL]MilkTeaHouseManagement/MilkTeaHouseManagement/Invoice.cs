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
    public partial class Invoice : Form
    {
        MilkTeaHouseDataContext mt = new MilkTeaHouseDataContext();
        public Invoice()
        {
            InitializeComponent();
        }
        public void Load_hoadon()
        {

            var listhoadon = from p3 in mt.HoaDons
                             select new
                             {
                                 p3.Invoice_ID,
                                  
                                   p3.DateCreated,
                                   p3.Customer_ID,
                                   p3.Employee_ID,
                                   p3.Product_ID,
                                   p3.Quantity,
                                   p3.Total,
                                  
                               };
           DGVhoadon.DataSource = listhoadon.ToList();
            
        }
        #region
        //public void Load_cthoadon()
        //{

        //    var listcthoadon = from p3 in mt.ChiTietHoaDons
        //                       select new
        //                       { 
        //                           p3.Invoice_ID,
        //                           p3.Product_ID,
        //                         p3.ProductName,
        //                         p3.Quantity,
        //                         p3.Price,



        //                     };

        //   DGVsp.DataSource = listcthoadon.ToList();
        //}
        #endregion
        public void Load_Product()
        {

            var listproduct = from p3 in mt.SanPhams
                              select new
                              {
                                  p3.Product_ID,
                                  p3.ProductName,
                                  p3.Cost
                              };
           DGVsp.DataSource = listproduct.ToList();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timkiemcusTB_TextChanged(object sender, EventArgs e)
        {
           
            }

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            
            HoaDon hd = (from HoaDon in mt.HoaDons // Thêm sp vapf hóa đơn. Thay đổi tổng
                         where HoaDon.Invoice_ID == MaHD.Text
                         select HoaDon).Single<HoaDon>();
            hd.Invoice_ID = MaHD.Text;

            hd.DateCreated = Convert.ToDateTime(NgayTao.Text);
            hd.Customer_ID = MaKH.Text;
            hd.Employee_ID = MaNv.Text;
            hd.Product_ID = Convert.ToDouble(MaCTSP.Text);
            hd.Quantity = Convert.ToInt16(SL.Text);
            hd.Total = Convert.ToDouble(TienBn.Text); //ct.Price * ct.Quantity;
            mt.SubmitChanges();
            MessageBox.Show("Bạn đã sửa hóa đơn thành công!", "Thông báo");
        }

        private void Add_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();
         
            hd.Invoice_ID = MaHD.Text;
           
            hd.DateCreated = Convert.ToDateTime(NgayTao.Text);
            hd.Customer_ID = MaKH.Text;
            hd.Employee_ID = MaNv.Text;
            hd.Product_ID = Convert.ToDouble(MaCTSP.Text);
            hd.Quantity = Convert.ToInt16(SL.Text);
            hd.Total= Convert.ToDouble(TienBn.Text);
            mt.HoaDons.InsertOnSubmit(hd);
            mt.SubmitChanges();

            MessageBox.Show("Bạn đã thêm hóa đơn thành công!", "Thông báo");

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn muốn xóa hóa đơn ?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {


                HoaDon hd = (from HoaDon in mt.HoaDons
                             where HoaDon.Invoice_ID == MaHD.Text
                             select HoaDon).Single<HoaDon>();
                mt.HoaDons.DeleteOnSubmit(hd);
                mt.SubmitChanges();
                MessageBox.Show("Đã xóa hóa đơn thành công!", "Thông báo");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var listproduct = (from p3 in mt.SanPhams
                               where (p3.Product_ID.ToString().Contains(TimkiemSP.Text) || p3.ProductName.Contains(TimkiemSP.Text)
                                || p3.Cost.ToString().Contains(TimkiemSP.Text))
                               select new
                               {
                                   p3.Product_ID,
                                   p3.ProductName,
                                   p3.Cost

                               });
            DGVsp.DataSource = listproduct.ToList();
        }


        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void NgayTao_ValueChanged(object sender, EventArgs e)
        {

        }
        

        private void timkiembt_click(object sender, EventArgs e)
        {
          
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            Load_hoadon();

            Load_Product();

        }

        private void DGVhoadon_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            MaHD.Text = DGVhoadon.Rows[e.RowIndex].Cells[0].Value.ToString();
          
           NgayTao.Text = DGVhoadon.Rows[e.RowIndex].Cells[1].Value.ToString();
           MaKH.Text = DGVhoadon.Rows[e.RowIndex].Cells[2].Value.ToString();
            MaNv.Text = DGVhoadon.Rows[e.RowIndex].Cells[3].Value.ToString();
            MaCTSP.Text= DGVhoadon.Rows[e.RowIndex].Cells[4].Value.ToString();
           SL.Text = DGVhoadon.Rows[e.RowIndex].Cells[5].Value.ToString();
           TienBn.Text = DGVhoadon.Rows[e.RowIndex].Cells[6].Value.ToString();


        }
        #region
        //private void DGVcthd_RowEnter(object sender, DataGridViewCellEventArgs e)
        //{
        //    MaCTHD.Text = DGVcthd.Rows[e.RowIndex].Cells[0].Value.ToString();
        //    MaCTSP.Text = DGVcthd.Rows[e.RowIndex].Cells[2].Value.ToString();
        //    SL.Text = DGVcthd.Rows[e.RowIndex].Cells[4].Value.ToString();

        //}
        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void MilkTeaHouseManagemant_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void SL_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            hp.Show();
            this.Hide();
        }

        private void TimkiemSP_TextChanged(object sender, EventArgs e)
        {

        }

        private void DGVsp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
