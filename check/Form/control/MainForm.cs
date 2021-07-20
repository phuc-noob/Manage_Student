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

        private void toolTripManageCourse_Click(object sender, EventArgs e)
        {
            manageCourse mCourse = new manageCourse();
            mCourse.Show();
        }

        private void toolTripAddScore_Click(object sender, EventArgs e)
        {
            AddScoreForm aScore = new AddScoreForm();
            aScore.Show();
        }

        private void toolTripPrintCourse_Click(object sender, EventArgs e)
        {
            PrintCourse pCourse = new PrintCourse();
            pCourse.Show();
        }

        private void toolTrip_RemoveScore_Click(object sender, EventArgs e)
        {
            RemoveScore reScore = new RemoveScore();
            reScore.Show();
        }

        private void toolTripMangeScore_Click(object sender, EventArgs e)
        {
            ManageScore mScore = new ManageScore();
            mScore.Show();
        }

        private void toolTrip_avgScore_Click(object sender, EventArgs e)
        {
            avgScoreByCourse avg = new avgScoreByCourse();
            avg.Show();
        }

        private void toolTrip_print_Click(object sender, EventArgs e)
        {
            PrintScore pScore = new PrintScore();
            pScore.Show();
        }

        private void toolTrip_avgResult_Click(object sender, EventArgs e)
        {
            ResultByAvgScore result = new ResultByAvgScore();
            result.Show();
        }

        private void sTATICRESULTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticResult sResult = new StaticResult();
            sResult.Show();
        }

        private void PhanVinhPhuc_19110434_MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void PhanVinhPhuc_19110434_MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            fLogin login = new fLogin();
            login.ShowDialog();
            this.Close();
        }
    }
}
