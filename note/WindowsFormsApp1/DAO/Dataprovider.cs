using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAO
{
    class Dataprovider
    {
       private string connectString = @"Data Source=LAPTOP-U3NKBQ13\DAT;Initial Catalog=Note;Persist Security Info=True;User ID=sa; Password =123456";

        // lấy dữ liệu từ database trả về tất cả dữ liệu
        public DataTable ExcuteQuery(string query, object[] parameter=null)//
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectString))// sau khi kết thúc khối lệnh tự giải phóng đối tượng
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                // thêm nhiều parameter
                if(parameter!= null)
                {
                    string[] listParam = query.Split(' ');
                    int i = 0;
                    foreach (var item in listParam)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                return dt;
            }
        }
        // lấy dữ liệu ở database trả về số dòng bị ảnh hưởng
        public int ExcuteNoneQuery(string query, object[] parameter = null)//
        {
            int dt = 0;
            using (SqlConnection con = new SqlConnection(connectString))// sau khi kết thúc khối lệnh tự giải phóng đối tượng
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                // thêm nhiều parameter
                if (parameter != null)
                {
                    string[] listParam = query.Split(' ');
                    int i = 0;
                    foreach (var item in listParam)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                
                dt = cmd.ExecuteNonQuery();
                con.Close();
                return dt;
            }
        }
     
    }
}


