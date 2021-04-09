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
    public partial class PhanVinhPhuc_19110434_MainForm : Form
    {
        public PhanVinhPhuc_19110434_MainForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void aDDSTUDENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            infoStudent ifStu = new infoStudent();
            //this.Hide();
            ifStu.Show();
            //this.Close();
        }

        private void lISTSTUDENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentList lStudent = new StudentList();
            //this.Hide();
            lStudent.Show();
            //this.Close();
        }

        private void sTATICSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatisForm fSta = new StatisForm();
            fSta.Show();
        }

        private void pRINTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Print fPrint = new Print();
            fPrint.ShowDialog();
        }

        private void eDITREMOVEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            findStudent updateStd = new findStudent();
            updateStd.Show();
        }

        private void mANAGESTUDENTFORMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageStudentForm fManage = new ManageStudentForm();
            fManage.Show();
        }

        private void toolTrip_AddCourse_Click(object sender, EventArgs e)
        {
            AddCourse addC = new AddCourse();
            addC.Show();
        }

        private void toolTrip_removeCourse_Click(object sender, EventArgs e)
        {
            RemoveCourse rCourse = new RemoveCourse();
            rCourse.Show();
        }

        private void toolTripEdit_Click(object sender, EventArgs e)
        {
            EditCourse ed = new EditCourse();
            ed.Show();
        }
    }
}
