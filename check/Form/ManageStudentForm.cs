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

        }

        private void dt_gridview_mangeStudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            findStudent fStd = new findStudent();
            textId.Text = dt_gridview_mangeStudent.CurrentRow.Cells[0].Value.ToString();
            textFname.Text = dt_gridview_mangeStudent.CurrentRow.Cells[1].Value.ToString();
            textLname.Text = dt_gridview_mangeStudent.CurrentRow.Cells[2].Value.ToString();
            dt_picker_student.Value = (DateTime)dt_gridview_mangeStudent.CurrentRow.Cells[3].Value;
            if (dt_gridview_mangeStudent.CurrentRow.Cells[4].ToString() == "Female")
            {
                rbFemale.Checked = true;
            }
            else
            {
                rbMale.Checked = true;
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
    }
}
