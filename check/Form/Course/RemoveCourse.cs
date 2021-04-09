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
    public partial class RemoveCourse : Form
    {
        public RemoveCourse()
        {
            InitializeComponent();
        }

        private void bt_Remove_Click(object sender, EventArgs e)
        {
            Course crs = new Course();
            int id = int.Parse(tb_ID.Text);
            if (crs.removeCourse(id))
            {
                MessageBox.Show("Course Deleted", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ERROR TO DELETE ", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
