using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace check
{
    public partial class infoStudent : Form
    {
        public infoStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Student std = new Student();
            try { 
                int id = int.Parse(textId.Text);
                string fName = textFname.Text;
                string lName = textLname.Text;
                DateTime dBirth = dateTimePicker1.Value;
                string gender = "Male";
                if (rbFemale.Checked)
                {
                    gender = rbFemale.Text;
                }
                string phone = textPhone.Text;
                string address = textAddress.Text;

                MemoryStream pic = new MemoryStream();
                pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);

                if (std.insertStudent(id, fName, lName, dBirth, gender, phone, address, pic) == true)
                {
                    MessageBox.Show("Add new student success...");
                }
                else
                {
                    MessageBox.Show("error....");
                };
            }
            catch
            {
                MessageBox.Show("error...");
            }
        }
    }
}
