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
    public partial class Print : Form
    {
        public Print()
        {
            InitializeComponent();
        }

        private void dataGridView_Print_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView_Print_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Print_Load(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Std", db.getConnection);
            db.OpenConnection();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            db.closeConnection();
            dataGridView_Print.AutoResizeColumnHeadersHeight();
            dataGridView_Print.DataSource = dt;
            dataGridView_Print.ReadOnly = true;
            // image size

            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            //dataGridView_Print.RowTemplate.MinimumHeight = 500;
            dataGridView_Print.DataSource = dt;
            picCol = (DataGridViewImageColumn)dataGridView_Print.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView_Print.AllowUserToAddRows = false;
            
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            Student std = new Student();
            SqlCommand cmd;
            if (rbFemaleStd.Checked == true)
            {
                cmd = new SqlCommand("SELECT * FROM Std WHERE gender ='Female'");
            }else if(rbMaleStd.Checked == true)
            {
                cmd = new SqlCommand("SELECT * FROM Std WHERE gender ='Male'");
            }
            else
            {
                cmd = new SqlCommand("SELECT * FROM Std");
            }
            dataGridView_Print.ReadOnly = false;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView_Print.RowTemplate.Height = 80;
            dataGridView_Print.DataSource = std.getStudent(cmd);
            picCol = (DataGridViewImageColumn)dataGridView_Print.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView_Print.AllowUserToAddRows = false;

            if (radioButton4.Checked == true)
            {
                DateTime dMin = dtPicker_min.Value;
                DateTime dMax = dateTimePicker2.Value;
                DataTable temp = std.getStudent(cmd);
                DataRow[] run = temp.Select("bdate >= '" + dMin + "' AND bdate <= '" + dMax + "'");
                dataGridView_Print.ReadOnly = false;
                picCol = new DataGridViewImageColumn();
                dataGridView_Print.RowTemplate.Height = 80;
                dataGridView_Print.DataSource = run;
                picCol = (DataGridViewImageColumn)dataGridView_Print.Columns[7];
                picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                dataGridView_Print.AllowUserToAddRows = false;
                /*
                DateTime dMin = dtPicker_min.Value;
                DateTime dMax = dateTimePicker2.Value;
                cmd = new SqlCommand("SELECT * FROM '"+std.getStudent(cmd)+"' WHERE bdate >= '" + dMin + "' AND bdate <= '" + dMax + "'");
                dataGridView_Print.ReadOnly = false;
                picCol = new DataGridViewImageColumn();
                dataGridView_Print.RowTemplate.Height = 80;
                dataGridView_Print.DataSource = std.getStudent(cmd);
                picCol = (DataGridViewImageColumn)dataGridView_Print.Columns[7];
                picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                dataGridView_Print.AllowUserToAddRows = false;*/
            }
            else
            {
                
                /*
                MY_DB db = new MY_DB();
                cmd = new SqlCommand("SELECT * FROM Std", db.getConnection);
                db.OpenConnection();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                db.closeConnection();
                dataGridView_Print.AutoResizeColumnHeadersHeight();
                dataGridView_Print.DataSource = dt;
                dataGridView_Print.ReadOnly = true;
                // image size

                picCol = new DataGridViewImageColumn();
                //dataGridView_Print.RowTemplate.MinimumHeight = 500;
                dataGridView_Print.DataSource = dt;
                picCol = (DataGridViewImageColumn)dataGridView_Print.Columns[7];
                picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                dataGridView_Print.AllowUserToAddRows = false;
                */
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PrintDialog pdialog = new PrintDialog();
            pdialog.ShowDialog();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {


        }
        private void rb_AllStd_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void dataGridView_Print_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView_Print_CellContentClick_3(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void rbFemaleStd_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
