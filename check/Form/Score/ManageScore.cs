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
    public partial class ManageScore : Form
    {
        public ManageScore()
        {
            InitializeComponent();
        }
        Score score = new Score();
        Student std = new Student();
        Course cour = new Course();
        MY_DB db = new MY_DB();
        int s_Id = 0;
    
        private void ManageScore_Load(object sender, EventArgs e)
        {
            cb_course.DataSource = cour.getAllCourse();
            cb_course.DisplayMember = "label";
            cb_course.ValueMember = "id";

            ///            tb_id.Text = dataGridView_manage.CurrentRow.Cells[0].Value.ToString();
            MY_DB db = new MY_DB();
            SqlCommand cmd = new SqlCommand("SELECT Std.id,fname,lname,Course.id,label,student_score FROM Score,Course,Std where Std.id =Score.student_id and Course.id =score.course_id", db.getConnection);
            db.OpenConnection();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            db.closeConnection();
            dataGridView_manage.AutoResizeColumnHeadersHeight();
            dataGridView_manage.DataSource = dt;
            dataGridView_manage.ReadOnly = true;
            // image size

            //dataGridView_manage.RowTemplate.MinimumHeight = 80;
            dataGridView_manage.DataSource = dt;
            int courId = Convert.ToInt32(cb_course.SelectedValue);
            tb_id.Text = dataGridView_manage.CurrentRow.Cells[0].Value.ToString();
            s_Id = int.Parse(tb_id.Text);
            fillScore(s_Id,courId);
        }
        public void fillScore(int s_id,int c_id)
        {
            
            
            DataTable dtScore = score.getScoreById(s_id, c_id);
            
            try
            {
                tb_des.Text = dtScore.Rows[0]["description"].ToString();
                tb_Score.Text = dtScore.Rows[0]["student_score"].ToString();
            }
            catch (Exception ex)
            {
                tb_des.Text = "";
                tb_Score.Text = "";
            }
        }

        private void button_show_Student_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();
            SqlCommand cmd = new SqlCommand("SELECT id,fname,lname,bdate FROM Std", db.getConnection);
            db.OpenConnection();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            db.closeConnection();
            dataGridView_manage.AutoResizeColumnHeadersHeight();
            dataGridView_manage.DataSource = dt;
            dataGridView_manage.ReadOnly = true;
            
            dataGridView_manage.Columns[3].DefaultCellStyle.Format = "MM/dd/yyyy";
        }

        private void button_ShowScore_Click(object sender, EventArgs e)
        {
            this.ManageScore_Load(sender, e);
        }

        
        private void dataGridView_manage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_id.Text = dataGridView_manage.CurrentRow.Cells[0].Value.ToString();
            s_Id = Convert.ToInt32(tb_id.Text);
            int courId = Convert.ToInt32(cb_course.SelectedValue);
            fillScore(s_Id, courId);
        }

        private void cb_course_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                s_Id = Convert.ToInt32(tb_id.Text);
                int courId = Convert.ToInt32(cb_course.SelectedValue);
                fillScore(s_Id, courId);
            }
            catch (Exception ex )
            {

            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            try
            {
                int stdId = int.Parse(tb_id.Text);
                int courId = Convert.ToInt32(cb_course.SelectedValue);
                float score_value = float.Parse(tb_Score.Text);
                string des = tb_des.Text;
                if (!score.is_existScore(stdId, courId))
                {
                    if (score.insertScore(stdId, courId, score_value, des))
                    {
                        MessageBox.Show("Score Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Score Not Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Score is exist", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            RemoveScore rScore = new RemoveScore();
            int id =int.Parse( dataGridView_manage.CurrentRow.Cells[0].Value.ToString() );
            int cid = int.Parse(dataGridView_manage.CurrentRow.Cells[3].Value.ToString());
            if (score.deleteScoreById(id,cid))
            {
                MessageBox.Show("Score deleted", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ManageScore_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Score not deleted", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_avgScore_Click(object sender, EventArgs e)
        {
            avgScoreByCourse avgScore = new avgScoreByCourse();
            avgScore.Show();
        }
    }
}
