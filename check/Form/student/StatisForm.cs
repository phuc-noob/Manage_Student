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
    public partial class StatisForm : Form
    {
        double percentMale;
        public StatisForm()
        {
            InitializeComponent();
            Student std = new Student();
            
            int totalStd = std.getTotalStd();
            int totalMale = std.getTotalMale();
            int totalFMale = std.getTotalFemale();

            percentMale = ((totalMale*1.0) / (totalStd*1.0)) * 100;

            string sTotal = string.Format("Total :{0:00}", totalStd);
            string sPercentMale = string.Format("Male :{0:00.00} %",percentMale );
            string sPercentFemale = string.Format("Female :{0:00.00} %", 100-percentMale);
            label_Total.Text = sTotal;
            label_Female.Text = sPercentFemale;
            label_totalMale.Text = sPercentMale;
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void StatisForm_Load(object sender, EventArgs e)
        {
            chart_sexualStudent.Titles.Add("Percent Male/Female Student");
            chart_sexualStudent.Series["student"].Points.AddXY("Male", percentMale);
            chart_sexualStudent.Series["student"].Points.AddXY("Female",100-percentMale );
        }

        private void chart_sexualStudent_Click(object sender, EventArgs e)
        {

        }
    }
}
