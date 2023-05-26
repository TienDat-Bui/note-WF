using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAO
{
    public class AccountDAO
    {
        public bool Login(string userName, string passWord)
        {
            Dataprovider provider = new Dataprovider();
            DataTable result = provider.ExcuteQuery("EXEC dbo.USP_Login @userName , @pass", new object[] { userName, passWord });
            return result.Rows.Count > 0;
        }
       public AccountDTO GetAccountByUser(string userName)
        {
            Dataprovider provider = new Dataprovider();
            DataTable dt = provider.ExcuteQuery("SELECT * FROM dbo.Account WHERE userName = '" + userName + "'");
            foreach (DataRow item in dt.Rows)
            {
                return new AccountDTO(item);
            }
            return null;
        }
        }
    }

