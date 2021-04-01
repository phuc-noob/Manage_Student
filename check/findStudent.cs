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
            get { return this.dateTimePicker1.Value; }
            set { this.dateTimePicker1.Value = value; }
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
            get { return this.pictureBox1; }
            set { this.pictureBox1 = value; }
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

                    dateTimePicker1.Value = (DateTime)dt.Rows[0]["bdate"];

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
                    pictureBox1.Image = Image.FromStream(picture);
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

        private void button2_Click(object sender, EventArgs e)
        {
            Student std = new Student();
            bool del =std.deleteStudent(int.Parse(textId.Text));
            if(del==true)
            {
                MessageBox.Show("delete done...");
            }
            else
            {
                MessageBox.Show("error to delete...");
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
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
