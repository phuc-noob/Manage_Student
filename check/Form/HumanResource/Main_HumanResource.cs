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
    public partial class infoHumanResource : Form
    {
        public infoHumanResource()
        {
            InitializeComponent();
        }
        // move form when formborderstype is none
        user us = new user();
        Contact contact = new Contact();
        group g = new group();

        
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
        
        
        private void infoHumanResource_Load(object sender, EventArgs e)
        {
            
            this.getPictureAndUsername();
            DataTable dt = g.getAllGroup();
            if (dt.Rows.Count > 0)
            {
                comboBox_selectGroup.DataSource = dt;
                comboBox_selectGroup.ValueMember = "id";
                comboBox_selectGroup.DisplayMember = "name";

                comboBox_GremoveSelect.DataSource = dt;
                comboBox_GremoveSelect.ValueMember = "id";
                comboBox_GremoveSelect.DisplayMember = "name";
            }
        }
        
        public void getPictureAndUsername()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand();
            table = us.getUserById(Global.GlobalUserId);

            if(table.Rows.Count > 0)
            {
                byte[] pic = (byte[])table.Rows[0]["pic"];
                MemoryStream picture = new MemoryStream(pic);
                pictureBox_user.Image = Image.FromStream(picture);
                string test = table.Rows[0]["uname"].ToString().TrimEnd();
                label_uname.Text = string.Format("Welcome Back( {0} )",table.Rows[0]["uname"].ToString().TrimEnd());
                label_name.Text = string.Format("{0} {1}", table.Rows[0]["fname"].ToString().TrimEnd(), table.Rows[0]["lname"].ToString().TrimEnd());
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fLogin login = new fLogin();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void linkLabel_editinfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            editInfoUser euser = new editInfoUser();

            // fill data to form edit user
            DataTable dt = us.getUserById(Global.GlobalUserId);
            euser.id().Text = dt.Rows[0]["id"].ToString();
            euser.fname().Text = dt.Rows[0]["fname"].ToString();
            euser.lname().Text = dt.Rows[0]["lname"].ToString();
            euser.username().Text = dt.Rows[0]["uname"].ToString();
            euser.pw().Text = dt.Rows[0]["pwd"].ToString();

            byte[] pic = (byte[])dt.Rows[0]["pic"];
            MemoryStream picture = new MemoryStream(pic);
            euser.pic().Image = Image.FromStream(picture);

            // ---------end of fill data -------
            euser.Show();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            AddContact aContact = new AddContact();
            aContact.Show();
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            EditContact econtract = new EditContact();
            econtract.Show();
        }

        private void button_find_Click(object sender, EventArgs e)
        {

            selectContact select = new selectContact();
            this.Hide();
            select.ShowDialog();
            
            this.Close();
        }

        private void button_showFull_Click(object sender, EventArgs e)
        {
            ListContact lContact = new ListContact();
            lContact.Show();
        }

        private void button_removeContact_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are yousure you want to delete this Contact", "Remove Contact", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (contact.removeContactById(int.Parse(textBox_idContact.Text)))
                    {
                        this.infoHumanResource_Load(sender, e);
                        MessageBox.Show("Your Contact Deleted", "Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Your contact not deleted", "Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void button_gAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int uid = Global.GlobalUserId;
                int id = int.Parse(textBox_gId.Text);
                string name = textBox_gName.Text;
                if (g.insertGroup(id, name, uid))
                {
                    MessageBox.Show("Group is Added", "Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataTable dt = g.getAllGroup();
                    if (dt.Rows.Count > 0)
                    {
                        comboBox_selectGroup.DataSource = dt;
                        comboBox_selectGroup.ValueMember = "id";
                        comboBox_selectGroup.DisplayMember = "name";
                    }
                }
                else
                {
                    MessageBox.Show("Group is not Added", "Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                infoHumanResource_Load(sender, e);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void button_editG_Click(object sender, EventArgs e)
        {
            
            int id = int.Parse(comboBox_selectGroup.SelectedValue.ToString());
            string name = textBox_egName.Text;
            if (g.updateGroup(id, name))
            {
                
                MessageBox.Show("Group is updated", "Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                infoHumanResource_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Group is updated", "Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataTable dt = g.getAllGroup();
                infoHumanResource_Load(sender, e);
            }
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are yousure you want to delete this Course", "Remve Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = int.Parse(comboBox_GremoveSelect.SelectedValue.ToString());
                if (g.removeGroup(id))
                {
                    MessageBox.Show("Group is deleted", "Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    contact.removeContactByGid(id);
                    infoHumanResource_Load(sender,e);
                }
                else
                {
                    MessageBox.Show("Group is NOT deleted", "Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
                
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox_user_DoubleClick(object sender, EventArgs e)
        {
            this.infoHumanResource_Load(sender, e);
        }
    }
}
