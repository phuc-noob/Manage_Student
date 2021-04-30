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
    public partial class AddScoreForm : Form
    {
        public AddScoreForm()
        {
            InitializeComponent();
        }
        Score score = new Score();
        Student std = new Student();
        Course cour = new Course();
        MY_DB db = new MY_DB();
        private void bt_ADDScore_Click(object sender, EventArgs e)
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
                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

        }

        private void AddScoreForm_Load(object sender, EventArgs e)
        {
            cb_course.DataSource = cour.getAllCourse();
            cb_course.DisplayMember = "label";
            cb_course.ValueMember = "id";

            SqlCommand cmd = new SqlCommand("select id,fname,lname from Std");
            dtGridView_Std.DataSource = std.getStudent(cmd);
        }

        private void dtGridView_Std_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_id.Text = dtGridView_Std.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
