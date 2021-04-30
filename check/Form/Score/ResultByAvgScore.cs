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
    public partial class ResultByAvgScore : Form
    {
        public ResultByAvgScore()
        {
            InitializeComponent();
        }
        MY_DB db = new MY_DB();
        Student std = new Student();

        DataTable dt = new DataTable();
        private void button_search_Click(object sender, EventArgs e)
        {
            if (tb_id_fname.Text == "")
            {
                MessageBox.Show("Enter Id or Fname to Search", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    dt = std.getStudentById(int.Parse(tb_id_fname.Text));
                    tb_sid.Text = dt.Rows[0]["id"].ToString();
                    tb_fname.Text = dt.Rows[0]["fname"].ToString();
                    tb_lname.Text = dt.Rows[0]["lname"].ToString();
                } catch (Exception ex)
                {
                    dt = std.getStdByFname(string.Format(tb_id_fname.Text));
                    tb_sid.Text = dt.Rows[0]["id"].ToString();
                    tb_fname.Text = dt.Rows[0]["fname"].ToString();
                    tb_lname.Text = dt.Rows[0]["lname"].ToString();
                }
                finally
                {
                    tb_id_fname.Text = "";
                }
            }
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
                string tTemp = dr[0].ToString();
                dt.Columns.Add(tTemp, typeof(System.Int32));
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
            dt.Rows[0]["Average Score"] = string.Format("{0:00.00}",avg);
            
            // add Data to result column
            dt.Columns.Add("Result", typeof(System.String));
            if(avg >= 5)
            {
                dt.Rows[0]["Result"] = "PASS";
            }
            else
            {
                dt.Rows[0]["Result"] = "PAIL";
            }
            dataGridView_Result.DataSource = dt;
        }
        public DataTable getResultPass()
        {
            return dt;
        }

        private void bt_cancer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResultByAvgScore_Load(object sender, EventArgs e)
        {
            // get info student
            DataTable StdTable = new DataTable();
            SqlCommand cmd = new SqlCommand("select id as Student_Id, fname,lname from Std ",db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(StdTable);
            //dataGridView_Result.DataSource = firstTable;

            // get info score 
            DataTable scoreTable = new DataTable();
            cmd = new SqlCommand("select score.student_id, Score.Course_id,label,student_score from Score ,Course where Score.course_id =course.id", db.getConnection);
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(scoreTable);
            dataGridView_Result.DataSource = scoreTable;

            // creat column for table 
            // id creat column from score so the label can loop 
            DataTable labelTable = new DataTable();
            cmd = new SqlCommand("select  label from Score group by label", db.getConnection);
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(labelTable);
            dataGridView_Result.DataSource = labelTable;
            for (int i =0; i < scoreTable.Rows.Count; i++)
            {

            }
        }
    }
}
