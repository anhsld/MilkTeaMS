
namespace MilkTeaHouseManagement
{
    partial class Invoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoice));
            this.bunifuProgressBar2 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.Cusomer = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.TimkiemBt = new System.Windows.Forms.Button();
            this.TimkiemHD = new System.Windows.Forms.TextBox();
            this.DGVhoadon = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.MilkTeaHouseManagemant = new System.Windows.Forms.Label();
            this.bunifuProgressBar1 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.DGVsp = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.TimkiemSP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MaHD = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.MaNv = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.MaKH = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.NgayTao = new System.Windows.Forms.DateTimePicker();
            this.MaCTSP = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SL = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TienBn = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Tt = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVhoadon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVsp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuProgressBar2
            // 
            this.bunifuProgressBar2.BackColor = System.Drawing.Color.FloralWhite;
            this.bunifuProgressBar2.BorderRadius = 5;
            this.bunifuProgressBar2.Location = new System.Drawing.Point(-2, 60);
            this.bunifuProgressBar2.MaximumValue = 100;
            this.bunifuProgressBar2.Name = "bunifuProgressBar2";
            this.bunifuProgressBar2.ProgressColor = System.Drawing.Color.Teal;
            this.bunifuProgressBar2.Size = new System.Drawing.Size(1055, 468);
            this.bunifuProgressBar2.TabIndex = 14;
            this.bunifuProgressBar2.Value = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Sienna;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("SimSun-ExtB", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FloralWhite;
            this.label1.Location = new System.Drawing.Point(1156, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 31);
            this.label1.TabIndex = 20;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Cusomer
            // 
            this.Cusomer.AutoSize = true;
            this.Cusomer.BackColor = System.Drawing.Color.Sienna;
            this.Cusomer.Font = new System.Drawing.Font("Sitka Small", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cusomer.ForeColor = System.Drawing.Color.FloralWhite;
            this.Cusomer.Location = new System.Drawing.Point(72, 4);
            this.Cusomer.Name = "Cusomer";
            this.Cusomer.Size = new System.Drawing.Size(333, 48);
            this.Cusomer.TabIndex = 19;
            this.Cusomer.Text = "Hóa đơn bán hàng";
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Chocolate;
            this.Delete.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.Color.Linen;
            this.Delete.Location = new System.Drawing.Point(119, 557);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(54, 31);
            this.Delete.TabIndex = 57;
            this.Delete.Text = "Xóa";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Chocolate;
            this.Exit.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.Linen;
            this.Exit.Location = new System.Drawing.Point(218, 557);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(52, 31);
            this.Exit.TabIndex = 56;
            this.Exit.Text = "Sửa";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.Chocolate;
            this.Add.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.Linen;
            this.Add.Location = new System.Drawing.Point(16, 557);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(59, 31);
            this.Add.TabIndex = 55;
            this.Add.Text = "Thêm";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // TimkiemBt
            // 
            this.TimkiemBt.BackColor = System.Drawing.Color.SaddleBrown;
            this.TimkiemBt.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimkiemBt.ForeColor = System.Drawing.Color.Linen;
            this.TimkiemBt.Location = new System.Drawing.Point(1138, 322);
            this.TimkiemBt.Name = "TimkiemBt";
            this.TimkiemBt.Size = new System.Drawing.Size(49, 31);
            this.TimkiemBt.TabIndex = 54;
            this.TimkiemBt.Text = "Tìm";
            this.TimkiemBt.UseVisualStyleBackColor = false;
            this.TimkiemBt.Click += new System.EventHandler(this.timkiemcusTB_TextChanged);
            // 
            // TimkiemHD
            // 
            this.TimkiemHD.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimkiemHD.ForeColor = System.Drawing.Color.Sienna;
            this.TimkiemHD.Location = new System.Drawing.Point(390, 323);
            this.TimkiemHD.Name = "TimkiemHD";
            this.TimkiemHD.Size = new System.Drawing.Size(742, 26);
            this.TimkiemHD.TabIndex = 53;
            this.TimkiemHD.TextChanged += new System.EventHandler(this.timkiemcusTB_TextChanged);
            // 
            // DGVhoadon
            // 
            this.DGVhoadon.BackgroundColor = System.Drawing.Color.Ivory;
            this.DGVhoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVhoadon.Location = new System.Drawing.Point(390, 363);
            this.DGVhoadon.Name = "DGVhoadon";
            this.DGVhoadon.Size = new System.Drawing.Size(797, 275);
            this.DGVhoadon.TabIndex = 51;
            this.DGVhoadon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.DGVhoadon.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVhoadon_RowEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FloralWhite;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(14, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 44;
            this.label3.Text = "Ngày tạo";
            // 
            // MilkTeaHouseManagemant
            // 
            this.MilkTeaHouseManagemant.AutoSize = true;
            this.MilkTeaHouseManagemant.BackColor = System.Drawing.Color.FloralWhite;
            this.MilkTeaHouseManagemant.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MilkTeaHouseManagemant.ForeColor = System.Drawing.Color.SaddleBrown;
            this.MilkTeaHouseManagemant.Location = new System.Drawing.Point(9, 77);
            this.MilkTeaHouseManagemant.Name = "MilkTeaHouseManagemant";
            this.MilkTeaHouseManagemant.Size = new System.Drawing.Size(111, 24);
            this.MilkTeaHouseManagemant.TabIndex = 41;
            this.MilkTeaHouseManagemant.Text = "Mã hóa đơn";
            this.MilkTeaHouseManagemant.Click += new System.EventHandler(this.MilkTeaHouseManagemant_Click);
            // 
            // bunifuProgressBar1
            // 
            this.bunifuProgressBar1.BackColor = System.Drawing.Color.FloralWhite;
            this.bunifuProgressBar1.BorderRadius = 5;
            this.bunifuProgressBar1.Location = new System.Drawing.Point(-2, 55);
            this.bunifuProgressBar1.MaximumValue = 100;
            this.bunifuProgressBar1.Name = "bunifuProgressBar1";
            this.bunifuProgressBar1.ProgressColor = System.Drawing.Color.Teal;
            this.bunifuProgressBar1.Size = new System.Drawing.Size(1204, 594);
            this.bunifuProgressBar1.TabIndex = 39;
            this.bunifuProgressBar1.Value = 0;
            // 
            // DGVsp
            // 
            this.DGVsp.BackgroundColor = System.Drawing.Color.Ivory;
            this.DGVsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVsp.Location = new System.Drawing.Point(390, 112);
            this.DGVsp.Name = "DGVsp";
            this.DGVsp.Size = new System.Drawing.Size(596, 188);
            this.DGVsp.TabIndex = 61;
            this.DGVsp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVsp_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SaddleBrown;
            this.button1.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Linen;
            this.button1.Location = new System.Drawing.Point(937, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 30);
            this.button1.TabIndex = 63;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TimkiemSP
            // 
            this.TimkiemSP.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimkiemSP.ForeColor = System.Drawing.Color.Sienna;
            this.TimkiemSP.Location = new System.Drawing.Point(390, 80);
            this.TimkiemSP.Name = "TimkiemSP";
            this.TimkiemSP.Size = new System.Drawing.Size(527, 26);
            this.TimkiemSP.TabIndex = 62;
            this.TimkiemSP.TextChanged += new System.EventHandler(this.TimkiemSP_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FloralWhite;
            this.label8.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label8.Location = new System.Drawing.Point(10, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 24);
            this.label8.TabIndex = 65;
            this.label8.Text = "Mã sản phẩm";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FloralWhite;
            this.label9.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label9.Location = new System.Drawing.Point(12, 432);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 24);
            this.label9.TabIndex = 66;
            this.label9.Text = "Số lượng";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FloralWhite;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(9, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 24);
            this.label4.TabIndex = 71;
            this.label4.Text = "Mã nhân viên";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FloralWhite;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(9, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 24);
            this.label5.TabIndex = 70;
            this.label5.Text = "Mã khách hàng";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // MaHD
            // 
            this.MaHD.BackColor = System.Drawing.Color.FloralWhite;
            this.MaHD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MaHD.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaHD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MaHD.HintForeColor = System.Drawing.Color.Empty;
            this.MaHD.HintText = "";
            this.MaHD.isPassword = false;
            this.MaHD.LineFocusedColor = System.Drawing.Color.SteelBlue;
            this.MaHD.LineIdleColor = System.Drawing.Color.Sienna;
            this.MaHD.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.MaHD.LineThickness = 4;
            this.MaHD.Location = new System.Drawing.Point(167, 64);
            this.MaHD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaHD.Name = "MaHD";
            this.MaHD.Size = new System.Drawing.Size(149, 39);
            this.MaHD.TabIndex = 80;
            this.MaHD.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // MaNv
            // 
            this.MaNv.BackColor = System.Drawing.Color.FloralWhite;
            this.MaNv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MaNv.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaNv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MaNv.HintForeColor = System.Drawing.Color.Empty;
            this.MaNv.HintText = "";
            this.MaNv.isPassword = false;
            this.MaNv.LineFocusedColor = System.Drawing.Color.SteelBlue;
            this.MaNv.LineIdleColor = System.Drawing.Color.Sienna;
            this.MaNv.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.MaNv.LineThickness = 4;
            this.MaNv.Location = new System.Drawing.Point(167, 283);
            this.MaNv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaNv.Name = "MaNv";
            this.MaNv.Size = new System.Drawing.Size(149, 39);
            this.MaNv.TabIndex = 82;
            this.MaNv.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // MaKH
            // 
            this.MaKH.BackColor = System.Drawing.Color.FloralWhite;
            this.MaKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MaKH.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MaKH.HintForeColor = System.Drawing.Color.Empty;
            this.MaKH.HintText = "";
            this.MaKH.isPassword = false;
            this.MaKH.LineFocusedColor = System.Drawing.Color.SteelBlue;
            this.MaKH.LineIdleColor = System.Drawing.Color.Sienna;
            this.MaKH.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.MaKH.LineThickness = 4;
            this.MaKH.Location = new System.Drawing.Point(167, 219);
            this.MaKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaKH.Name = "MaKH";
            this.MaKH.Size = new System.Drawing.Size(149, 39);
            this.MaKH.TabIndex = 83;
            this.MaKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MaKH.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox3_OnValueChanged);
            // 
            // NgayTao
            // 
            this.NgayTao.Location = new System.Drawing.Point(154, 153);
            this.NgayTao.Name = "NgayTao";
            this.NgayTao.Size = new System.Drawing.Size(200, 20);
            this.NgayTao.TabIndex = 85;
            this.NgayTao.ValueChanged += new System.EventHandler(this.NgayTao_ValueChanged);
            // 
            // MaCTSP
            // 
            this.MaCTSP.BackColor = System.Drawing.Color.FloralWhite;
            this.MaCTSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MaCTSP.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaCTSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MaCTSP.HintForeColor = System.Drawing.Color.Empty;
            this.MaCTSP.HintText = "";
            this.MaCTSP.isPassword = false;
            this.MaCTSP.LineFocusedColor = System.Drawing.Color.SteelBlue;
            this.MaCTSP.LineIdleColor = System.Drawing.Color.Sienna;
            this.MaCTSP.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.MaCTSP.LineThickness = 4;
            this.MaCTSP.Location = new System.Drawing.Point(167, 348);
            this.MaCTSP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaCTSP.Name = "MaCTSP";
            this.MaCTSP.Size = new System.Drawing.Size(149, 39);
            this.MaCTSP.TabIndex = 87;
            this.MaCTSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // SL
            // 
            this.SL.BackColor = System.Drawing.Color.FloralWhite;
            this.SL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SL.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SL.HintForeColor = System.Drawing.Color.Empty;
            this.SL.HintText = "";
            this.SL.isPassword = false;
            this.SL.LineFocusedColor = System.Drawing.Color.SteelBlue;
            this.SL.LineIdleColor = System.Drawing.Color.Sienna;
            this.SL.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.SL.LineThickness = 4;
            this.SL.Location = new System.Drawing.Point(167, 417);
            this.SL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SL.Name = "SL";
            this.SL.Size = new System.Drawing.Size(149, 39);
            this.SL.TabIndex = 88;
            this.SL.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SL.OnValueChanged += new System.EventHandler(this.SL_OnValueChanged);
            // 
            // TienBn
            // 
            this.TienBn.BackColor = System.Drawing.Color.FloralWhite;
            this.TienBn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TienBn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TienBn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TienBn.HintForeColor = System.Drawing.Color.Empty;
            this.TienBn.HintText = "";
            this.TienBn.isPassword = false;
            this.TienBn.LineFocusedColor = System.Drawing.Color.SteelBlue;
            this.TienBn.LineIdleColor = System.Drawing.Color.Sienna;
            this.TienBn.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TienBn.LineThickness = 4;
            this.TienBn.Location = new System.Drawing.Point(167, 489);
            this.TienBn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TienBn.Name = "TienBn";
            this.TienBn.Size = new System.Drawing.Size(149, 39);
            this.TienBn.TabIndex = 90;
            this.TienBn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Tt
            // 
            this.Tt.AutoSize = true;
            this.Tt.BackColor = System.Drawing.Color.FloralWhite;
            this.Tt.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tt.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Tt.Location = new System.Drawing.Point(12, 504);
            this.Tt.Name = "Tt";
            this.Tt.Size = new System.Drawing.Size(102, 24);
            this.Tt.TabIndex = 89;
            this.Tt.Text = "Thành tiền";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Sienna;
            this.button2.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Linen;
            this.button2.Location = new System.Drawing.Point(99, 607);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 31);
            this.button2.TabIndex = 91;
            this.button2.Text = "Trang chủ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(1201, 674);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TienBn);
            this.Controls.Add(this.Tt);
            this.Controls.Add(this.SL);
            this.Controls.Add(this.MaCTSP);
            this.Controls.Add(this.NgayTao);
            this.Controls.Add(this.MaKH);
            this.Controls.Add(this.MaNv);
            this.Controls.Add(this.MaHD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TimkiemSP);
            this.Controls.Add(this.DGVsp);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.TimkiemBt);
            this.Controls.Add(this.TimkiemHD);
            this.Controls.Add(this.DGVhoadon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MilkTeaHouseManagemant);
            this.Controls.Add(this.bunifuProgressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cusomer);
            this.Controls.Add(this.bunifuProgressBar2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.Invoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVhoadon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVsp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuProgressBar bunifuProgressBar2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Cusomer;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button TimkiemBt;
        private System.Windows.Forms.TextBox TimkiemHD;
        private System.Windows.Forms.DataGridView DGVhoadon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label MilkTeaHouseManagemant;
        private Bunifu.Framework.UI.BunifuProgressBar bunifuProgressBar1;
        private System.Windows.Forms.DataGridView DGVsp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TimkiemSP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox MaHD;
        private Bunifu.Framework.UI.BunifuMaterialTextbox MaNv;
        private Bunifu.Framework.UI.BunifuMaterialTextbox MaKH;
        private System.Windows.Forms.DateTimePicker NgayTao;
        private Bunifu.Framework.UI.BunifuMaterialTextbox MaCTSP;
        private Bunifu.Framework.UI.BunifuMaterialTextbox SL;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TienBn;
        private System.Windows.Forms.Label Tt;
        private System.Windows.Forms.Button button2;
    }
}