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
    public partial class AddCourseEX : Form
    {
        public AddCourseEX()
        {
            InitializeComponent();
        }
        MY_DB db = new MY_DB();
        Course course = new Course();
        List<string> lCour = new List<string>();
        public TextBox tbStuID()
        {
            return this.tb_stuId;
        }
        private void AddCourseEX_Load(object sender, EventArgs e)
        {
            DataTable dt = course.getAllCourse();
            listBox_avaiCourse.DataSource = dt;
            listBox_avaiCourse.DisplayMember = "label";
            listBox_avaiCourse.ValueMember = "id";

            List<int> semester = new List<int>(new int[] { 1,2,3,4,5,6,7,8});
            comboBox_semester.DataSource = semester;

            DataTable sem = course.getCourseBySem(1);
            listBox_avaiCourse.DataSource =sem;
        }
        DataTable dt = new DataTable();
        List<int> lCourId;
        private void comboBox_semester_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sid;
            int sem =int.Parse(comboBox_semester.SelectedValue.ToString());
            try
            {
                sid = int.Parse(tb_stuId.Text);
            }catch(Exception ex)
            {
                sid = 0;
            }
            
            DataTable semester = course.getCourseBySem(sem);
            listBox_avaiCourse.DataSource = semester;
            listBox_avaiCourse.DisplayMember = "label";

            SqlCommand cmd = new SqlCommand("select Course.id,label from stuCourse,Course where semester =@sem and student_id =@sid and id =course_id", db.getConnection);
            cmd.Parameters.Add("@sem", SqlDbType.Int).Value = sem;
            cmd.Parameters.Add("@sid",SqlDbType.Int).Value =sid;
            
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            db.OpenConnection();
            dt = new DataTable();
            lCourId= new List<int>();
            adapter.Fill(dt);

            listBox_selected.DataSource = dt; 
            listBox_selected.DisplayMember = "label";
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            int label = int.Parse(listBox_avaiCourse.SelectedValue.ToString());

            DataTable cour = course.getCourseById(label);
            DataRow dr = dt.NewRow();
            dr["label"] = cour.Rows[0]["label"].ToString();
            dr["id"] = label;
            bool row = true;
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                if(int.Parse(dt.Rows[i]["id"].ToString()) == label)
                {
                    row = false;
                }
            }
            if (row)
            {
                dt.Rows.Add(dr);
                lCourId.Add(label);
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            bool c = false;
            
            foreach(int i in lCourId)
            {
                if(course.insertStuCourse(int.Parse(tb_stuId.Text), i))
                {
                    c = true;
                }
                else
                {
                    MessageBox.Show("Course is not Insert", "Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if(c)
            {
                MessageBox.Show("Add Course Success", "Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
