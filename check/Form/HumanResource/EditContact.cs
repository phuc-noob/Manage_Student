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
    public partial class EditContact : Form
    {
        public EditContact()
        {
            InitializeComponent();
        }
        Contact contact = new Contact();
        group g = new group();
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
        private void button_find_Click(object sender, EventArgs e)
        {

            selectContact select = new selectContact();
            select.numEdit = 1;
            select.Show();
            this.Close();
            
            
        }

        public void fill(int id)
        {
            try
            {
                DataTable dt = contact.getContactById(id);
                if (dt.Rows.Count > 0)
                {
                    text_id.Text = id.ToString();
                    text_fname.Text = dt.Rows[0]["fname"].ToString();
                    textLname.Text = dt.Rows[0]["lname"].ToString();
                    textBox_email.Text = dt.Rows[0]["email"].ToString();
                    textPhone.Text = dt.Rows[0]["phone"].ToString();
                    textAddress.Text = dt.Rows[0]["address"].ToString();

                    //comboBox_contact.Text = dt.Rows[0]["group_id"].ToString();
                    byte[] pic = (byte[])dt.Rows[0]["pic"];
                    MemoryStream picture = new MemoryStream(pic);
                    pictureBox_contact.Image = Image.FromStream(picture);

                }
                else
                {
                    MessageBox.Show("Your Contact not found", "notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "USER", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_cancer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_upload_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBox_contact.Image = Image.FromFile(opf.FileName);
            }
        }

        private void EditContact_Load(object sender, EventArgs e)
        {
            DataTable dt = g.getGroupByIdUser(Global.GlobalUserId);
            
            comboBox_contact.DataSource = dt;
            comboBox_contact.DisplayMember = "name";
            comboBox_contact.ValueMember = "id";
            
        }

        private void bt_upload_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(text_id.Text);
                string fName = text_fname.Text;
                string lName = textLname.Text;
                string phone = textPhone.Text;
                string address = textAddress.Text;
                string email = textBox_email.Text;
                int group = int.Parse(comboBox_contact.SelectedValue.ToString());
                MemoryStream pic = new MemoryStream();
                pictureBox_contact.Image.Save(pic, pictureBox_contact.Image.RawFormat);
                int user_id = Global.GlobalUserId;
                if (contact.updateContact(id, user_id, fName, lName, phone, group, email, address, pic) == true)
                {
                    MessageBox.Show("Your info is uploaded", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Your info is not uploaded", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                };


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
