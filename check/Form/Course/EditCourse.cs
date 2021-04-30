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

        private void EditCourse_Load(object sender, EventArgs e)
        {
            
            comboBoxCourse.DataSource = crs.getAllCourse();
            comboBoxCourse.DisplayMember = "label";
            comboBoxCourse.ValueMember = "id";
            comboBoxCourse.SelectedItem = null;
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
            if (!crs.isExistCourse(name ,Convert.ToInt32(comboBoxCourse.SelectedValue)))
            {
                MessageBox.Show("This Course Name Aready Exist", "Edit Course Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(crs.updateCourse(id,name,hour,des))
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
