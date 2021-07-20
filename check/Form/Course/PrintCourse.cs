using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing.Printing;
using Spire.Doc;
using Spire.Pdf;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using System.Security.Policy;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


//using Spire.Doc.Documents;
//using Spire.Doc.Fields;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Data.SqlClient;
//using System.Drawing;
//using System.Drawing.Printing;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Documents;
//using System.Windows.Forms;

namespace check
{
    public partial class PrintCourse : Form
    {
        public PrintCourse()
        {
            InitializeComponent();
        }
        Course course = new Course();

        private void PrintCourse_Load(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Course", db.getConnection);
            db.OpenConnection();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            db.closeConnection();
            dataGridView_Course.AutoResizeColumnHeadersHeight();



            dataGridView_Course.DataSource = dt;
            dataGridView_Course.ReadOnly = true;
            dataGridView_Course.AutoResizeRows();
            dataGridView_Course.Columns[4].Width = 70;

            dataGridView_Course.Columns[0].Width = 65;
            dataGridView_Course.Columns[2].Width = 65;
            dataGridView_Course.Columns[0].HeaderText = "ID";
            dataGridView_Course.Columns[1].HeaderText = "Label";
            dataGridView_Course.Columns[2].HeaderText = "Period";
            dataGridView_Course.Columns[3].HeaderText = "Desription";
            dataGridView_Course.Columns[4].HeaderText = "Semester";
            dataGridView_Course.Columns[5].HeaderText = "ID Teacher";
            dataGridView_Course.Columns[6].HeaderText = "Name Teacher";

        }

        private void bt_print_Click(object sender, EventArgs e)
        {
            PrintDialog pdialog = new PrintDialog();
            PrintDocument pDoc = new PrintDocument();

            pDoc.DocumentName = "Print Document";           // file name
            pdialog.Document = pDoc;
            pdialog.AllowSelection = true;                  // option of select selection
            pdialog.AllowSomePages = true;                  // option of select multi pages

            if (pdialog.ShowDialog() == DialogResult.OK)
                pDoc.Print();
        }

        private void button_SaveWord_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.DefaultExt = "*.docx";
            save.Filter = "DOCX Files|*.docx";
            if (save.ShowDialog() == DialogResult.OK && dataGridView_Course.Rows.Count + 1 > 0)
            {
                Spire.Doc.Document doc = new Spire.Doc.Document();

                Spire.Doc.Documents.Paragraph paragraph1 = doc.AddSection().AddParagraph();
                TextRange text0 = paragraph1.AppendText("TRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ THUẬT TP.HỒ CHÍ MINH\n\n");
                Spire.Doc.Fields.TextRange text1 = paragraph1.AppendText("\t\t\t\t\tDANH SACH KHÓA HỌC\n");
                Spire.Doc.Fields.TextRange text2 = paragraph1.AppendText("\t\t\t\t\t         Kỳ II Nam 2020-2021\n");
                text0.CharacterFormat.FontName = "Times New Roman";
                text1.CharacterFormat.FontName = "Times New Roman";
                text2.CharacterFormat.FontName = "Times New Roman";

                text0.CharacterFormat.FontSize = 10;
                text1.CharacterFormat.FontSize = 15;
                text2.CharacterFormat.FontSize = 13;
                //paragraph1.Format.TextAlignment = TextAlignment.Center;              // văn bản canh giữa 
                paragraph1.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Left;  // đoạn canh giữa

                Spire.Doc.Table table = doc.Sections[0].AddTable(true);

                // Số dòng và số cột cho bảng
                table.ResetCells(dataGridView_Course.Rows.Count + 1, dataGridView_Course.Columns.Count);
                for (int i = 0; i < dataGridView_Course.Columns.Count; i++)
                {
                    doc.Sections[0].Tables[0].Rows[0].Cells[i].Width = 200;
                }

                //Đặt hàng đầu tiên là header
                Spire.Doc.TableRow Frow = table.Rows[0];
                Frow.IsHeader = true;
                Frow.Height = 23;

                for (int i = 0; i < dataGridView_Course.Columns.Count; i++)
                {
                    Spire.Doc.Documents.Paragraph p = Frow.Cells[i].AddParagraph();
                    Frow.Cells[i].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                    p.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;

                    Spire.Doc.Fields.TextRange tr = p.AppendText(dataGridView_Course.Columns[i].HeaderText);
                    tr.CharacterFormat.FontName = "Times New Roman";
                    tr.CharacterFormat.FontSize = 10;
                    tr.CharacterFormat.Bold = true;
                }

                for (int i = 0; i < dataGridView_Course.Rows.Count-1; i++)
                {
                    Spire.Doc.TableRow DataRow = table.Rows[i + 1];
                    Spire.Doc.Documents.Paragraph paragraph;
                    for (int j = 0; j < dataGridView_Course.Columns.Count  ; j++)
                    {
                        DataRow.Height = 30;
                        DataRow.Cells[j].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                        paragraph = DataRow.Cells[j].AddParagraph();
                        paragraph.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
                        string textString = dataGridView_Course.Rows[i].Cells[j].Value.ToString();
                        Spire.Doc.Fields.TextRange text = paragraph.AppendText(dataGridView_Course.Rows[i].Cells[j].Value.ToString());
                        text.CharacterFormat.FontName = "Times New Roman";
                        text.CharacterFormat.FontSize = 10;
                    }
                }
                doc.SaveToFile(save.FileName);
                doc.Close();
            }
        }
    }
       
}
