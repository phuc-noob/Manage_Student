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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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

            SqlCommand cmd = new SqlCommand("SELECT * FROM Login WHERE username =@user AND password =@ps",db.getConnection);
            cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = textBoxUsername.Text;
            cmd.Parameters.Add("@ps", SqlDbType.VarChar).Value = textPassword.Text;

            adapter.SelectCommand = cmd;
            adapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                MainForm fMain = new MainForm();
                this.Hide();
                fMain.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("login again","Login fail",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("../../image/mylove.jpg");
        }

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
    }
}
