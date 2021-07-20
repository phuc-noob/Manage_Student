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
    public partial class registerUser : Form
    {
        public registerUser()
        {
            InitializeComponent();
        }


        private void Cancer_Click(object sender, EventArgs e)
        {
            fLogin flogin = new fLogin();
            this.Hide();
            flogin.ShowDialog();
            this.Close();
        }

        private void button_Upload_pic_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBox_userPic.Image = Image.FromFile(opf.FileName);
            }
        }

        public bool verifyData(int id, string fname, string lname, string username, string password, MemoryStream pic)
        {
            if(fname =="" ||lname =="" ||username ==""||password == "")
            {
                return false;
            }
            else { return true; }
        }

        private void regis_Click(object sender, EventArgs e)
        {
            int id =0;
            if (tb_id.Text == "")
            {
                MessageBox.Show("Please enter Account Id", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                id = int.Parse(tb_id.Text);
            }
            string fname = textBox_fname.Text;
            string lname = tb_lastName.Text;
            string username = tb_userName.Text;
            string pw = textBox_password.Text;
            //string confirmPw = textBox_confirmPw.Text;
            MemoryStream pic = new MemoryStream();
            pictureBox_userPic.Image.Save(pic, pictureBox_userPic.Image.RawFormat);


            if (this.verifyData(id, fname, lname, username, pw, pic))
            {
                user us = new user();
                if (us.isExistUser(username, id))
                {
                    MessageBox.Show("This Account is Existed", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (us.insertUser(id, fname, lname, username, pw, pic))
                    {
                        MessageBox.Show("Register Success", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Your info must not empty !", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void linkLabel_haveAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fLogin login = new fLogin();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }
        // move form when formborderstype is none
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }
        //----------end of move form -------------

        private void registerUser_Load(object sender, EventArgs e)
        {

        }
    }
}
