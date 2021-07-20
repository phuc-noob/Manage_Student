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
    public partial class RemoveScore : Form
    {
        public RemoveScore()
        {
            InitializeComponent();
        }
        Score score = new Score();
        private void RemoveScore_Load(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();
            SqlCommand cmd = new SqlCommand("SELECT Std.id,fname,lname,Course.id,label,student_score FROM Score,Course,Std where Std.id =Score.student_id and Course.id =score.course_id", db.getConnection);
            db.OpenConnection();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            db.closeConnection();
            dataGridView_Score.AutoResizeColumnHeadersHeight();

            dataGridView_Score.DataSource = dt;
            dataGridView_Score.ReadOnly = true;
            // image size
            
            //dataGridView_Score.RowTemplate.MinimumHeight = 80;
            dataGridView_Score.DataSource = dt;
            dataGridView_Score.Columns[0].HeaderText = "Student ID";
            dataGridView_Score.Columns[1].HeaderText = "First Name";
            dataGridView_Score.Columns[2].HeaderText = "Last Name";
            dataGridView_Score.Columns[3].HeaderText = "Course ID";
            dataGridView_Score.Columns[4].HeaderText = "Label";
            dataGridView_Score.Columns[5].HeaderText = "Student Score";
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are yousure you want to delete this Course", "Remve Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                RemoveScore rScore = new RemoveScore();
                int id = int.Parse(dataGridView_Score.CurrentRow.Cells[0].Value.ToString());
                int cid = int.Parse(dataGridView_Score.CurrentRow.Cells[3].Value.ToString());
                if (score.deleteScoreById(id, cid))
                {
                    MessageBox.Show("Score deleted", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RemoveScore_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Score not deleted", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
