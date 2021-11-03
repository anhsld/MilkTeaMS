
namespace MilkTeaHouseManagement
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.bunifuProgressBar2 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.Product = new System.Windows.Forms.Label();
            this.TimkiemBt = new System.Windows.Forms.Button();
            this.timkiemempTB = new System.Windows.Forms.TextBox();
            this.PhoneBn = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.DGVEmployee = new System.Windows.Forms.DataGridView();
            this.Gencb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EmailBn = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddBn = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TenNVBn = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.MilkTeaHouseManagemant = new System.Windows.Forms.Label();
            this.MaNVBn = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.DeleteBt = new System.Windows.Forms.Button();
            this.ExitBt = new System.Windows.Forms.Button();
            this.AddBt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuProgressBar2
            // 
            this.bunifuProgressBar2.BackColor = System.Drawing.Color.FloralWhite;
            this.bunifuProgressBar2.BorderRadius = 5;
            this.bunifuProgressBar2.Location = new System.Drawing.Point(-2, 58);
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
            this.label1.Location = new System.Drawing.Point(1003, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Product
            // 
            this.Product.AutoSize = true;
            this.Product.BackColor = System.Drawing.Color.Sienna;
            this.Product.Font = new System.Drawing.Font("Sitka Small", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product.ForeColor = System.Drawing.Color.FloralWhite;
            this.Product.Location = new System.Drawing.Point(70, 5);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(195, 48);
            this.Product.TabIndex = 16;
            this.Product.Text = "Nhân viên";
            this.Product.Click += new System.EventHandler(this.Employee_Click);
            // 
            // TimkiemBt
            // 
            this.TimkiemBt.BackColor = System.Drawing.Color.SaddleBrown;
            this.TimkiemBt.Font = new System.Drawing.Font("Sitka Banner", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimkiemBt.ForeColor = System.Drawing.Color.Linen;
            this.TimkiemBt.Location = new System.Drawing.Point(911, 78);
            this.TimkiemBt.Name = "TimkiemBt";
            this.TimkiemBt.Size = new System.Drawing.Size(105, 38);
            this.TimkiemBt.TabIndex = 50;
            this.TimkiemBt.Text = "Tìm kiếm";
            this.TimkiemBt.UseVisualStyleBackColor = false;
            this.TimkiemBt.Click += new System.EventHandler(this.TimkiemBt_Click);
            // 
            // timkiemempTB
            // 
            this.timkiemempTB.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timkiemempTB.ForeColor = System.Drawing.Color.Sienna;
            this.timkiemempTB.Location = new System.Drawing.Point(170, 86);
            this.timkiemempTB.Name = "timkiemempTB";
            this.timkiemempTB.Size = new System.Drawing.Size(707, 26);
            this.timkiemempTB.TabIndex = 49;
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
            this.PhoneBn.Location = new System.Drawing.Point(170, 358);
            this.PhoneBn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PhoneBn.Name = "PhoneBn";
            this.PhoneBn.Size = new System.Drawing.Size(209, 39);
            this.PhoneBn.TabIndex = 48;
            this.PhoneBn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // DGVEmployee
            // 
            this.DGVEmployee.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DGVEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVEmployee.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGVEmployee.Location = new System.Drawing.Point(408, 141);
            this.DGVEmployee.Name = "DGVEmployee";
            this.DGVEmployee.Size = new System.Drawing.Size(631, 317);
            this.DGVEmployee.TabIndex = 47;
            this.DGVEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVEmployee_CellContentClick);
            this.DGVEmployee.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVEmployee_RowEnter);
            // 
            // Gencb
            // 
            this.Gencb.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gencb.FormattingEnabled = true;
            this.Gencb.Items.AddRange(new object[] {
            "Nam ",
            "Nữ"});
            this.Gencb.Location = new System.Drawing.Point(170, 244);
            this.Gencb.Name = "Gencb";
            this.Gencb.Size = new System.Drawing.Size(153, 26);
            this.Gencb.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FloralWhite;
            this.label6.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label6.Location = new System.Drawing.Point(13, 434);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 24);
            this.label6.TabIndex = 45;
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
            this.EmailBn.Location = new System.Drawing.Point(170, 418);
            this.EmailBn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EmailBn.Name = "EmailBn";
            this.EmailBn.Size = new System.Drawing.Size(209, 40);
            this.EmailBn.TabIndex = 44;
            this.EmailBn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FloralWhite;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(12, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 24);
            this.label5.TabIndex = 43;
            this.label5.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FloralWhite;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(13, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 24);
            this.label4.TabIndex = 42;
            this.label4.Text = "Địa chỉ";
            // 
            // AddBn
            // 
            this.AddBn.BackColor = System.Drawing.Color.FloralWhite;
            this.AddBn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AddBn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddBn.HintForeColor = System.Drawing.Color.Empty;
            this.AddBn.HintText = "";
            this.AddBn.isPassword = false;
            this.AddBn.LineFocusedColor = System.Drawing.Color.SteelBlue;
            this.AddBn.LineIdleColor = System.Drawing.Color.Sienna;
            this.AddBn.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.AddBn.LineThickness = 4;
            this.AddBn.Location = new System.Drawing.Point(170, 291);
            this.AddBn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddBn.Name = "AddBn";
            this.AddBn.Size = new System.Drawing.Size(209, 39);
            this.AddBn.TabIndex = 41;
            this.AddBn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FloralWhite;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(13, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 40;
            this.label3.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FloralWhite;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(13, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 24);
            this.label2.TabIndex = 39;
            this.label2.Text = "Tên nhân viên";
            // 
            // TenNVBn
            // 
            this.TenNVBn.BackColor = System.Drawing.Color.FloralWhite;
            this.TenNVBn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TenNVBn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenNVBn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TenNVBn.HintForeColor = System.Drawing.Color.Empty;
            this.TenNVBn.HintText = "";
            this.TenNVBn.isPassword = false;
            this.TenNVBn.LineFocusedColor = System.Drawing.Color.SteelBlue;
            this.TenNVBn.LineIdleColor = System.Drawing.Color.Sienna;
            this.TenNVBn.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TenNVBn.LineThickness = 4;
            this.TenNVBn.Location = new System.Drawing.Point(170, 165);
            this.TenNVBn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TenNVBn.Name = "TenNVBn";
            this.TenNVBn.Size = new System.Drawing.Size(209, 39);
            this.TenNVBn.TabIndex = 38;
            this.TenNVBn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // MilkTeaHouseManagemant
            // 
            this.MilkTeaHouseManagemant.AutoSize = true;
            this.MilkTeaHouseManagemant.BackColor = System.Drawing.Color.FloralWhite;
            this.MilkTeaHouseManagemant.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MilkTeaHouseManagemant.ForeColor = System.Drawing.Color.SaddleBrown;
            this.MilkTeaHouseManagemant.Location = new System.Drawing.Point(13, 125);
            this.MilkTeaHouseManagemant.Name = "MilkTeaHouseManagemant";
            this.MilkTeaHouseManagemant.Size = new System.Drawing.Size(125, 24);
            this.MilkTeaHouseManagemant.TabIndex = 37;
            this.MilkTeaHouseManagemant.Text = "Mã nhân viên";
            // 
            // MaNVBn
            // 
            this.MaNVBn.BackColor = System.Drawing.Color.FloralWhite;
            this.MaNVBn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MaNVBn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaNVBn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MaNVBn.HintForeColor = System.Drawing.Color.Empty;
            this.MaNVBn.HintText = "";
            this.MaNVBn.isPassword = false;
            this.MaNVBn.LineFocusedColor = System.Drawing.Color.SteelBlue;
            this.MaNVBn.LineIdleColor = System.Drawing.Color.Sienna;
            this.MaNVBn.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.MaNVBn.LineThickness = 4;
            this.MaNVBn.Location = new System.Drawing.Point(170, 110);
            this.MaNVBn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaNVBn.Name = "MaNVBn";
            this.MaNVBn.Size = new System.Drawing.Size(209, 39);
            this.MaNVBn.TabIndex = 36;
            this.MaNVBn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // DeleteBt
            // 
            this.DeleteBt.BackColor = System.Drawing.Color.SaddleBrown;
            this.DeleteBt.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBt.ForeColor = System.Drawing.Color.Linen;
            this.DeleteBt.Location = new System.Drawing.Point(956, 468);
            this.DeleteBt.Name = "DeleteBt";
            this.DeleteBt.Size = new System.Drawing.Size(69, 33);
            this.DeleteBt.TabIndex = 53;
            this.DeleteBt.Text = "Xóa";
            this.DeleteBt.UseVisualStyleBackColor = false;
            this.DeleteBt.Click += new System.EventHandler(this.DeleteBt_Click);
            // 
            // ExitBt
            // 
            this.ExitBt.BackColor = System.Drawing.Color.SaddleBrown;
            this.ExitBt.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBt.ForeColor = System.Drawing.Color.Linen;
            this.ExitBt.Location = new System.Drawing.Point(791, 468);
            this.ExitBt.Name = "ExitBt";
            this.ExitBt.Size = new System.Drawing.Size(69, 33);
            this.ExitBt.TabIndex = 52;
            this.ExitBt.Text = "Sửa";
            this.ExitBt.UseVisualStyleBackColor = false;
            this.ExitBt.Click += new System.EventHandler(this.ExitBt_Click);
            // 
            // AddBt
            // 
            this.AddBt.BackColor = System.Drawing.Color.SaddleBrown;
            this.AddBt.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBt.ForeColor = System.Drawing.Color.Linen;
            this.AddBt.Location = new System.Drawing.Point(619, 468);
            this.AddBt.Name = "AddBt";
            this.AddBt.Size = new System.Drawing.Size(69, 33);
            this.AddBt.TabIndex = 51;
            this.AddBt.Text = "Thêm";
            this.AddBt.UseVisualStyleBackColor = false;
            this.AddBt.Click += new System.EventHandler(this.AddBt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 4);
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
            this.button2.Location = new System.Drawing.Point(427, 469);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 31);
            this.button2.TabIndex = 93;
            this.button2.Text = "Trang chủ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(1051, 555);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DeleteBt);
            this.Controls.Add(this.ExitBt);
            this.Controls.Add(this.AddBt);
            this.Controls.Add(this.TimkiemBt);
            this.Controls.Add(this.timkiemempTB);
            this.Controls.Add(this.PhoneBn);
            this.Controls.Add(this.DGVEmployee);
            this.Controls.Add(this.Gencb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EmailBn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AddBn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TenNVBn);
            this.Controls.Add(this.MilkTeaHouseManagemant);
            this.Controls.Add(this.MaNVBn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Product);
            this.Controls.Add(this.bunifuProgressBar2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuProgressBar bunifuProgressBar2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Product;
        private System.Windows.Forms.Button TimkiemBt;
        private System.Windows.Forms.TextBox timkiemempTB;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PhoneBn;
        private System.Windows.Forms.DataGridView DGVEmployee;
        private System.Windows.Forms.ComboBox Gencb;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox EmailBn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox AddBn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TenNVBn;
        private System.Windows.Forms.Label MilkTeaHouseManagemant;
        private Bunifu.Framework.UI.BunifuMaterialTextbox MaNVBn;
        private System.Windows.Forms.Button DeleteBt;
        private System.Windows.Forms.Button ExitBt;
        private System.Windows.Forms.Button AddBt;
        private System.Windows.Forms.Button button2;
    }
}