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

namespace check
{
    public partial class Print : Form
    {
        public Print()
        {
            InitializeComponent();
        }
        MY_DB db = new MY_DB();
        Student std = new Student();
        public void fillGrid(SqlCommand cmd)
        {
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();

            //dataGridView_Print.RowTemplate.MinimumHeight = 500;
            dataGridView_Print.DataSource = std.getStudent(cmd);
            picCol = (DataGridViewImageColumn)dataGridView_Print.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView_Print.AllowUserToAddRows = false;
            dataGridView_Print.Columns[3].DefaultCellStyle.Format = "MM/dd/yyyy";
        }

        private void Print_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from std");
            fillGrid(cmd);
            if (rb_No.Checked)
            {
                dtPicker_min.Enabled = false;
                dt_picker_Max.Enabled = false;
            }
        }

        private void bt_check_Print_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            string strGender;
            string strTime;

            if (rbFemaleStd.Checked == true)
            {
                strGender = "Female";
                //cmd = new SqlCommand("SELECT * FROM Std WHERE gender ='Female'");
            }
            else if (rbMaleStd.Checked == true)
            {
                strGender = "Male";
                //cmd = new SqlCommand("SELECT * FROM Std WHERE gender ='Male'");
            }
            else
            {
                strGender = "";
                //cmd = new SqlCommand("SELECT * FROM Std");
            }



            if (rb_Yes.Checked == true)
            {
                DateTime dMin = dtPicker_min.Value;
                DateTime dMax = dt_picker_Max.Value;

                if (strGender == "Male" || strGender == "Female")
                {
                    cmd = new SqlCommand("SELECT * FROM Std WHERE gender = '" + strGender + "' AND bdate >= '" + dMin + "' AND bdate <= '" + dMax + "'", db.getConnection);
                }
                else
                {
                    cmd = new SqlCommand("SELECT * FROM Std WHERE bdate >= '" + dMin + "' AND bdate <= '" + dMax + "'", db.getConnection);
                }

            }
            else
            {
                if (strGender.Contains("Male") || strGender.Contains("Female"))
                {
                    cmd = new SqlCommand("SELECT * FROM Std WHERE gender = '" + strGender + "'");
                }
                else
                {
                    cmd = new SqlCommand("SELECT * FROM Std");
                }


            }
            fillGrid(cmd);
        }


        private void rb_Yes_CheckedChanged(object sender, EventArgs e)
        {
            dtPicker_min.Enabled = true;
            dt_picker_Max.Enabled = true;
        }

        private void rb_No_CheckedChanged(object sender, EventArgs e)
        {
            dtPicker_min.Enabled = false;
            dt_picker_Max.Enabled = false;
        }

        private void bt_printer_Click(object sender, EventArgs e)
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

        private void bt_Save_Text_file_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.DefaultExt = "*.docx";
            save.Filter = "DOCX Files|*.docx";
            if (save.ShowDialog() == DialogResult.OK && dataGridView_Print.Rows.Count + 1 > 0)
            {
                Spire.Doc.Document doc = new Spire.Doc.Document();

                Spire.Doc.Documents.Paragraph paragraph1 = doc.AddSection().AddParagraph();
                TextRange text1 = paragraph1.AppendText("DANH SACH SINH VIEN\n");
                TextRange text2 = paragraph1.AppendText("HK II Nam 2020-2021\n");
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

                for (int i = 0; i < dataGridView_Print.Rows.Count; i++)
                {
                    Spire.Doc.TableRow DataRow = table.Rows[i + 1];
                    Spire.Doc.Documents.Paragraph paragraph;
                    for (int j = 0; j < dataGridView_Print.Columns.Count - 1; j++)
                    {
                        DataRow.Height = 100;
                        DataRow.Cells[j].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                        paragraph = DataRow.Cells[j].AddParagraph();
                        paragraph.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
                        Spire.Doc.Fields.TextRange text = paragraph.AppendText(dataGridView_Print.Rows[i].Cells[j].Value.ToString());
                        text.CharacterFormat.FontName = "Times New Roman";
                        text.CharacterFormat.FontSize = 13;
                    }

                    DataRow.Cells[3].Paragraphs[0].Text = "";
                    DateTime date = (DateTime)dataGridView_Print.Rows[i].Cells[3].Value;
                    DataRow.Cells[3].Paragraphs[0].Text = date.ToString("dd/MM/yyyy");

                    paragraph = DataRow.Cells[7].AddParagraph();
                    byte[] pic;
                    pic = (byte[])dataGridView_Print.Rows[i].Cells[7].Value;
                    MemoryStream picture = new MemoryStream(pic);
                    System.Drawing.Image image = System.Drawing.Image.FromStream(picture);
                    DocPicture pc = paragraph.AppendPicture(image);
                    pc.Height = 100; pc.Width = 100;
                }
                doc.SaveToFile(save.FileName);
                doc.Close();
            }
        }
    }
}
