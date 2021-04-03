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
    public partial class StudentList : Form
    {
        Student std = new Student();
        private object stdTableAdapter;

        public StudentList()
        {
            InitializeComponent();
        }

        

        private void StudentList_Load(object sender, EventArgs e)
        {

            MY_DB db = new MY_DB();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Std",db.getConnection);
            db.OpenConnection();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            db.closeConnection();
            dataGridView1.AutoResizeColumnHeadersHeight();
            dataGridView1.DataSource = dt;
            dataGridView1.ReadOnly = true;
            // image size
            
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.MinimumHeight = 100;
            dataGridView1.DataSource = dt;
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
            
        }

        private void dataGridView1_CancelRowEdit(object sender, QuestionEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
               
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            findStudent fStd = new findStudent();
            fStd.text_Id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            fStd.text_name.Text =dataGridView1.CurrentRow.Cells[1].Value.ToString();
            fStd.text_lname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            fStd.dtime = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;
            if (dataGridView1.CurrentRow.Cells[4].ToString() == "Female") {
                fStd.gender.Checked = true;
            }
            else
            {
                fStd.gender.Checked = false;
            }
            fStd.phone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            fStd.address.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            byte[] pic = (byte[])dataGridView1.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            fStd.StdImage.Image = Image.FromStream(picture);
            this.Hide();
            fStd.ShowDialog();
            this.Close();
        }
    }
}
