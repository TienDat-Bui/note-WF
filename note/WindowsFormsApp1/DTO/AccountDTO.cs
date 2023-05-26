using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public class AccountDTO
    {

        public AccountDTO (int iD,string userName, string passWord=null)
        {
            this.ID = iD;
            this.UserName = userName;
            this.PassWord = passWord;
        }
        public AccountDTO (DataRow row)
        {
            this.ID = (int)row["idUser"];
            this.UserName = row["userName"].ToString();
            this.PassWord = row["pass"].ToString();
        }
        private int iD;
        private string userName;
        private string passWord;
        public int ID
        {
            get { return iD;}
            set { iD = value; }
        }
        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
    }
}
