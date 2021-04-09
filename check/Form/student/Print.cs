using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Word Document (*.doc)|*.docx";
            sfd.FileName = "export.docx";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Export_Data_To_Word(dataGridView_Print, sfd.FileName);
            }
        }

        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {
            if (DGV.Rows.Count != 0)
            {
                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count;

                Document oDoc = new Document();
                oDoc.Application.Visible = true;

                oDoc.PageSetup.Orientation = WdOrientation.wdOrientLandscape;

                //dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                Object oMissing = System.Reflection.Missing.Value;
                for (int r = 0; r <= RowCount - 1; r++)
                {
                    oTemp = "";
                    for (int c = 0; c < ColumnCount - 1; c++)
                    {
                        oTemp = oTemp + DGV.Rows[r].Cells[c].Value + "\t";
                    }
                    var oPara1 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara1.Range.Text = oTemp;
                    oPara1.Range.InsertParagraphAfter();
                    byte[] imgbyte = (byte[])dataGridView_Print.Rows[r].Cells[7].Value;
                    MemoryStream ms = new MemoryStream(imgbyte);
                    //Image sparePicture = Image.FromStream(ms);
                    Image finalPic = (Image)(new Bitmap(Image.FromStream(ms), new Size(50, 50)));
                    Clipboard.SetDataObject(finalPic);
                    var oPara2 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara2.Range.Paste();
                    oPara2.Range.InsertParagraphAfter();
                    //oTemp += "\n";
                }

                //save the file
                oDoc.SaveAs2(filename);
            }
        }
    }
}
