
namespace MilkTeaHouseManagement
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.bunifuProgressBar2 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.Cusomer = new System.Windows.Forms.Label();
            this.MilkTeaHouseManagemant = new System.Windows.Forms.Label();
            this.MaKh = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.TenKH = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddKH = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuMaterialTextbox3 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.EmailBn = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Gencb = new System.Windows.Forms.ComboBox();
            this.DGVCustomer = new System.Windows.Forms.DataGridView();
            this.PhoneBn = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.timkiemcusTB = new System.Windows.Forms.TextBox();
            this.TimkiemBt = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuProgressBar2
            // 
            this.bunifuProgressBar2.BackColor = System.Drawing.Color.FloralWhite;
            this.bunifuProgressBar2.BorderRadius = 5;
            this.bunifuProgressBar2.Location = new System.Drawing.Point(0, 63);
            this.bunifuProgressBar2.MaximumValue = 100;
            this.bunifuProgressBar2.Name = "bunifuProgressBar2";
            this.bunifuProgressBar2.ProgressColor = System.Drawing.Color.Teal;
            this.bunifuProgressBar2.Size = new System.Drawing.Size(1055, 468);
            this.bunifuProgressBar2.TabIndex = 13;
            this.bunifuProgressBar2.Value = 0;
            this.bunifuProgressBar2.progressChanged += new System.EventHandler(this.bunifuProgressBar2_progressChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Sienna;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("SimSun-ExtB", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FloralWhite;
            this.label1.Location = new System.Drawing.Point(1008, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Cusomer
            // 
            this.Cusomer.AutoSize = true;
            this.Cusomer.BackColor = System.Drawing.Color.Sienna;
            this.Cusomer.Font = new System.Drawing.Font("Sitka Small", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cusomer.ForeColor = System.Drawing.Color.FloralWhite;
            this.Cusomer.Location = new System.Drawing.Point(73, 2);
            this.Cusomer.Name = "Cusomer";
            this.Cusomer.Size = new System.Drawing.Size(220, 48);
            this.Cusomer.TabIndex = 16;
            this.Cusomer.Text = "Khách hàng";
            this.Cusomer.Click += new System.EventHandler(this.Cusomer_Click);
            // 
            // MilkTeaHouseManagemant
            // 
            this.MilkTeaHouseManagemant.AutoSize = true;
            this.MilkTeaHouseManagemant.BackColor = System.Drawing.Color.FloralWhite;
            this.MilkTeaHouseManagemant.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MilkTeaHouseManagemant.ForeColor = System.Drawing.Color.SaddleBrown;
            this.MilkTeaHouseManagemant.Location = new System.Drawing.Point(13, 144);
            this.MilkTeaHouseManagemant.Name = "MilkTeaHouseManagemant";
            this.MilkTeaHouseManagemant.Size = new System.Drawing.Size(138, 24);
            this.MilkTeaHouseManagemant.TabIndex = 20;
            this.MilkTeaHouseManagemant.Text = "Mã khách hàng";
            this.MilkTeaHouseManagemant.Click += new System.EventHandler(this.MilkTeaHouseManagemant_Click);
            // 
            // MaKh
            // 
            this.MaKh.BackColor = System.Drawing.Color.FloralWhite;
            this.MaKh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MaKh.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaKh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MaKh.HintForeColor = System.Drawing.Color.Empty;
            this.MaKh.HintText = "";
            this.MaKh.isPassword = false;
            this.MaKh.LineFocusedColor = System.Drawing.Color.SteelBlue;
            this.MaKh.LineIdleColor = System.Drawing.Color.Sienna;
            this.MaKh.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.MaKh.LineThickness = 4;
            this.MaKh.Location = new System.Drawing.Point(170, 129);
            this.MaKh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaKh.Name = "MaKh";
            this.MaKh.Size = new System.Drawing.Size(209, 39);
            this.MaKh.TabIndex = 19;
            this.MaKh.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MaKh.OnValueChanged += new System.EventHandler(this.txtUsername_OnValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FloralWhite;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(13, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tên khách hàng";
            // 
            // TenKH
            // 
            this.TenKH.BackColor = System.Drawing.Color.FloralWhite;
            this.TenKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TenKH.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TenKH.HintForeColor = System.Drawing.Color.Empty;
            this.TenKH.HintText = "";
            this.TenKH.isPassword = false;
            this.TenKH.LineFocusedColor = System.Drawing.Color.SteelBlue;
            this.TenKH.LineIdleColor = System.Drawing.Color.Sienna;
            this.TenKH.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TenKH.LineThickness = 4;
            this.TenKH.Location = new System.Drawing.Point(170, 184);
            this.TenKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TenKH.Name = "TenKH";
            this.TenKH.Size = new System.Drawing.Size(209, 39);
            this.TenKH.TabIndex = 21;
            this.TenKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FloralWhite;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(13, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FloralWhite;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(13, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "Địa chỉ";
            // 
            // AddKH
            // 
            this.AddKH.BackColor = System.Drawing.Color.FloralWhite;
            this.AddKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AddKH.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddKH.HintForeColor = System.Drawing.Color.Empty;
            this.AddKH.HintText = "";
            this.AddKH.isPassword = false;
            this.AddKH.LineFocusedColor = System.Drawing.Color.SteelBlue;
            this.AddKH.LineIdleColor = System.Drawing.Color.Sienna;
            this.AddKH.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.AddKH.LineThickness = 4;
            this.AddKH.Location = new System.Drawing.Point(170, 310);
            this.AddKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddKH.Name = "AddKH";
            this.AddKH.Size = new System.Drawing.Size(209, 39);
            this.AddKH.TabIndex = 25;
            this.AddKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FloralWhite;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(12, 396);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 24);
            this.label5.TabIndex = 28;
            this.label5.Text = "Số điện thoại";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // bunifuMaterialTextbox3
            // 
            this.bunifuMaterialTextbox3.BackColor = System.Drawing.Color.FloralWhite;
            this.bunifuMaterialTextbox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextbox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox3.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox3.HintText = "";
            this.bunifuMaterialTextbox3.isPassword = false;
            this.bunifuMaterialTextbox3.LineFocusedColor = System.Drawing.Color.SteelBlue;
            this.bunifuMaterialTextbox3.LineIdleColor = System.Drawing.Color.Sienna;
            this.bunifuMaterialTextbox3.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox3.LineThickness = 4;
            this.bunifuMaterialTextbox3.Location = new System.Drawing.Point(170, 410);
            this.bunifuMaterialTextbox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuMaterialTextbox3.Name = "bunifuMaterialTextbox3";
            this.bunifuMaterialTextbox3.Size = new System.Drawing.Size(209, 39);
            this.bunifuMaterialTextbox3.TabIndex = 27;
            this.bunifuMaterialTextbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FloralWhite;
            this.label6.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label6.Location = new System.Drawing.Point(13, 453);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 24);
            this.label6.TabIndex = 30;
            this.label6.Text = "Email";
            // 
            // EmailBn
            // 
            this.EmailBn.BackColor = System.Drawing.Color.FloralWhite;
            this.EmailBn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailBn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailBn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EmailBn.HintForeColor = System.Drawing.Color.Empty;
            this.EmailBn.HintText = "";
            this.EmailBn.isPassword = false;
            this.EmailBn.LineFocusedColor = System.Drawing.Color.SteelBlue;
            this.EmailBn.LineIdleColor = System.Drawing.Color.Sienna;
            this.EmailBn.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.EmailBn.LineThickness = 4;
            this.EmailBn.Location = new System.Drawing.Point(170, 439);
            this.EmailBn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EmailBn.Name = "EmailBn";
            this.EmailBn.Size = new System.Drawing.Size(209, 38);
            this.EmailBn.TabIndex = 29;
            this.EmailBn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Gencb
            // 
            this.Gencb.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gencb.FormattingEnabled = true;
            this.Gencb.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.Gencb.Location = new System.Drawing.Point(170, 256);
            this.Gencb.Name = "Gencb";
            this.Gencb.Size = new System.Drawing.Size(153, 26);
            this.Gencb.TabIndex = 31;
            // 
            // DGVCustomer
            // 
            this.DGVCustomer.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGVCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCustomer.GridColor = System.Drawing.Color.Black;
            this.DGVCustomer.Location = new System.Drawing.Point(408, 160);
            this.DGVCustomer.Name = "DGVCustomer";
            this.DGVCustomer.Size = new System.Drawing.Size(631, 298);
            this.DGVCustomer.TabIndex = 32;
            this.DGVCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCustomer_CellContentClick);
            this.DGVCustomer.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCustomer_RowEnter);
            // 
            // PhoneBn
            // 
            this.PhoneBn.BackColor = System.Drawing.Color.FloralWhite;
            this.PhoneBn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PhoneBn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneBn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PhoneBn.HintForeColor = System.Drawing.Color.Empty;
            this.PhoneBn.HintText = "";
            this.PhoneBn.isPassword = false;
            this.PhoneBn.LineFocusedColor = System.Drawing.Color.SteelBlue;
            this.PhoneBn.LineIdleColor = System.Drawing.Color.Sienna;
            this.PhoneBn.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.PhoneBn.LineThickness = 4;
            this.PhoneBn.Location = new System.Drawing.Point(170, 377);
            this.PhoneBn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PhoneBn.Name = "PhoneBn";
            this.PhoneBn.Size = new System.Drawing.Size(209, 39);
            this.PhoneBn.TabIndex = 33;
            this.PhoneBn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // timkiemcusTB
            // 
            this.timkiemcusTB.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timkiemcusTB.ForeColor = System.Drawing.Color.Sienna;
            this.timkiemcusTB.Location = new System.Drawing.Point(170, 90);
            this.timkiemcusTB.Name = "timkiemcusTB";
            this.timkiemcusTB.Size = new System.Drawing.Size(707, 26);
            this.timkiemcusTB.TabIndex = 34;
            // 
            // TimkiemBt
            // 
            this.TimkiemBt.BackColor = System.Drawing.Color.SaddleBrown;
            this.TimkiemBt.Font = new System.Drawing.Font("Sitka Banner", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimkiemBt.ForeColor = System.Drawing.Color.Linen;
            this.TimkiemBt.Location = new System.Drawing.Point(911, 78);
            this.TimkiemBt.Name = "TimkiemBt";
            this.TimkiemBt.Size = new System.Drawing.Size(105, 38);
            this.TimkiemBt.TabIndex = 35;
            this.TimkiemBt.Text = "Tìm kiếm";
            this.TimkiemBt.UseVisualStyleBackColor = false;
            this.TimkiemBt.Click += new System.EventHandler(this.TimkiemBt_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.SaddleBrown;
            this.Add.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.Linen;
            this.Add.Location = new System.Drawing.Point(589, 483);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(87, 29);
            this.Add.TabIndex = 36;
            this.Add.Text = "Thêm";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.SaddleBrown;
            this.Exit.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.Linen;
            this.Exit.Location = new System.Drawing.Point(771, 483);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(87, 29);
            this.Exit.TabIndex = 37;
            this.Exit.Text = "Sửa";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.SaddleBrown;
            this.Delete.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.Color.Linen;
            this.Delete.Location = new System.Drawing.Point(940, 483);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(87, 29);
            this.Delete.TabIndex = 38;
            this.Delete.Text = "Xóa";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Sienna;
            this.button2.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Linen;
            this.button2.Location = new System.Drawing.Point(408, 481);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 31);
            this.button2.TabIndex = 92;
            this.button2.Text = "Trang chủ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(1051, 555);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.TimkiemBt);
            this.Controls.Add(this.timkiemcusTB);
            this.Controls.Add(this.PhoneBn);
            this.Controls.Add(this.DGVCustomer);
            this.Controls.Add(this.Gencb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EmailBn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bunifuMaterialTextbox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AddKH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TenKH);
            this.Controls.Add(this.MilkTeaHouseManagemant);
            this.Controls.Add(this.MaKh);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cusomer);
            this.Controls.Add(this.bunifuProgressBar2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuProgressBar bunifuProgressBar2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Cusomer;
        private System.Windows.Forms.Label MilkTeaHouseManagemant;
        private Bunifu.Framework.UI.BunifuMaterialTextbox MaKh;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TenKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox AddKH;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox3;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox EmailBn;
        private System.Windows.Forms.ComboBox Gencb;
        private System.Windows.Forms.DataGridView DGVCustomer;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PhoneBn;
        private System.Windows.Forms.TextBox timkiemcusTB;
        private System.Windows.Forms.Button TimkiemBt;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button button2;
    }
}