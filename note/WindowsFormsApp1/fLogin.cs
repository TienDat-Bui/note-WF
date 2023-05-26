using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }
        // sự kiện đăng nhập
        private void flogin_btn_login_Click(object sender, EventArgs e)
        {
            string userName = flogin_tb_userName.Text;
            string passWord = flogin_tb_password.Text;
            if (userName != "" && passWord != "")
                {
                    if (Login(userName, passWord))
                        {       // gửi dữ liệu sang form note thông qua khởi tạo fnote
                            AccountDAO provider = new AccountDAO();
                            AccountDTO loginAccount = provider.GetAccountByUser(userName);
                            fNote fNote = new fNote(loginAccount);
                            this.Hide();
                            fNote.ShowDialog();
                            this.Show();
                        }
                      else
                        {
                            MessageBox.Show("Tài khoản không đúng");
                        }
                }
            else
                {
                    MessageBox.Show("Vui lòng nhập tài khoản");
                }
        }

        private void flogin_btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
           if(MessageBox.Show("Bạn có muốn thoát khỏi chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
                {
                e.Cancel = true;
                }
        }

        //gọi hàm login
        bool Login (string userName, string passWord)
        { AccountDAO acc = new AccountDAO();
            return acc.Login(userName, passWord);
        }

    }
}
