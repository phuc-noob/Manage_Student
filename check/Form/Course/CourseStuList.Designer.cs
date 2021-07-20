namespace check
{
    partial class CourseStuList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_cName = new System.Windows.Forms.TextBox();
            this.label_semester = new System.Windows.Forms.Label();
            this.dataGridView_lStudent = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_lStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course Name";
            // 
            // textBox_cName
            // 
            this.textBox_cName.Location = new System.Drawing.Point(191, 34);
            this.textBox_cName.Name = "textBox_cName";
            this.textBox_cName.Size = new System.Drawing.Size(129, 22);
            this.textBox_cName.TabIndex = 1;
            // 
            // label_semester
            // 
            this.label_semester.AutoSize = true;
            this.label_semester.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_semester.Location = new System.Drawing.Point(367, 34);
            this.label_semester.Name = "label_semester";
            this.label_semester.Size = new System.Drawing.Size(101, 20);
            this.label_semester.TabIndex = 2;
            this.label_semester.Text = "Semester :";
            // 
            // dataGridView_lStudent
            // 
            this.dataGridView_lStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_lStudent.Location = new System.Drawing.Point(10, 82);
            this.dataGridView_lStudent.Name = "dataGridView_lStudent";
            this.dataGridView_lStudent.RowHeadersWidth = 51;
            this.dataGridView_lStudent.RowTemplate.Height = 24;
            this.dataGridView_lStudent.Size = new System.Drawing.Size(738, 390);
            this.dataGridView_lStudent.TabIndex = 3;
            // 
            // CourseStuList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 481);
            this.Controls.Add(this.dataGridView_lStudent);
            this.Controls.Add(this.label_semester);
            this.Controls.Add(this.textBox_cName);
            this.Controls.Add(this.label1);
            this.Name = "CourseStuList";
            this.Text = "Course Student List 19110434 Phan Vĩnh Phúc";
            this.Load += new System.EventHandler(this.CourseStuList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_lStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_cName;
        private System.Windows.Forms.Label label_semester;
        private System.Windows.Forms.DataGridView dataGridView_lStudent;
    }
}