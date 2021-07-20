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
    public partial class CourseStuList : Form
    {
        public CourseStuList(int c)
        {
            InitializeComponent();
            this.courseId = c;
        }
        MY_DB db = new MY_DB();
        public int courseId { get; set; }

        private void CourseStuList_Load(object sender, EventArgs e)
        {
            
            db.OpenConnection(); 
            DataTable dt = new DataTable();
            dt.Columns.Add("STT",typeof(System.Int32));
            SqlCommand cmd = new SqlCommand("select student_id,label,fname,lname,semester from stuCourse,Std, Course where course_id =@id and course_id =Course.id and student_id =Std.id", db.getConnection);
            cmd.Parameters.Add("id", SqlDbType.Int).Value = courseId;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            db.closeConnection();

            //--------semester and name
            textBox_cName.Text = dt.Rows[0]["label"].ToString();
            label_semester.Text = string.Format("Semester : {0} ", dt.Rows[0]["semester"].ToString());
            //-------------------------

            // ----------- add stt ------------------
            int stt = 1;
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["STT"] = stt;
                stt += 1;
            }
            //---------------------------------------
            dataGridView_lStudent.DataSource = dt;
            dataGridView_lStudent.Columns[0].Width = 50;
            dataGridView_lStudent.Columns[1].Width = 85;
            dataGridView_lStudent.Columns["semester"].Width = 80;
            dataGridView_lStudent.Columns[1].HeaderText = "Student ID";
            dataGridView_lStudent.Columns[2].HeaderText = "Label";
            dataGridView_lStudent.Columns[3].HeaderText = "First Name";
            dataGridView_lStudent.Columns[4].HeaderText = "Last Name";
            dataGridView_lStudent.Columns[5].HeaderText = "Semester";
            //dataGridView_lStudent.Columns[3].DefaultCellStyle.Format = "MM/dd/yyyy";
        }
    }
}
