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
        MY_DB db = new MY_DB();
        
      

        private void Print_Load(object sender, EventArgs e)
        {
            
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
            dataGridView_Print.Columns[3].DefaultCellStyle.Format = "MM/dd/yyyy";
        }

        private void bt_check_Print_Click(object sender, EventArgs e)
        {
            Student std = new Student();
            SqlCommand cmd;
            string strGender;
            string strTime;

            if (rbFemaleStd.Checked == true)
            {
                strGender = "Female";
                //cmd = new SqlCommand("SELECT * FROM Std WHERE gender ='Female'");
            }
            else if (rbMaleStd.Checked == true)
            {
                strGender = "Male";
                //cmd = new SqlCommand("SELECT * FROM Std WHERE gender ='Male'");
            }
            else
            {
                strGender = "";
                //cmd = new SqlCommand("SELECT * FROM Std");
            }

            

            if (rb_Yes.Checked == true)
            {
                DateTime dMin = dtPicker_min.Value;
                DateTime dMax = dt_picker_Max.Value;

                if (strGender =="Male" ||strGender == "Female")
                {
                    cmd = new SqlCommand("SELECT * FROM Std WHERE gender = '"+ strGender + "' AND bdate >= '" + dMin + "' AND bdate <= '" + dMax + "'", db.getConnection);
                }
                else
                {
                    cmd = new SqlCommand("SELECT * FROM Std WHERE bdate >= '" + dMin + "' AND bdate <= '" + dMax + "'", db.getConnection);
                }
                
            }
            else
            {
                if (strGender.Contains("Male") || strGender.Contains("Female"))
                {
                    cmd = new SqlCommand("SELECT * FROM Std WHERE gender = '" + strGender + "'");
                }
                else
                {
                    cmd = new SqlCommand("SELECT * FROM Std");
                }
                   
               
            }

            dataGridView_Print.ReadOnly = false;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView_Print.RowTemplate.Height = 80;
            dataGridView_Print.DataSource = std.getStudent(cmd);
            picCol = (DataGridViewImageColumn)dataGridView_Print.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView_Print.AllowUserToAddRows = false;
            dataGridView_Print.Columns[3].DefaultCellStyle.Format = "MM/dd/yyyy";
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            PrintDialog pdialog = new PrintDialog();
            pdialog.ShowDialog();
        }
       
        
    }
}
