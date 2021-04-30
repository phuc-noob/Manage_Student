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
    public partial class StaticResult : Form
    {
        public StaticResult()
        {
            InitializeComponent();
        }
        int locationY = 44;
        Score score = new Score();
        private void StaticResult_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = score.getAvgScoreByCourse();
            int countPass = 0;
            for(int i =0;i < dt.Rows.Count; i++)
            {
                Label lbl = new Label();
                lbl.Name = "lbl_Task";
                lbl.Text =string.Format("{0} : {1}", dt.Rows[i][0].ToString(),dt.Rows[i][1].ToString()) ;
                lbl.Top = locationY + 30;
                locationY += 30;
                lbl.Left = 40;
                lbl.Font = new Font("Arial", 10.25F, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                lbl.AutoSize = true;
                // set other properties
                this.Controls.Add(lbl);
            }
            ResultByAvgScore rScore = new ResultByAvgScore();
            DataTable dtResult = new DataTable();
            dtResult = rScore.getResultPass();

            label_pass.Text = string.Format("PASS : 100");
            label_pail.Text = string.Format("Fail : 00 ");
        }
    }
}
