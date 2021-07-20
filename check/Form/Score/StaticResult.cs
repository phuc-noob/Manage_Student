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
    public partial class StaticResult : Form
    {
        public StaticResult()
        {
            InitializeComponent();
        }
        int locationY = 44;
        Score score = new Score();
        MY_DB db = new MY_DB();
        private void StaticResult_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            //SqlCommand cmd =new SqlCommand("select Std.id as id from Std,Score where id =student_id")


            dt = score.getAvgScoreByCourse();

            int countPass = 0;
            for(int i =0;i < dt.Rows.Count; i++)
            {
                Label lbl = new Label();
                lbl.Name = "lbl_Task";
                lbl.Text =string.Format("{0} : {1:0.00}", dt.Rows[i][0].ToString(),double.Parse(dt.Rows[i][1].ToString())) ;
                lbl.Top = locationY + 30;
                locationY += 30;
                lbl.Left = 40;
                lbl.Font = new Font("Arial", 10.25F, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                lbl.AutoSize = true;
                // set other properties
                this.Controls.Add(lbl);
            }
            ResultByAvgScore rScore = new ResultByAvgScore();
            DataTable dtResult = new DataTable();
            //dtResult = rScore.getResultPass();

            int cFail = 0;
            for(int i =0;i < dt.Rows.Count; i++)
            {
                if(double.Parse(dt.Rows[i][1].ToString()) <5)
                {
                    cFail += 1;
                }
            }


            int countFail = 0;
            DataTable StdTable = new DataTable();
            DataTable scoreTable = new DataTable();
            DataTable avg = new DataTable();
            // get info student

            SqlCommand cmd = new SqlCommand("select id as Student_Id, fname,lname from Std ", db.getConnection);
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



            for (int i = 0; i < StdTable.Rows.Count; i++)
            {
                for (int j = 0; j < scoreTable.Rows.Count; j++)
                {
                    if (StdTable.Rows[i]["Student_Id"].ToString() == scoreTable.Rows[j]["student_id"].ToString())
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
            for (int i = 0; i < StdTable.Rows.Count; i++)
            {
                for (int j = 0; j < avg.Rows.Count; j++)
                {
                    if (StdTable.Rows[i]["student_id"].ToString() == avg.Rows[j]["student_id"].ToString())
                    {
                        StdTable.Rows[i]["Average"] = avg.Rows[j]["avg"].ToString();
                        if (double.Parse(avg.Rows[j]["avg"].ToString()) >= 5)
                        {
                            StdTable.Rows[i]["result"] = "PASS";
                        }
                        else
                        {
                            StdTable.Rows[i]["result"] = "FAIL";
                            countFail += 1;
                        }
                    }
                }
            }
            double failPercent =( 1.0 * countFail / StdTable.Rows.Count)*100;

            label_pass.Text = string.Format("PASS : {0:00.00} % ",100-failPercent);
            label_pail.Text = string.Format("Fail : {0:00.00} % ", failPercent);

            chart_result.Titles.Add("Static FASS/FAIL OF Student");
            chart_result.Series["result"].Points.AddXY("FASS", 100 - failPercent);
            chart_result.Series["result"].Points.AddXY("FAIL", failPercent);
        }
    }
}
