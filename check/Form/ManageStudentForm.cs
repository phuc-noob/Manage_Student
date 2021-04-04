using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace check
{
    public partial class ManageStudentForm : Form
    {
        public ManageStudentForm()
        {
            InitializeComponent();
        }
        private Student student = new Student();

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void ManageStudentForm_Load(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Std", db.getConnection);
            db.OpenConnection();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            db.closeConnection();
            dt_gridview_mangeStudent.AutoResizeColumnHeadersHeight();
            dt_gridview_mangeStudent.DataSource = dt;
            dt_gridview_mangeStudent.ReadOnly = true;
            // image size

            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            //dt_gridview_mangeStudent.RowTemplate.MinimumHeight = 100;
            dt_gridview_mangeStudent.DataSource = dt;
            picCol = (DataGridViewImageColumn)dt_gridview_mangeStudent.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dt_gridview_mangeStudent.AllowUserToAddRows = false;
        }

        private void dt_gridview_mangeStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Std", db.getConnection);
            db.OpenConnection();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            db.closeConnection();
            dt_gridview_mangeStudent.AutoResizeColumnHeadersHeight();
            dt_gridview_mangeStudent.DataSource = dt;
            dt_gridview_mangeStudent.ReadOnly = true;
            // image size

            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            //dt_gridview_mangeStudent.RowTemplate.MinimumHeight = 80;
            dt_gridview_mangeStudent.DataSource = dt;
            picCol = (DataGridViewImageColumn)dt_gridview_mangeStudent.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dt_gridview_mangeStudent.AllowUserToAddRows = false;
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            textId.Text = "";
            textFname.Text = "";
            textLname.Text = "";
            textPhone.Text = "";
            textAddress.Text = "";
            dt_picker_student.Value = DateTime.Now;
            pic_box_Std.Image = null;

        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            Student std = new Student();
            try
            {
                int id = int.Parse(textId.Text);
                string fName = textFname.Text;
                string lName = textLname.Text;
                DateTime dBirth = dt_picker_student.Value;
                string gender = "Male";
                if (rbFemale.Checked)
                {
                    gender = rbFemale.Text;
                }
                string phone = textPhone.Text;
                string address = textAddress.Text;

                int bornYear = dt_picker_student.Value.Year;
                int thisYear = DateTime.Now.Year;
                MemoryStream pic = new MemoryStream();
                pic_box_Std.Image.Save(pic, pic_box_Std.Image.RawFormat);
                if(thisYear-bornYear <10 ||thisYear -bornYear > 100)
                {
                    MessageBox.Show("Error to add new student", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    if (std.insertStudent(id, fName, lName, dBirth, gender, phone, address, pic) == true)
                    {
                        MessageBox.Show("Add new student success...", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.button3_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Error to add new student", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    };
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void bt_upload_Image_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pic_box_Std.Image = Image.FromFile(opf.FileName);
            }
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            int id;
            string fName = textFname.Text;
            string lName = textLname.Text;
            string address = textAddress.Text;
            string phone = textPhone.Text;
            string gender = "Male";
            DateTime dtStudent =dt_picker_student .Value;

            if (rbFemale.Checked == true)
            {
                gender = rbFemale.Text;
            }

            MemoryStream pic = new MemoryStream();
            int bornYear = dtStudent.Year;
            int thisYear = DateTime.Now.Year;
            if (thisYear - bornYear < 10 || thisYear - bornYear > 100)
            {
                MessageBox.Show("Student Age Must Between 10 to 100", "Warning info of Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    id = Convert.ToInt32(textId.Text);
                    pic_box_Std.Image.Save(pic, pic_box_Std.Image.RawFormat);
                    if (student.updateStudent(id, fName, lName, dtStudent, gender, phone, address, pic))
                    {
                        MessageBox.Show("Update Student Success", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error To Update Info Of Student", "Error to Update Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {

                }
            }
        }

        private void dt_gridview_mangeStudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            findStudent fStd = new findStudent();
            textId.Text = dt_gridview_mangeStudent.CurrentRow.Cells[0].Value.ToString();
            textFname.Text = dt_gridview_mangeStudent.CurrentRow.Cells[1].Value.ToString();
            textLname.Text = dt_gridview_mangeStudent.CurrentRow.Cells[2].Value.ToString();
            dt_picker_student.Value = (DateTime)dt_gridview_mangeStudent.CurrentRow.Cells[3].Value;
            string gd = dt_gridview_mangeStudent.CurrentRow.Cells[4].Value.ToString();
            if (gd.Contains("Male"))
            {
                rbFemale.Checked = false;
                rbMale.Checked = true;
            }
            else
            {
                rbMale.Checked = false;
                rbFemale.Checked = true;
            }
            textPhone.Text = dt_gridview_mangeStudent.CurrentRow.Cells[5].Value.ToString();
            textAddress.Text = dt_gridview_mangeStudent.CurrentRow.Cells[6].Value.ToString();
            byte[] pic = (byte[])dt_gridview_mangeStudent.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            pic_box_Std.Image = Image.FromStream(picture);
            
        }

        private void bt_remove_Click(object sender, EventArgs e)
        {
            Student std = new Student();

            try
            {
                bool del = std.deleteStudent(int.Parse(textId.Text));
                if (del)
                {
                    textId.Text = "";
                    textFname.Text = "";
                    textLname.Text = "";
                    textPhone.Text = "";
                    textAddress.Text = "";
                    dt_picker_student.Value = DateTime.Now;
                    pic_box_Std.Image = null;
                    MessageBox.Show("Student Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //this.bt_total_student(sender, e);   
                    this.button3_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Error To Delete Student ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_Find_Click(object sender, EventArgs e)
        {
            try
            {
                Student sdt = new Student();
                int id = int.Parse(textId.Text);
                SqlCommand cmd = new SqlCommand("SELECT id,fname,lname,bdate,gender,phone,address,picture FROM Std WHERE id =" + id);
                DataTable dt = sdt.getStudent(cmd);

                if (dt.Rows.Count > 0)
                {
                    textFname.Text = dt.Rows[0]["fname"].ToString();
                    textLname.Text = dt.Rows[0]["lname"].ToString();
                    
                    dt_picker_student.Value = (DateTime)dt.Rows[0]["bdate"];
                    string gd = dt.Rows[0]["gender"].ToString();
                    
                    if (gd =="Male")
                    {
                        rbMale.Checked = true;
                    }
                    else
                    {
                        rbMale.Checked = false;
                        rbFemale.Checked = true;
                    }
                    textPhone.Text = dt.Rows[0]["phone"].ToString();
                    textAddress.Text = dt.Rows[0]["address"].ToString();

                    byte[] pic = (byte[])dt.Rows[0]["picture"];
                    MemoryStream picture = new MemoryStream(pic);
                    pic_box_Std.Image = Image.FromStream(picture);
                }
            }
            catch
            {
                MessageBox.Show("error to find....");
            }

        }

        private void rbMale_Click(object sender, EventArgs e)
        {
            rbMale.Checked = true;
            rbFemale.Checked = false;
        }

        private void rbFemale_Click(object sender, EventArgs e)
        {
            rbFemale.Checked = true;
            rbMale.Checked = false;
        }

        private void bt_Search_Click(object sender, EventArgs e)
        {

        }

        private void bt_total_student_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Std", db.getConnection);
            db.OpenConnection();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            db.closeConnection();
            dt_gridview_mangeStudent.AutoResizeColumnHeadersHeight();
            dt_gridview_mangeStudent.DataSource = dt;
            dt_gridview_mangeStudent.ReadOnly = true;
            // image size

            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            //dt_gridview_mangeStudent.RowTemplate.MinimumHeight = 80;
            dt_gridview_mangeStudent.DataSource = dt;
            picCol = (DataGridViewImageColumn)dt_gridview_mangeStudent.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dt_gridview_mangeStudent.AllowUserToAddRows = false;

            int totalStd = student.getTotalStd();
            string totalText = string.Format("Total Student : {0}", totalStd);
            bt_total_student.Text = totalText;
        }
    }
}
