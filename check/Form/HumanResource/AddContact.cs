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
    public partial class AddContact : Form
    {
        public AddContact()
        {
            InitializeComponent();
        }
        Contact contact = new Contact();
        group g = new group();

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

        private void AddContact_Load(object sender, EventArgs e)
        {
            DataTable dt = g.getGroupByIdUser(Global.GlobalUserId);
            
            comboBox_contact.DataSource = dt;
            comboBox_contact.DisplayMember = "name";
            comboBox_contact.ValueMember = "id";
            comboBox_contact.SelectedIndex = -1;
            comboBox_contact.Text = "";
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

        private void bt_Add_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(text_id.Text);
                string fName = text_fname.Text;
                string lName = textLname.Text;
                string phone = textPhone.Text;
                string address = textAddress.Text;
                string email = textBox_email.Text;
                int group_id =-1 ;
                if (comboBox_contact.SelectedIndex == -1)
                {
                    MessageBox.Show("ok");
                }
                else
                {
                    group_id = int.Parse(comboBox_contact.SelectedValue.ToString());
                }
                
                MemoryStream pic = new MemoryStream();
                pictureBox_contact.Image.Save(pic, pictureBox_contact.Image.RawFormat);
                int user_id = Global.GlobalUserId;
                if (contact.insertContact(id, user_id, fName, lName, phone, group_id ,email, address, pic) == true)
                {
                    MessageBox.Show("Add new contact success", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error To Add Contact", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                };


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //----------end of move form -------------
    }
}
