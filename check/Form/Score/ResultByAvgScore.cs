using Spire.Doc.Documents;
using Spire.Doc.Fields;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace check
{
    public partial class ResultByAvgScore : Form
    {
        public ResultByAvgScore()
        {
            InitializeComponent();
        }
        MY_DB db = new MY_DB();
        Student std = new Student();
        public static double failPercent;
        
        private void button_search_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (tb_id_fname.Text == "")
                {
                    dataGridView_Result.Columns.Clear();
                    ResultByAvgScore_Load(sender, e);
                }
                else
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        //dt = std.getStudentById(int.Parse(tb_id_fname.Text));
                        SqlCommand command = new SqlCommand("select id,fname,lname from Std Where CONCAT(id,fname) LIKE'%" + tb_id_fname.Text + "%'", db.getConnection);
                        db.OpenConnection();
                        SqlDataAdapter sda = new SqlDataAdapter(command);
                        sda.Fill(dt);

                        tb_sid.Text = dt.Rows[0]["id"].ToString();
                        tb_fname.Text = dt.Rows[0]["fname"].ToString();
                        tb_lname.Text = dt.Rows[0]["lname"].ToString();
                        // get dt id course and id student
                        SqlCommand cmd = new SqlCommand("select label,student_score from Score,Course where score.student_id =@sid and Score.course_id = course.id ", db.getConnection);
                        cmd.Parameters.Add("@sid", SqlDbType.Int).Value = Convert.ToInt32(tb_sid.Text);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTB = new DataTable();
                        adapter.Fill(dataTB);

                        // dt table and add column to table
                        DataTable temp = new DataTable();
                        cmd = new SqlCommand("select * from dataTB ,std,score where dataTB.id =course.");
                        adapter.Fill(temp);
                        foreach (DataRow dr in dataTB.Rows)
                        {
                            try
                            {
                                string tTemp = dr[0].ToString();
                                dt.Columns.Add(tTemp, typeof(System.Double));
                            }
                            catch (Exception ex)
                            {

                            }

                        }
                        Double avg = 0;

                        // enter data to table 
                        for (int i = 0; i < dataTB.Rows.Count; i++)
                        {
                            avg += Convert.ToInt32(dataTB.Rows[i][1].ToString());
                            dt.Rows[0][3 + i] = dataTB.Rows[i][1].ToString();
                        }

                        // add data to column avg 
                        avg /= dataTB.Rows.Count;
                        dt.Columns.Add("Average Score", typeof(System.Double));
                        dt.Rows[0]["Average Score"] = string.Format("{0:00.00}", avg);

                        // add Data to result column
                        dt.Columns.Add("Result", typeof(System.String));
                        avg = Math.Round(avg, 2);
                        if (avg >= 8.5)
                        {
                            // 8.5 - A; 7 - B ;5,5 - C; 4 -D
                            dt.Rows[0]["result"] = "A";
                        }
                        else if (avg >= 7)
                        {
                            // 8.5 - A; 7 - B ;5,5 - C; 4 -D
                            dt.Rows[0]["result"] = "B";
                        }
                        else if (avg >= 5.5)
                        {
                            // 8.5 - A; 7 - B ;5,5 - C; 4 -D
                            dt.Rows[0]["result"] = "C";
                        }
                        else if (avg >= 4)
                        {
                            dt.Rows[0]["result"] = "D";
                          
                        }
                        else
                        {
                            dt.Rows[0]["result"] = "F";
                        }
                        dataGridView_Result.Columns.Clear();
                        dataGridView_Result.DataSource = dt;
                        dataGridView_Result.Columns[0].HeaderText = "Student ID";
                        dataGridView_Result.Columns[1].HeaderText = "First Name";
                        dataGridView_Result.Columns[2].HeaderText = "Last Name";
                    }
                    catch (Exception ex)
                    {

                    }
                    finally
                    {
                        tb_id_fname.Text = "";
                    }
                }


                
            }catch(Exception ex)
            {
                
            }
        }
        

        private void bt_cancer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResultByAvgScore_Load(object sender, EventArgs e)
        {
            try
            {
                Global.level.Add("A", 0);
                Global.level.Add("B", 0);
                Global.level.Add("C", 0);
                Global.level.Add("D", 0);
                Global.level.Add("F", 0);

            }catch(Exception ex)
            {

            }
            finally
            {
                Global.level["A"] = 0;
                Global.level["B"] = 0;
                Global.level["C"] = 0;
                Global.level["D"] = 0;
                Global.level["F"] = 0;
            }
            int countFail = 0;
            DataTable StdTable =new DataTable();
            DataTable scoreTable = new DataTable();
            DataTable avg = new DataTable();
            // get info student

            SqlCommand cmd = new SqlCommand("select id as Student_Id, fname,lname from Std ",db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(StdTable);
            //dataGridView_Result.DataSource = firstTable;

            // get info score 
            
            cmd = new SqlCommand("select score.student_id, Score.Course_id,label,student_score from Score ,Course where Score.course_id =course.id", db.getConnection);
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(scoreTable);

            for (int j = 0; j < scoreTable.Rows.Count; j++)
            {
                    DataColumnCollection columns = StdTable.Columns;
                    if (!columns.Contains(scoreTable.Rows[j]["label"].ToString()))
                    {
                        StdTable.Columns.Add(scoreTable.Rows[j]["label"].ToString(), typeof(System.Double));
                    }
                
            }

            

            for (int i =0;i <StdTable.Rows.Count;i++)
            {
                for(int j=0;j <scoreTable.Rows.Count;j++)
                {
                    if(StdTable.Rows[i]["Student_Id"].ToString() == scoreTable.Rows[j]["student_id"].ToString())
                    {
                        StdTable.Rows[i][scoreTable.Rows[j]["label"].ToString()] = scoreTable.Rows[j]["student_score"].ToString();
                    }
                }
            }

            // add column avg
            StdTable.Columns.Add("Average", typeof(System.Double));
            StdTable.Columns.Add("Result", typeof(System.String));
            // add column 

            
            cmd = new SqlCommand("select student_id, AVG(student_score) as avg from Score group by student_id", db.getConnection);
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(avg);

            for(int k =0; k < avg.Rows.Count; k++)
            {
                if (avg.Rows[k]["avg"].ToString().Length > 5)
                {
                    avg.Rows[k]["avg"] = Math.Round(double.Parse(avg.Rows[k]["avg"].ToString()),2);
                }
            }

            for (int i = 0; i < StdTable.Rows.Count; i++)
            {

                

                for(int j=0; j < avg.Rows.Count; j++)
                {
                    if(StdTable.Rows[i]["student_id"].ToString() == avg.Rows[j]["student_id"].ToString())
                    {
                        StdTable.Rows[i]["Average"] = avg.Rows[j]["avg"].ToString();
                        if(double.Parse(avg.Rows[j]["avg"].ToString()) >= 8.5)
                        {
                            // 8.5 - A; 7 - B ;5,5 - C; 4 -D
                            StdTable.Rows[i]["result"] = "A";
                            Global.level["A"] += 1;
                        }
                        else if(double.Parse(avg.Rows[j]["avg"].ToString()) >= 7)
                        {
                            StdTable.Rows[i]["result"] = "B";
                            Global.level["B"] += 1;
                            countFail += 1;
                        }
                        else if (double.Parse(avg.Rows[j]["avg"].ToString()) >= 5.5)
                        {
                            StdTable.Rows[i]["result"] = "C";
                            Global.level["C"] += 1;
                            countFail += 1;
                        }
                        else if (double.Parse(avg.Rows[j]["avg"].ToString()) >= 4)
                        {
                            StdTable.Rows[i]["result"] = "D";
                            Global.level["D"] += 1;
                            countFail += 1;
                        }
                        else
                        {
                            StdTable.Rows[i]["result"] = "F";
                            Global.level["F"] += 1;
                            countFail += 1;
                        }
                    }
                }
            }
            dataGridView_Result.DataSource = StdTable;
            dataGridView_Result.Columns[0].HeaderText = "Student ID";
            dataGridView_Result.Columns[1].HeaderText = "First Name";
            dataGridView_Result.Columns[2].HeaderText = "Last Name";
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.DefaultExt = "*.docx";
            save.Filter = "DOCX Files|*.docx";
            if (save.ShowDialog() == DialogResult.OK && dataGridView_Result.Rows.Count + 1 > 0)
            {
                Spire.Doc.Document doc = new Spire.Doc.Document();

                Spire.Doc.Documents.Paragraph paragraph1 = doc.AddSection().AddParagraph();
                TextRange text0 = paragraph1.AppendText("TRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ TP.HỒ CHÍ MINH\n\n");
                Spire.Doc.Fields.TextRange text1 = paragraph1.AppendText("\t\t\t\t\tKẾT QUẢ HỌC TẬP\n");
                Spire.Doc.Fields.TextRange text2 = paragraph1.AppendText("\t\t\t\t\t    HK II Nam 2020-2021\n");
                text0.CharacterFormat.FontName = "Times New Roman";
                text1.CharacterFormat.FontName = "Times New Roman";
                text2.CharacterFormat.FontName = "Times New Roman";

                text0.CharacterFormat.FontSize = 10;
                text1.CharacterFormat.FontSize = 15;
                text2.CharacterFormat.FontSize = 12;
                //paragraph1.Format.TextAlignment = TextAlignment.Center;              // văn bản canh giữa 
                paragraph1.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Left;  // đoạn canh giữa

                Spire.Doc.Table table = doc.Sections[0].AddTable(true);

                // Số dòng và số cột cho bảng
                table.ResetCells(dataGridView_Result.Rows.Count + 1, dataGridView_Result.Columns.Count);
                for (int i = 0; i < dataGridView_Result.Columns.Count; i++)
                {
                    doc.Sections[0].Tables[0].Rows[0].Cells[i].Width = 200;
                }

                //Đặt hàng đầu tiên là header
                Spire.Doc.TableRow Frow = table.Rows[0];
                Frow.IsHeader = true;
                Frow.Height = 23;

                for (int i = 0; i < dataGridView_Result.Columns.Count; i++)
                {
                    Spire.Doc.Documents.Paragraph p = Frow.Cells[i].AddParagraph();
                    Frow.Cells[i].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                    p.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Left;

                    Spire.Doc.Fields.TextRange tr = p.AppendText(dataGridView_Result.Columns[i].HeaderText);
                    tr.CharacterFormat.FontName = "Times New Roman";
                    tr.CharacterFormat.FontSize = 10;
                    tr.CharacterFormat.Bold = true;
                }

                for (int i = 0; i < dataGridView_Result.Rows.Count - 1; i++)
                {
                    Spire.Doc.TableRow DataRow = table.Rows[i + 1];
                    Spire.Doc.Documents.Paragraph paragraph;
                    for (int j = 0; j < dataGridView_Result.Columns.Count; j++)
                    {
                        DataRow.Height = 30;
                        DataRow.Cells[j].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                        paragraph = DataRow.Cells[j].AddParagraph();
                        paragraph.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
                        string textString = dataGridView_Result.Rows[i].Cells[j].Value.ToString();
                        Spire.Doc.Fields.TextRange text = paragraph.AppendText(dataGridView_Result.Rows[i].Cells[j].Value.ToString());
                        text.CharacterFormat.FontName = "Times New Roman";
                        text.CharacterFormat.FontSize = 10;
                    }
                }
                doc.SaveToFile(save.FileName);
                doc.Close();
            }
        }

        private void button_printer_Click(object sender, EventArgs e)
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

        private void button_static_Click(object sender, EventArgs e)
        {
            StaticStudentScore staticScore = new StaticStudentScore();
            staticScore.Show();
        }
    }
}
