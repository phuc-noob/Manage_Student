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
        public StatisForm()
        {
            InitializeComponent();
            Student std = new Student();
            
            int totalStd = std.getTotalStd();
            int totalMale = std.getTotalMale();
            int totalFMale = std.getTotalFemale();
            string sTotal = string.Format("Total :{0}", totalStd);
            string sPercentMale = string.Format("Male :{0} %", (totalMale*1.0/totalStd)*100);
            string sPercentFemale = string.Format("Female :{0} %", (totalFMale*1.0/totalStd)*100);
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

        }
    }
}
