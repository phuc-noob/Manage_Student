using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace check
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textPassword.Text == textConfirm.Text)
            {
                try
                {
                    string conStr;
                    SqlConnection con;
                    conStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Student;Integrated Security=True";
                    con = new SqlConnection(conStr);
                    con.Open();

                    //string save ="INSERT into Student (username,password)" +"VALUES ('"+textBox1.Text+"','"+textBox2.Text+"')";
                    SqlCommand cmd = new SqlCommand("INSERT INTO Login (username,password) VALUES (@username,@password)", con);
                    cmd.Parameters.Add("@username", texUsername.Text);
                    cmd.Parameters.Add("@password", textPassword.Text);
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        PhanVinhPhuc_19110434_MainForm fmain = new PhanVinhPhuc_19110434_MainForm();
                        this.Hide();
                        fmain.ShowDialog();
                        this.Close();
                    }

                    con.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR PASSWORD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Confirm Password incorrect ", "ERROR PASSWORD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("../../image/stduent.png");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fLogin form = new fLogin();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

    }
}
