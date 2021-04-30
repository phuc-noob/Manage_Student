namespace check
{
    partial class PrintCourse
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
            this.bt_print = new System.Windows.Forms.Button();
            this.button_SaveWord = new System.Windows.Forms.Button();
            this.dataGridView_Course = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Course)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_print
            // 
            this.bt_print.BackColor = System.Drawing.Color.SeaGreen;
            this.bt_print.Location = new System.Drawing.Point(189, 392);
            this.bt_print.Name = "bt_print";
            this.bt_print.Size = new System.Drawing.Size(117, 35);
            this.bt_print.TabIndex = 1;
            this.bt_print.Text = "Print";
            this.bt_print.UseVisualStyleBackColor = false;
            this.bt_print.Click += new System.EventHandler(this.bt_print_Click);
            // 
            // button_SaveWord
            // 
            this.button_SaveWord.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_SaveWord.Location = new System.Drawing.Point(12, 392);
            this.button_SaveWord.Name = "button_SaveWord";
            this.button_SaveWord.Size = new System.Drawing.Size(117, 35);
            this.button_SaveWord.TabIndex = 2;
            this.button_SaveWord.Text = "To File";
            this.button_SaveWord.UseVisualStyleBackColor = false;
            this.button_SaveWord.Click += new System.EventHandler(this.button_SaveWord_Click);
            // 
            // dataGridView_Course
            // 
            this.dataGridView_Course.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Course.Location = new System.Drawing.Point(8, 1);
            this.dataGridView_Course.MinimumSize = new System.Drawing.Size(100, 0);
            this.dataGridView_Course.Name = "dataGridView_Course";
            this.dataGridView_Course.RowHeadersWidth = 51;
            this.dataGridView_Course.RowTemplate.Height = 24;
            this.dataGridView_Course.Size = new System.Drawing.Size(606, 385);
            this.dataGridView_Course.TabIndex = 3;
            // 
            // PrintCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 450);
            this.Controls.Add(this.dataGridView_Course);
            this.Controls.Add(this.button_SaveWord);
            this.Controls.Add(this.bt_print);
            this.Name = "PrintCourse";
            this.Text = "19110434 Phan_Vĩnh_Phúc_PrintCourse";
            this.Load += new System.EventHandler(this.PrintCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Course)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bt_print;
        private System.Windows.Forms.Button button_SaveWord;
        private System.Windows.Forms.DataGridView dataGridView_Course;
    }
}