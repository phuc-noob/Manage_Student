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
    public partial class AddCourse : Form
    {
        Course crs = new Course();
        public AddCourse()
        {
            InitializeComponent();
        }
        
        private void bt_ADD_Click(object sender, EventArgs e)
        {
            string name = tb_Name.Text;
            int id = int.Parse(tb_id.Text);
            int period = int.Parse(tb_Period.Text);
            string des = tb_des.Text;
            if(period < 10)
            {
                MessageBox.Show("Period must larger than 10", "ADD COURSE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (tb_Name.Text.Trim() == "")
                {
                    MessageBox.Show("Enter The Course Name", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (crs.isExistCourse(tb_Name.Text))
                {
                    if (crs.insertCourse(id, name, period, des))
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
        }
    }
}
