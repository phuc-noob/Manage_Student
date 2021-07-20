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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

       
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(textPassword, "enter correct password");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand cmd;
            if (radioButton_student.Checked == true)
            {
                cmd = new SqlCommand("SELECT * FROM Login WHERE username =@user AND password =@ps", db.getConnection);
            }
            else
            {
                cmd = new SqlCommand("SELECT * FROM HR WHERE uname =@user AND pwd =@ps", db.getConnection);
            }
            cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = textBoxUsername.Text;
            cmd.Parameters.Add("@ps", SqlDbType.VarChar).Value = textPassword.Text;
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            try
            {
                if (table.Rows.Count > 0)
                {
                    if(radioButton_student.Checked == true)
                    {
                        // set Global id for user when login success
                        

                        PhanVinhPhuc_19110434_MainForm fMain = new PhanVinhPhuc_19110434_MainForm();
                        this.Hide();
                        fMain.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        Global.SetGlobalUserId(int.Parse(table.Rows[0]["id"].ToString()));
                        infoHumanResource infoHr = new infoHumanResource();
                        this.Hide();
                        infoHr.ShowDialog();
                        this.Close();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Error To Login ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error To Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    pictureBox1.Image = Image.FromFile("../../image/mylove.jpg");
        //}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Register regis = new Register();
            this.Hide();
            regis.ShowDialog();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBoxUsername,"enter userName");

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void textBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip2.SetToolTip(textPassword, "enter password");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void link_registerUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registerUser ruser = new registerUser();
            this.Hide();
            ruser.ShowDialog();
            this.Close();
        }
    }
}
