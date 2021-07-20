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
    public partial class editInfoUser : Form
    {
        public editInfoUser()
        {
            InitializeComponent();
        }
        user us = new user();

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

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

        private void editInfoUser_Load(object sender, EventArgs e)
        {
            
        }
        public bool verifyData(int id, string fname, string lname, string username, string password, MemoryStream pic)
        {
            if (fname == "" || lname == "" || username == "" || password == "")
            {
                return false;
            }
            else { return true; }
        }

        private void Cancer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public TextBox id()
        {
            return this.tb_id;
        }
        public TextBox fname()
        {
            return this.textBox_fname;
        }
        public TextBox lname()
        {
            return this.tb_lastName;
        }
        public TextBox username()
        {
            return this.tb_userName;
        }
        public TextBox pw()
        {
            return this.textBox_password;
        }
        public PictureBox pic()
        {
            return this.pictureBox_userPic;
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

        private void update_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tb_id.Text);
            string fname = textBox_fname.Text;
            string lname = tb_lastName.Text;
            string username = tb_userName.Text;
            string pw = textBox_password.Text;
            MemoryStream pic = new MemoryStream();

            pictureBox_userPic.Image.Save(pic, pictureBox_userPic.Image.RawFormat);

            if (this.verifyData(id, fname, lname, username, pw, pic))
            {
                if(us.updateUser(id, fname, lname, username, pw, pic))
                {
                    MessageBox.Show("Your info is updated", "modyfy data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Your info is not updated", "modyfi info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }else
            {
                MessageBox.Show("Your info must not empty", "modyfi info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
