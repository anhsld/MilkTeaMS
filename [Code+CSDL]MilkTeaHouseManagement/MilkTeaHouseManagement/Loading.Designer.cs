
namespace MilkTeaHouseManagement
{
    partial class Loading
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading));
            this.Myprogress = new Guna.UI.WinForms.GunaCircleProgressBar();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.MilkTeaHouseManagemant = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Myprogress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Myprogress
            // 
            this.Myprogress.AnimationSpeed = 0.6F;
            this.Myprogress.BackColor = System.Drawing.Color.FloralWhite;
            this.Myprogress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Myprogress.BackgroundImage")));
            this.Myprogress.BaseColor = System.Drawing.Color.FloralWhite;
            this.Myprogress.Controls.Add(this.gunaCirclePictureBox1);
            this.Myprogress.IdleColor = System.Drawing.Color.Gainsboro;
            this.Myprogress.IdleOffset = 20;
            this.Myprogress.IdleThickness = 10;
            this.Myprogress.Image = null;
            this.Myprogress.ImageSize = new System.Drawing.Size(52, 52);
            this.Myprogress.Location = new System.Drawing.Point(167, 53);
            this.Myprogress.Name = "Myprogress";
            this.Myprogress.ProgressMaxColor = System.Drawing.Color.Sienna;
            this.Myprogress.ProgressMinColor = System.Drawing.Color.Sienna;
            this.Myprogress.ProgressOffset = 20;
            this.Myprogress.ProgressThickness = 10;
            this.Myprogress.Size = new System.Drawing.Size(172, 163);
            this.Myprogress.TabIndex = 0;
            this.Myprogress.Click += new System.EventHandler(this.Myprogress_Click);
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("gunaCirclePictureBox1.ErrorImage")));
            this.gunaCirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaCirclePictureBox1.Image")));
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(40, 40);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(91, 83);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaCirclePictureBox1.TabIndex = 0;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            this.gunaCirclePictureBox1.Click += new System.EventHandler(this.gunaCirclePictureBox1_Click);
            // 
            // MilkTeaHouseManagemant
            // 
            this.MilkTeaHouseManagemant.AutoSize = true;
            this.MilkTeaHouseManagemant.BackColor = System.Drawing.Color.FloralWhite;
            this.MilkTeaHouseManagemant.Font = new System.Drawing.Font("SimSun-ExtB", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MilkTeaHouseManagemant.ForeColor = System.Drawing.Color.Sienna;
            this.MilkTeaHouseManagemant.Location = new System.Drawing.Point(30, 21);
            this.MilkTeaHouseManagemant.Name = "MilkTeaHouseManagemant";
            this.MilkTeaHouseManagemant.Size = new System.Drawing.Size(461, 29);
            this.MilkTeaHouseManagemant.TabIndex = 1;
            this.MilkTeaHouseManagemant.Text = "The MilkTea House Management";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FloralWhite;
            this.label1.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(297, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "279 Nguyễn Tri Phương";
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(523, 251);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MilkTeaHouseManagemant);
            this.Controls.Add(this.Myprogress);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Trangchu_Load);
            this.Myprogress.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaCircleProgressBar Myprogress;
        private System.Windows.Forms.Label MilkTeaHouseManagemant;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}

