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
            DataTable dt = new DataTable();
            dt = score.getAvgScoreByCourse();
            dataGridView_Score.AutoResizeColumnHeadersHeight();
            
            
            

            dataGridView_Score.DataSource = dt;
            dataGridView_Score.Columns[1].CellTemplate.Style.Format = string.Format("00:00.00");
            dataGridView_Score.ReadOnly = true;
            dataGridView_Score.AutoResizeRows();

            dataGridView_Score.Columns[0].Width = 170;
            dataGridView_Score.Columns[1].Width = 120;
            dataGridView_Score.Columns[0].HeaderText = "Label";
            dataGridView_Score.Columns[1].HeaderText = "Average Score";

            chart_avg.Titles.Add("Average Course Score");
            for (int i =0;i < dt.Rows.Count; i++)
            {
                chart_avg.Series["Avg Score"].Points.AddXY(dt.Rows[i]["label"].ToString(), dt.Rows[i]["AverageGrade"].ToString());
            }

            for(int i=0;i < dt.Rows.Count; i++)
            {
                if(dt.Rows[i][1].ToString().Length >4)
                {
                    dt.Rows[i][1] = Math.Round(double.Parse(dt.Rows[i][1].ToString()), 2);
                }
            }
        }

        private void chart_avg_Click(object sender, EventArgs e)
        {

        }
    }
}
