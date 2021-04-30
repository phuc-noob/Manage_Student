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
    public partial class manageCourse : Form
    {
        public manageCourse()
        {
            InitializeComponent();
        }
        Course course = new Course();
        int pos;
        private void manageCourse_Load(object sender, EventArgs e)
        {
            this.loadDataForm();
        }

        public void loadDataForm()
        {
            listBox_course.DataSource = course.getAllCourse();
            listBox_course.ValueMember = "id";                          // index get by id
            listBox_course.DisplayMember = "label";                    // show name of course
            listBox_course.SelectedItem = null;
            label_totalCourse.Text = String.Format("Total Course : {0}", course.getTotalCourse().ToString());
        }

        // datarow to select index of table 
        void showData(int index)
        {
            try
            {
                DataRow dr = course.getAllCourse().Rows[index];
                listBox_course.SelectedIndex = index;
                textBox_id.Text = dr.ItemArray[0].ToString();
                tb_Name.Text = dr.ItemArray[1].ToString();
                numericUpDown_hour.Value = int.Parse(dr.ItemArray[2].ToString());
                tb_des.Text = dr.ItemArray[3].ToString();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "DATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        // using datarowview to choice the index for show data
        private void listBox_course_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)listBox_course.SelectedItem;
            pos = listBox_course.SelectedIndex;
            showData(pos);
        }

        private void bt_ADD_Click(object sender, EventArgs e)
        {
            string name = tb_Name.Text;
            int id = int.Parse(textBox_id.Text);
            int period = int.Parse(numericUpDown_hour.Text);
            string des = tb_des.Text;
            if (period < 10)
            {
                MessageBox.Show("Period must larger than 10", "ADD COURSE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (tb_Name.Text.Trim() == "")
                {
                    MessageBox.Show("Enter The Course Name", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (course.isExistCourse(tb_Name.Text))
                {
                    if (course.insertCourse(id, name, period, des))
                    {
                        MessageBox.Show("New Course Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Course not inseted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("This Course Name Already Exist", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            this.loadDataForm();
        }

        private void bt_EDIT_Click(object sender, EventArgs e)
        {
            string name = tb_Name.Text;
            string des = tb_des.Text;
            int hour = (int)numericUpDown_hour.Value;
            int id = Convert.ToInt32(textBox_id.Text);
            if (!course.isExistCourse(name, Convert.ToInt32(textBox_id.Text)))
            {
                MessageBox.Show("This Course Name Aready Exist", "Edit Course Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (course.updateCourse(id, name, hour, des))
            {
                MessageBox.Show("Course updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);            
            }
            else
            {
                MessageBox.Show("Course not updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            pos = 0;
            this.loadDataForm();
        }

        private void bt_remove_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox_id.Text);
            if (course.removeCourse(id))
            {
                MessageBox.Show("Course Deleted", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ERROR TO DELETE ", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            this.loadDataForm();
            showData(0);
        }

        private void bt_First_Click(object sender, EventArgs e)
        {
            pos = 0;
            showData(pos);
        }

        private void bt_next_Click(object sender, EventArgs e)
        {
            if (pos == (course.getTotalCourse() - 1))
            {
                pos = 0;
            }
            else
            {
                pos += 1;
            }
            showData(pos);
        }

        private void bT_PREVIOUS_Click(object sender, EventArgs e)
        {
            if(pos == 0)
            {
                pos = course.getTotalCourse() - 1;
            }
            else { pos -= 1; }
            showData(pos);
        }

        private void BT_LAST_Click(object sender, EventArgs e)
        {
            pos = course.getTotalCourse();
            showData(pos-1);
        }
    }
}
