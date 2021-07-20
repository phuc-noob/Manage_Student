namespace check
{
    partial class ListCourseStudent
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
            this.dataGridView_listStudent = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_listStudent
            // 
            this.dataGridView_listStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_listStudent.Location = new System.Drawing.Point(9, 3);
            this.dataGridView_listStudent.Name = "dataGridView_listStudent";
            this.dataGridView_listStudent.RowHeadersWidth = 51;
            this.dataGridView_listStudent.RowTemplate.Height = 24;
            this.dataGridView_listStudent.Size = new System.Drawing.Size(997, 551);
            this.dataGridView_listStudent.TabIndex = 0;
            // 
            // ListCourseStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 566);
            this.Controls.Add(this.dataGridView_listStudent);
            this.Name = "ListCourseStudent";
            this.Text = "ListCourseStudent";
            this.Load += new System.EventHandler(this.ListCourseStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dataGridView_listStudent;
    }
}