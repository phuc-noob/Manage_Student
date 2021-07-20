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
    public partial class ListContact : Form
    {
        public ListContact()
        {
            InitializeComponent();
        }
        Contact contact = new Contact();
        group g = new group();
        private void button_cancer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
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
        private void ListContact_Load(object sender, EventArgs e)
        {
            listBox_listContact.DataSource = g.getGroupByIdUser(Global.GlobalUserId);
            listBox_listContact.ValueMember = "id";                          // index get by id
            listBox_listContact.DisplayMember = "name";                    // show name of course
            listBox_listContact.SelectedItem = null;

            dataGridView_contact.DataSource = contact.getAllContact();
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView_contact.RowTemplate.MinimumHeight = 80;
            picCol = (DataGridViewImageColumn)dataGridView_contact.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView_contact.AllowUserToAddRows = false;

            dataGridView_contact.Columns[0].HeaderText = "ID";
            dataGridView_contact.Columns[0].Width = 50;
            dataGridView_contact.Columns[1].HeaderText = "First Name";
            dataGridView_contact.Columns[2].HeaderText = "Last Name";
            dataGridView_contact.Columns[3].HeaderText = "Group ID";
            dataGridView_contact.Columns[4].HeaderText = "Phone";
            dataGridView_contact.Columns[5].HeaderText = "Email";
            dataGridView_contact.Columns[6].HeaderText = "Address";
            dataGridView_contact.Columns[7].HeaderText = "Picture";
            dataGridView_contact.Columns[8].HeaderText = "User Id";


        }

        private void listBox_listContact_Click(object sender, EventArgs e)
        {
            try
            {
                int gname;
                if (listBox_listContact.SelectedIndex.ToString() == "")
                {
                    ListContact_Load(sender, e);
                }
                else
                {
                    gname = int.Parse(listBox_listContact.SelectedValue.ToString());
                    DataTable dt = contact.getContactByGroupId(gname);
                    dataGridView_contact.DataSource = dt;

                    DataGridViewImageColumn picCol = new DataGridViewImageColumn();
                    dataGridView_contact.RowTemplate.MinimumHeight = 80;
                    picCol = (DataGridViewImageColumn)dataGridView_contact.Columns[7];
                    picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                    dataGridView_contact.AllowUserToAddRows = false;
                }
                
            }
            catch (Exception ex)
            {


            }
        }

        private void listBox_listContact_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void dataGridView_contact_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id =int.Parse(dataGridView_contact.CurrentRow.Cells[0].Value.ToString());
            ListCourseStudent std = new ListCourseStudent();
            std.dataGridView_listStudent.DataSource = contact.getStudentByTid(id);
            std.dataGridView_listStudent.Columns["sid"].HeaderText = "Student ID";
            std.dataGridView_listStudent.Columns[1].HeaderText = "First Name";
            std.dataGridView_listStudent.Columns[2].HeaderText = "Last Name";
            std.dataGridView_listStudent.Columns[3].HeaderText = "Gender";
            std.dataGridView_listStudent.Columns[4].HeaderText = "Birth Date";
            std.dataGridView_listStudent.Columns[5].HeaderText = "Phone ";
            std.dataGridView_listStudent.Columns[6].HeaderText = "Course ID";
            std.dataGridView_listStudent.Columns[7].HeaderText = "Label";
            std.dataGridView_listStudent.Columns[4].DefaultCellStyle.Format = "MM/dd/yyyy";
            std.Show();
        }

        private void button_all_Click(object sender, EventArgs e)
        {
            ListContact_Load(sender, e);
        }
    }
}
