using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace check
{
    public partial class selectContact : Form
    {
        public selectContact()
        {
            InitializeComponent();
        }
        Contact contact = new Contact();
        public int numEdit { get; set; }

        private void selectContact_Load(object sender, EventArgs e)
        {
            dataGridView_contact.DataSource = contact.getAllContact();
            dataGridView_contact.Columns[0].HeaderText ="ID";
            dataGridView_contact.Columns[0].Width = 50;
            dataGridView_contact.Columns[1].HeaderText = "First Name";
            dataGridView_contact.Columns[2].HeaderText = "Last Name";
            dataGridView_contact.Columns[3].HeaderText = "Group ID";
            dataGridView_contact.Columns[4].HeaderText = "Phone";
            dataGridView_contact.Columns[5].HeaderText = "Email";
            dataGridView_contact.Columns[6].HeaderText = "Address";
            dataGridView_contact.Columns[7].HeaderText = "Picture";
            dataGridView_contact.Columns[8].HeaderText = "User Id";

            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView_contact.RowTemplate.MinimumHeight = 80;
            
            picCol = (DataGridViewImageColumn)dataGridView_contact.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView_contact.AllowUserToAddRows = false;

            
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

        private void button_cancer_Click(object sender, EventArgs e)
        {
            this.Close();
            if(this.numEdit == 1)
            {

            }
            else
            {
                infoHumanResource human = new infoHumanResource();
                this.Hide();
                human.ShowDialog();
                this.Close();
            }
        }

        private void dataGridView_contact_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        
        private void dataGridView_contact_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(dataGridView_contact.CurrentRow.Cells[0].Value.ToString());
            if(this.numEdit == 1)
            {
                group g = new group();
                EditContact edit = new EditContact();
                int g_id = int.Parse(contact.getContactById(id).Rows[0]["group_id"].ToString());
                
                edit.fill(id);
                //edit.comboBox_contact.SelectedIndex = -1;
                //edit.comboBox_contact. = g.getGroupbyGid(g_id).Rows[0]["name"].ToString();
                
                edit.comboBox_contact.SelectedValue = g_id;
                
                edit.Show();
                edit.comboBox_contact.Text = g.getGroupbyGid(g_id).Rows[0]["name"].ToString();
            }
            else
            {
                infoHumanResource human = new infoHumanResource();
                Hide();
                human.textBox_idContact.Text = int.Parse(dataGridView_contact.CurrentRow.Cells[0].Value.ToString()).ToString();
                human.ShowDialog();
                this.Close();
            }
            
            this.Close();
        }

        
        //----------end of move form -------------
    }
}
