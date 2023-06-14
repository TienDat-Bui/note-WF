using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.DTO;
using Microsoft.Office.Interop;
using Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp1
{
    public partial class fNote : Form
    {   /// <summary>
    //  khởi tạo constructor loginAccount để lưu dữ liệu truyền từ form login
    /// </summary>
        private AccountDTO loginAccount;
        BindingSource ListNote = new BindingSource();
        private int idUser;
        public AccountDTO LoginAccount { get => loginAccount; set => loginAccount = value; }
        public fNote(AccountDTO acc)
        {
        
            this.idUser = acc.ID;
            InitializeComponent();
            loadValue(idUser);
            AddNoteBinding();
            timer1.Start();//đồng hồ
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        // bắt sự kiện nhấn nút thêm mới
        private void btn_add_Click(object sender, EventArgs e)
        {

            string _title = txb_Title.Text;
            string _message = txb_Message.Text;
            AddNote(_title, _message,idUser);
            loadValue(idUser);
        }
        // bắt sự kiện ấn nút cập nhật
        private void btn_Update_Click(object sender, EventArgs e)
        {
            string title = txb_Title.Text;
            string message = txb_Message.Text;
            int idNote =(int)dgv_Note.SelectedCells[0].OwningRow.Cells["Id"].Value;
            UpdateNote(idNote,title,message);
            loadValue(idUser);
        }
        // sự kiện ấn nút xóa
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {// lấy id dựa trên selectedCells datagridview
                int idNote = (int)dgv_Note.SelectedCells[0].OwningRow.Cells["Id"].Value;
                DeleteNote(idNote);
                loadValue(idUser);
            }
        }
        //sự kiện timer - đồng hồ
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            fnote_lb_time.Text = now.ToString();
        }
        //sự kiện xuất dữ liệu ra excel
        private void fnote_btn_export_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

               ExportToExcel(dgv_Note, saveFileDialog1.FileName);
            }
        }

        // hàm load dữ liệu vào datagridview
        void loadValue(int idUser)
        {
            dgv_Note.DataSource = ListNote;
            string query = "EXEC dbo.USP_SelectbyID @Id";
            Dataprovider provider = new Dataprovider();
            ListNote.DataSource =  provider.ExcuteQuery(query,new object[]{ idUser });

        }
        //hàm binding dữ liệu từ datagridview sang textbox
        void AddNoteBinding()
        {
            txb_Title.DataBindings.Add("text", dgv_Note.DataSource, "Tiêu đề",true,DataSourceUpdateMode.Never);
            txb_Message.DataBindings.Add("text", dgv_Note.DataSource, "Nội dung", true, DataSourceUpdateMode.Never);
        }
        //hàm thêm mới
        void AddNote(string title, string message,int id)
        {
            string query = "EXEC dbo.USP_InsertNote @title , @mess , @idUser";
            Dataprovider provider = new Dataprovider();
            provider.ExcuteNoneQuery(query, new object[] { title, message, id });
        }
        // hàm cập nhật
        void UpdateNote(int idNote, string title, string message)
        {
            string query = " EXEC dbo.USP_UpdateNote @idNote , @title , @note ";
            Dataprovider provider = new Dataprovider();
            provider.ExcuteNoneQuery(query, new object[] { idNote, title, message });
        }
        //hàm delete note
        void DeleteNote (int idNote)
        {
            string query = "DELETE dbo.Content WHERE idNote =" + idNote;
            Dataprovider provider = new Dataprovider();
            provider.ExcuteNoneQuery(query);
        }
        //hàm xuất ra file excel
        void ExportToExcel(DataGridView dgv, string fileName)
        {
            try
            {
               // khởi tạo đối tượng excel
                var excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;
                //khởi tạo workbook
                var wb = excel.Workbooks.Add();
                var ws = wb.Sheets["Sheet1"];//chọn sheets 1 trong workbook excel
                // đặt tên cho worksheet
                ws.Name = "Note";
                //đếm số dòng, số cột trong dgv
                int countColumns = dgv.Columns.Count;
                int countRows = dgv.RowCount;
                //tạo tilte
                Range title = ws.Range["A1:c1"];
                title.MergeCells = true;
                title.Value = "Bảng Ghi Chú";
                title.Font.Size = 22;
                title.RowHeight = 30;
                title.ColumnWidth = 15;
                title.Font.Bold = true;
                title.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                //tạo header
                Range rowdHeading = ws.Range["A3:C3"];
                rowdHeading.Font.Bold = true;
                rowdHeading.Font.Size = 12;
                rowdHeading.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                //boder
                int rowdata = countRows + 2;
                Range data = ws.Range[$"A3:C{rowdata}"];
                data.Borders.LineStyle = XlLineStyle.xlContinuous;
                // ghi dòng đầu tiên- header vào file excel
                for (int i = 0; i < countColumns; i++)
                {
                    ws.Cells[3, i + 1] = dgv.Columns[i].HeaderText;
                }
                //dùng for duyệt qua từng ô trong dgv lưu vào excel
                for (int i = 0; i < countRows - 1; i++)
                {
                    for (int j = 0; j < countColumns; j++)
                    {
                        ws.Cells[i + 4, j + 1] = dgv.Rows[i].Cells[j].Value.ToString();
                    }
                }
                //lưu file bằng phương thức SaveAs() với filename
                wb.SaveAs(fileName);
                wb.Close();
                excel.Quit();
                MessageBox.Show("Xuất dữ liệu thành công");
                wb = null;
                ws = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xuất dữ liệu không thành công");
            };

        }


    }
}
