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
    public partial class findStudent : Form
    {
        Student student = new Student();
        public findStudent()
        {
            InitializeComponent();
        }
        public TextBox text_Id
        {
            get { return this.textId; }
            set { this.textId = value; }
        }
        public RadioButton gmale
        {
            get { return this.rbMale; }
            set { this.rbMale = value; }
        }
        public TextBox text_name
        {
            get { return this.textFname; }
            set { this.textFname = value; }
        }
        public TextBox text_lname
        {
            get { return this.textLname; }
            set { this.textLname = value; }
        }
        public DateTime dtime
        {
            get { return this.dateTimePicker_Student.Value; }
            set { this.dateTimePicker_Student.Value = value; }
        }
        public RadioButton gender { 
            get { return this.rbFemale; }
            set { this.rbFemale=value; }
        }
        public TextBox phone
        {
            get { return this.textPhone; }
            set { this.textPhone = value; }
        }
        public TextBox address
        {
            get { return this.textAddress; }
            set { this.textAddress = value; }
        }
        public PictureBox StdImage
        {
            get { return this.pic_box_infoStudent; }
            set { this.pic_box_infoStudent = value; }
        }
        private void button1_Click(object sender, EventArgs e)
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

                    dateTimePicker_Student.Value = (DateTime)dt.Rows[0]["bdate"];

                    if (dt.Rows[0]["gender"].ToString() == "Female")
                    {
                        rbFemale.Checked = true;
                    }
                    else
                    {
                        rbMale.Checked = true;
                    }
                    textPhone.Text = dt.Rows[0]["phone"].ToString();
                    textAddress.Text = dt.Rows[0]["address"].ToString();

                    byte[] pic = (byte[])dt.Rows[0]["picture"];
                    MemoryStream picture = new MemoryStream(pic);
                    pic_box_infoStudent.Image = Image.FromStream(picture);
                }
            }
            catch
            {
                MessageBox.Show("error to find....");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        public bool vetifyData()
        {
            if (textId.Text.Trim() == ""
                || textFname.Text.Trim() == ""
                || textLname.Text.Trim() == ""
                || textPhone.Text.Trim() == ""
                || textAddress.Text.Trim() == ""
                || pic_box_infoStudent.Image == null
                )
            {
                return false;
            }
            else { return true; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student std = new Student();
            
            try
            {
                bool del = std.deleteStudent(int.Parse(textId.Text));
                if (del)
                {
                    text_Id.Text = "";
                    textFname.Text = "";
                    textLname.Text = "";
                    textPhone.Text = "";
                    textAddress.Text = "";
                    dateTimePicker_Student.Value = DateTime.Now;
                    pic_box_infoStudent.Image = null;
                    MessageBox.Show("Student Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error To Delete Student ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textId_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt_update_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "SELECT Image (*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if(opf.ShowDialog() == DialogResult.OK)
            {
                pic_box_infoStudent.Image = Image.FromFile(opf.FileName);
            }
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            int id;
            string fName =textFname.Text;
            string lName =textLname.Text;
            string address = textAddress.Text;
            string phone = textPhone.Text;
            string gender = "Male";
            DateTime dtStudent = dateTimePicker_Student.Value;

            if(rbFemale.Checked == true)
            {
                gender = rbFemale.Text;
            }

            MemoryStream pic = new MemoryStream();
            int bornYear = dtStudent.Year;
            int thisYear = DateTime.Now.Year;
            if(thisYear -bornYear <10 || thisYear - bornYear > 100)
            {
                MessageBox.Show("Student Age Must Between 10 to 100", "Warning info of Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    id = Convert.ToInt32(text_Id.Text);
                    pic_box_infoStudent.Image.Save(pic, pic_box_infoStudent.Image.RawFormat);
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
    }
}
