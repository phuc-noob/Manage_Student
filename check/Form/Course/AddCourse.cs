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
            try
            {
                string name = tb_Name.Text;
                int id = int.Parse(tb_id.Text);
                int period = int.Parse(tb_Period.Text);
                string des = tb_des.Text;
                int sem =int.Parse(comboBox_semester.SelectedValue.ToString());

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
                    else if (crs.isExistCourse(tb_Name.Text))
                    {
                        string tname = "";
                        for(int j=0;j < dt.Rows.Count; j++)
                        {
                            if(int.Parse(comboBox_teacher.SelectedValue.ToString()) == int.Parse(dt.Rows[j]["id"].ToString()))
                            {
                                tname = dt.Rows[j]["name"].ToString();
                            }
                        }
                        if (crs.insertCourse(id, name, period, des,sem,int.Parse(comboBox_teacher.SelectedValue.ToString()),tname))
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
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        DataTable dt;
        private void AddCourse_Load(object sender, EventArgs e)
        {
            List<int> semester = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 });
            comboBox_semester.DataSource = semester;
            Contact contact = new Contact();
            dt= contact.getContact();
            dt.Columns.Add("name", typeof(System.String));
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["name"] = string.Format(dt.Rows[i]["fname"].ToString() + " " + dt.Rows[i]["lname"].ToString());
            }
            comboBox_teacher.DataSource = dt;
            comboBox_teacher.DisplayMember ="name";
            comboBox_teacher.ValueMember = "id";
        }
    }
}
