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
    public partial class StaticStudentScore : Form
    {
        public StaticStudentScore()
        {
            InitializeComponent();
        }

        private void StaticStudentScore_Load(object sender, EventArgs e)
        {
            chart_count.Titles.Add("Amount Level Student Score");
            foreach(KeyValuePair<string,int> i in Global.level)
            {
                if(i.Value == 0)
                {
                    
                }
                else
                {
                    chart_percent.Series["percent"].Points.AddXY(i.Key, i.Value);
                }
                chart_count.Series["Amount"].Points.AddXY(i.Key,i.Value);
                
            }

            chart_percent.Titles.Add("Percent Level Of Student");
            
        }
    }
}
