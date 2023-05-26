namespace WindowsFormsApp1
{
    partial class fLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.flogin_tb_userName = new System.Windows.Forms.TextBox();
            this.flogin_lb_userName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flogin_tb_password = new System.Windows.Forms.TextBox();
            this.flogin_lb_password = new System.Windows.Forms.Label();
            this.flogin_btn_login = new System.Windows.Forms.Button();
            this.flogin_btn_exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flogin_tb_userName);
            this.panel1.Controls.Add(this.flogin_lb_userName);
            this.panel1.Location = new System.Drawing.Point(42, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 54);
            this.panel1.TabIndex = 0;
            // 
            // flogin_tb_userName
            // 
            this.flogin_tb_userName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flogin_tb_userName.Location = new System.Drawing.Point(142, 13);
            this.flogin_tb_userName.Name = "flogin_tb_userName";
            this.flogin_tb_userName.Size = new System.Drawing.Size(234, 30);
            this.flogin_tb_userName.TabIndex = 1;
            // 
            // flogin_lb_userName
            // 
            this.flogin_lb_userName.AutoSize = true;
            this.flogin_lb_userName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flogin_lb_userName.Location = new System.Drawing.Point(3, 18);
            this.flogin_lb_userName.Name = "flogin_lb_userName";
            this.flogin_lb_userName.Size = new System.Drawing.Size(133, 22);
            this.flogin_lb_userName.TabIndex = 0;
            this.flogin_lb_userName.Text = "Tên Đăng Nhập";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flogin_tb_password);
            this.panel2.Controls.Add(this.flogin_lb_password);
            this.panel2.Location = new System.Drawing.Point(42, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 55);
            this.panel2.TabIndex = 1;
            // 
            // flogin_tb_password
            // 
            this.flogin_tb_password.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flogin_tb_password.Location = new System.Drawing.Point(142, 13);
            this.flogin_tb_password.Name = "flogin_tb_password";
            this.flogin_tb_password.Size = new System.Drawing.Size(234, 30);
            this.flogin_tb_password.TabIndex = 1;
            // 
            // flogin_lb_password
            // 
            this.flogin_lb_password.AutoSize = true;
            this.flogin_lb_password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flogin_lb_password.Location = new System.Drawing.Point(3, 18);
            this.flogin_lb_password.Name = "flogin_lb_password";
            this.flogin_lb_password.Size = new System.Drawing.Size(87, 22);
            this.flogin_lb_password.TabIndex = 0;
            this.flogin_lb_password.Text = "Mật Khẩu";
            // 
            // flogin_btn_login
            // 
            this.flogin_btn_login.BackColor = System.Drawing.Color.Blue;
            this.flogin_btn_login.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flogin_btn_login.ForeColor = System.Drawing.SystemColors.Control;
            this.flogin_btn_login.Location = new System.Drawing.Point(184, 150);
            this.flogin_btn_login.Name = "flogin_btn_login";
            this.flogin_btn_login.Size = new System.Drawing.Size(105, 37);
            this.flogin_btn_login.TabIndex = 2;
            this.flogin_btn_login.Text = "Đăng nhập";
            this.flogin_btn_login.UseVisualStyleBackColor = false;
            this.flogin_btn_login.Click += new System.EventHandler(this.flogin_btn_login_Click);
            // 
            // flogin_btn_exit
            // 
            this.flogin_btn_exit.BackColor = System.Drawing.Color.Blue;
            this.flogin_btn_exit.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flogin_btn_exit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.flogin_btn_exit.Location = new System.Drawing.Point(298, 150);
            this.flogin_btn_exit.Name = "flogin_btn_exit";
            this.flogin_btn_exit.Size = new System.Drawing.Size(105, 37);
            this.flogin_btn_exit.TabIndex = 3;
            this.flogin_btn_exit.Text = "Thoát";
            this.flogin_btn_exit.UseVisualStyleBackColor = false;
            this.flogin_btn_exit.Click += new System.EventHandler(this.flogin_btn_exit_Click);
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(454, 206);
            this.Controls.Add(this.flogin_btn_exit);
            this.Controls.Add(this.flogin_btn_login);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fLogin_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox flogin_tb_userName;
        private System.Windows.Forms.Label flogin_lb_userName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox flogin_tb_password;
        private System.Windows.Forms.Label flogin_lb_password;
        private System.Windows.Forms.Button flogin_btn_login;
        private System.Windows.Forms.Button flogin_btn_exit;
    }
}