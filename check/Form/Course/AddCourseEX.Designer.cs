namespace check
{
    partial class AddCourseEX
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
            this.tb_stuId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_selected = new System.Windows.Forms.ListBox();
            this.listBox_avaiCourse = new System.Windows.Forms.ListBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.comboBox_semester = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tb_stuId
            // 
            this.tb_stuId.Location = new System.Drawing.Point(167, 34);
            this.tb_stuId.Multiline = true;
            this.tb_stuId.Name = "tb_stuId";
            this.tb_stuId.Size = new System.Drawing.Size(118, 29);
            this.tb_stuId.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(22, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 29);
            this.label4.TabIndex = 23;
            this.label4.Text = "Available Course";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(351, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 29);
            this.label3.TabIndex = 22;
            this.label3.Text = "Select Semester";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(21, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "Student ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(407, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "Selected Course";
            // 
            // listBox_selected
            // 
            this.listBox_selected.FormattingEnabled = true;
            this.listBox_selected.ItemHeight = 16;
            this.listBox_selected.Location = new System.Drawing.Point(412, 150);
            this.listBox_selected.Name = "listBox_selected";
            this.listBox_selected.Size = new System.Drawing.Size(210, 132);
            this.listBox_selected.TabIndex = 27;
            // 
            // listBox_avaiCourse
            // 
            this.listBox_avaiCourse.FormattingEnabled = true;
            this.listBox_avaiCourse.ItemHeight = 16;
            this.listBox_avaiCourse.Location = new System.Drawing.Point(27, 150);
            this.listBox_avaiCourse.Name = "listBox_avaiCourse";
            this.listBox_avaiCourse.Size = new System.Drawing.Size(206, 132);
            this.listBox_avaiCourse.TabIndex = 28;
            // 
            // button_Add
            // 
            this.button_Add.BackColor = System.Drawing.Color.Lime;
            this.button_Add.Location = new System.Drawing.Point(263, 167);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(120, 34);
            this.button_Add.TabIndex = 29;
            this.button_Add.Text = "ADD";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button_Save.Location = new System.Drawing.Point(263, 225);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(120, 34);
            this.button_Save.TabIndex = 30;
            this.button_Save.Text = "SAVE";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // comboBox_semester
            // 
            this.comboBox_semester.FormattingEnabled = true;
            this.comboBox_semester.Location = new System.Drawing.Point(563, 41);
            this.comboBox_semester.Name = "comboBox_semester";
            this.comboBox_semester.Size = new System.Drawing.Size(58, 24);
            this.comboBox_semester.TabIndex = 31;
            this.comboBox_semester.SelectedIndexChanged += new System.EventHandler(this.comboBox_semester_SelectedIndexChanged);
            // 
            // AddCourseEX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(649, 348);
            this.Controls.Add(this.comboBox_semester);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.listBox_avaiCourse);
            this.Controls.Add(this.listBox_selected);
            this.Controls.Add(this.tb_stuId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCourseEX";
            this.Text = "AddCourseEX - 19110434 Phan Vĩnh Phúc";
            this.Load += new System.EventHandler(this.AddCourseEX_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_stuId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_selected;
        private System.Windows.Forms.ListBox listBox_avaiCourse;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.ComboBox comboBox_semester;
    }
}