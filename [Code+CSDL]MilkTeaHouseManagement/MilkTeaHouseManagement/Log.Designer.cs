
namespace MilkTeaHouseManagement
{
    partial class Log
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log));
            this.txtUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.MilkTeaHouseManagemant = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.logginbt = new System.Windows.Forms.Button();
            this.exitbt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsername.HintForeColor = System.Drawing.Color.Empty;
            this.txtUsername.HintText = "";
            this.txtUsername.isPassword = false;
            this.txtUsername.LineFocusedColor = System.Drawing.Color.SteelBlue;
            this.txtUsername.LineIdleColor = System.Drawing.Color.Sienna;
            this.txtUsername.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtUsername.LineThickness = 4;
            this.txtUsername.Location = new System.Drawing.Point(161, 35);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(231, 39);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPass.HintForeColor = System.Drawing.Color.Empty;
            this.txtPass.HintText = "";
            this.txtPass.isPassword = false;
            this.txtPass.LineFocusedColor = System.Drawing.Color.SteelBlue;
            this.txtPass.LineIdleColor = System.Drawing.Color.Sienna;
            this.txtPass.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPass.LineThickness = 4;
            this.txtPass.Location = new System.Drawing.Point(161, 105);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(231, 39);
            this.txtPass.TabIndex = 2;
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // MilkTeaHouseManagemant
            // 
            this.MilkTeaHouseManagemant.AutoSize = true;
            this.MilkTeaHouseManagemant.BackColor = System.Drawing.Color.LemonChiffon;
            this.MilkTeaHouseManagemant.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MilkTeaHouseManagemant.ForeColor = System.Drawing.Color.SaddleBrown;
            this.MilkTeaHouseManagemant.Location = new System.Drawing.Point(9, 50);
            this.MilkTeaHouseManagemant.Name = "MilkTeaHouseManagemant";
            this.MilkTeaHouseManagemant.Size = new System.Drawing.Size(145, 24);
            this.MilkTeaHouseManagemant.TabIndex = 3;
            this.MilkTeaHouseManagemant.Text = "Tên người dùng";
            this.MilkTeaHouseManagemant.Click += new System.EventHandler(this.MilkTeaHouseManagemant_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LemonChiffon;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(9, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mật khẩu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // logginbt
            // 
            this.logginbt.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logginbt.ForeColor = System.Drawing.Color.SaddleBrown;
            this.logginbt.Image = ((System.Drawing.Image)(resources.GetObject("logginbt.Image")));
            this.logginbt.Location = new System.Drawing.Point(429, 46);
            this.logginbt.Name = "logginbt";
            this.logginbt.Size = new System.Drawing.Size(98, 30);
            this.logginbt.TabIndex = 5;
            this.logginbt.Text = "Đăng nhập";
            this.logginbt.UseVisualStyleBackColor = true;
            this.logginbt.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitbt
            // 
            this.exitbt.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbt.ForeColor = System.Drawing.Color.SaddleBrown;
            this.exitbt.Image = ((System.Drawing.Image)(resources.GetObject("exitbt.Image")));
            this.exitbt.Location = new System.Drawing.Point(439, 115);
            this.exitbt.Name = "exitbt";
            this.exitbt.Size = new System.Drawing.Size(80, 30);
            this.exitbt.TabIndex = 6;
            this.exitbt.Text = "Thoát";
            this.exitbt.UseVisualStyleBackColor = true;
            this.exitbt.Click += new System.EventHandler(this.button2_Click);
            // 
            // Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(573, 313);
            this.Controls.Add(this.exitbt);
            this.Controls.Add(this.logginbt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MilkTeaHouseManagemant);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Log";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log";
            this.Load += new System.EventHandler(this.Log_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUsername;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPass;
        private System.Windows.Forms.Label MilkTeaHouseManagemant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logginbt;
        private System.Windows.Forms.Button exitbt;
    }
}