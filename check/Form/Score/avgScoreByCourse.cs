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
    public partial class avgScoreByCourse : Form
    {
        public avgScoreByCourse()
        {
            InitializeComponent();
        }
        Score score = new Score();
        private void avgScoreByCourse_19110434_PhanVinhPhuc_Load(object sender, EventArgs e)
        {
            DataTable dt = score.getAvgScoreByCourse();
            dataGridView_Score.AutoResizeColumnHeadersHeight();

            dataGridView_Score.DataSource = dt;
            dataGridView_Score.ReadOnly = true;
            dataGridView_Score.AutoResizeRows();

            chart_avg.Series["Avg Score"].Points.AddXY("Data", 10);
            chart_avg.Series["Avg Score"].Points.AddXY("Winform", 5);
            chart_avg.Series["Avg Score"].Points.AddXY("Database", 8);
            chart_avg.Series["Avg Score"].Points.AddXY("AI", 10);
        }

        private void chart_avg_Click(object sender, EventArgs e)
        {

        }
    }
}
