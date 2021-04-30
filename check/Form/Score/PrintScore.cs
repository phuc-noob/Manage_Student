using Spire.Doc.Documents;
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

namespace check
{
    public partial class PrintScore : Form
    {
        public PrintScore()
        {
            InitializeComponent();
        }

        private void PrintScore_Load(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();
            SqlCommand cmd = new SqlCommand("SELECT Std.id as 'Student Id',fname,lname,Course.id,label,student_score FROM Score,Course,Std where Std.id =Score.student_id and Course.id =score.course_id", db.getConnection);
            db.OpenConnection();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            db.closeConnection();
            dataGridView_Print.AutoResizeColumnHeadersHeight();
            dataGridView_Print.DataSource = dt;
            dataGridView_Print.ReadOnly = true;
            // image size

            //dataGridView_Print.RowTemplate.MinimumHeight = 80;
            dataGridView_Print.DataSource = dt;
        }

        private void button_File_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.DefaultExt = "*.docx";
            save.Filter = "DOCX Files|*.docx";
            if (save.ShowDialog() == DialogResult.OK && dataGridView_Print.Rows.Count + 1 > 0)
            {
                Spire.Doc.Document doc = new Spire.Doc.Document();

                Spire.Doc.Documents.Paragraph paragraph1 = doc.AddSection().AddParagraph();
                Spire.Doc.Fields.TextRange text1 = paragraph1.AppendText("DANH SACH KHÓA HỌC\n");
                Spire.Doc.Fields.TextRange text2 = paragraph1.AppendText("HK II Nam 2020-2021\n");
                text1.CharacterFormat.FontName = "Times New Roman";
                text2.CharacterFormat.FontName = "Times New Roman";
                text1.CharacterFormat.FontSize = 24;
                text2.CharacterFormat.FontSize = 13;
                //paragraph1.Format.TextAlignment = TextAlignment.Center;              // văn bản canh giữa 
                paragraph1.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;  // đoạn canh giữa

                Spire.Doc.Table table = doc.Sections[0].AddTable(true);

                // Số dòng và số cột cho bảng
                table.ResetCells(dataGridView_Print.Rows.Count + 1, dataGridView_Print.Columns.Count);
                for (int i = 0; i < dataGridView_Print.Columns.Count; i++)
                {
                    doc.Sections[0].Tables[0].Rows[0].Cells[i].Width = 200;
                }

                //Đặt hàng đầu tiên là header
                Spire.Doc.TableRow Frow = table.Rows[0];
                Frow.IsHeader = true;
                Frow.Height = 23;

                for (int i = 0; i < dataGridView_Print.Columns.Count; i++)
                {
                    Spire.Doc.Documents.Paragraph p = Frow.Cells[i].AddParagraph();
                    Frow.Cells[i].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                    p.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;

                    Spire.Doc.Fields.TextRange tr = p.AppendText(dataGridView_Print.Columns[i].HeaderText);
                    tr.CharacterFormat.FontName = "Times New Roman";
                    tr.CharacterFormat.FontSize = 13;
                    tr.CharacterFormat.Bold = true;
                }

                for (int i = 0; i < dataGridView_Print.Rows.Count - 1; i++)
                {
                    Spire.Doc.TableRow DataRow = table.Rows[i + 1];
                    Spire.Doc.Documents.Paragraph paragraph;
                    for (int j = 0; j < dataGridView_Print.Columns.Count; j++)
                    {
                        DataRow.Height = 100;
                        DataRow.Cells[j].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                        paragraph = DataRow.Cells[j].AddParagraph();
                        paragraph.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
                        string textString = dataGridView_Print.Rows[i].Cells[j].Value.ToString();
                        Spire.Doc.Fields.TextRange text = paragraph.AppendText(dataGridView_Print.Rows[i].Cells[j].Value.ToString());
                        text.CharacterFormat.FontName = "Times New Roman";
                        text.CharacterFormat.FontSize = 13;
                    }
                }
                doc.SaveToFile(save.FileName);
                doc.Close();

            }
        }
    }
}
