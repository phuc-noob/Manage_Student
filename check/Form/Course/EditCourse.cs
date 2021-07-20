using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace check
{
    public partial class EditCourse : Form
    {
        public EditCourse()
        {   
            InitializeComponent();
        }
        Course crs = new Course();
        DataTable dt;
        private void EditCourse_Load(object sender, EventArgs e)
        {

            List<int> semester = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 });
            comboBox_semester.DataSource = semester;
            
            comboBoxCourse.DataSource = crs.getAllCourse();
            comboBoxCourse.DisplayMember = "label";
            comboBoxCourse.ValueMember = "id";
            comboBoxCourse.SelectedItem = null;

            Contact contact = new Contact();
            dt = contact.getContact();
            dt.Columns.Add("name", typeof(System.String));
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["name"] = string.Format(dt.Rows[i]["fname"].ToString() + " " + dt.Rows[i]["lname"].ToString());
            }
            
            comboBox_teacher.DataSource = dt;
            comboBox_teacher.DisplayMember = "name";
            comboBox_teacher.ValueMember = "id";
            comboBox_teacher.Text = "";
        }

        

        private void comboBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(comboBoxCourse.SelectedValue);
                DataTable dt = new DataTable();
                dt = crs.getCourseById(id);
                tb_Name.Text = dt.Rows[0][1].ToString();
                numericUpDown_hour.Value = Int32.Parse(dt.Rows[0][2].ToString());
                tb_des.Text = dt.Rows[0][3].ToString();
                comboBox_teacher.Text = dt.Rows[0]["teacher_name"].ToString();
                comboBox_semester.Text = dt.Rows[0]["semester"].ToString();
            }catch(Exception ex)
            {

            }
        }

        private void bt_EDIT_Click(object sender, EventArgs e)
        {
            string name = tb_Name.Text;
            string des = tb_des.Text;
            int hour = (int)numericUpDown_hour.Value;
            int id = Convert.ToInt32(comboBoxCourse.SelectedValue);
            int sem = int.Parse(comboBox_semester.SelectedValue.ToString());
            string tname = "";
            int tid = int.Parse(comboBox_teacher.SelectedValue.ToString());
            for (int j = 0; j < dt.Rows.Count; j++)
            {
                if (tid == int.Parse(dt.Rows[j]["id"].ToString()))
                {
                    tname = dt.Rows[j]["name"].ToString();
                }
            }
            if (!crs.isExistCourse(name ,Convert.ToInt32(comboBoxCourse.SelectedValue)))
            {
                MessageBox.Show("This Course Name Aready Exist", "Edit Course Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(crs.updateCourse(id,name,hour,des,sem,tid,tname))
            {
                MessageBox.Show("Course updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fillCombo(comboBoxCourse.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Course not updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void fillCombo(int index)
        {
            comboBoxCourse.DataSource = crs.getAllCourse();
            comboBoxCourse.DisplayMember = "label";
            comboBoxCourse.ValueMember = "id";
            comboBoxCourse.SelectedIndex = index;
        }

        private void numericUpDown_hour_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tb_des_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
