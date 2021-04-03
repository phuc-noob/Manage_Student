namespace check
{
    partial class ManageStudentForm
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
            this.bt_Add = new System.Windows.Forms.Button();
            this.bt_remove = new System.Windows.Forms.Button();
            this.bt_upload_Image = new System.Windows.Forms.Button();
            this.pic_box_Std = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.dt_picker_student = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.textLname = new System.Windows.Forms.TextBox();
            this.textFname = new System.Windows.Forms.TextBox();
            this.textId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dt_gridview_mangeStudent = new System.Windows.Forms.DataGridView();
            this.bt_reset = new System.Windows.Forms.Button();
            this.bt_edit = new System.Windows.Forms.Button();
            this.bt_total_student = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bt_Search = new System.Windows.Forms.Button();
            this.bt_download_image = new System.Windows.Forms.Button();
            this.bt_Find = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_box_Std)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_gridview_mangeStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Add
            // 
            this.bt_Add.BackColor = System.Drawing.Color.RoyalBlue;
            this.bt_Add.Location = new System.Drawing.Point(51, 599);
            this.bt_Add.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(123, 38);
            this.bt_Add.TabIndex = 39;
            this.bt_Add.Text = "Add";
            this.bt_Add.UseVisualStyleBackColor = false;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // bt_remove
            // 
            this.bt_remove.BackColor = System.Drawing.Color.Brown;
            this.bt_remove.ForeColor = System.Drawing.SystemColors.InfoText;
            this.bt_remove.Location = new System.Drawing.Point(385, 599);
            this.bt_remove.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bt_remove.Name = "bt_remove";
            this.bt_remove.Size = new System.Drawing.Size(122, 38);
            this.bt_remove.TabIndex = 38;
            this.bt_remove.Text = "Remove";
            this.bt_remove.UseVisualStyleBackColor = false;
            this.bt_remove.Click += new System.EventHandler(this.bt_remove_Click);
            // 
            // bt_upload_Image
            // 
            this.bt_upload_Image.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_upload_Image.Location = new System.Drawing.Point(232, 491);
            this.bt_upload_Image.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bt_upload_Image.Name = "bt_upload_Image";
            this.bt_upload_Image.Size = new System.Drawing.Size(105, 32);
            this.bt_upload_Image.TabIndex = 37;
            this.bt_upload_Image.Text = "upload";
            this.bt_upload_Image.UseVisualStyleBackColor = true;
            this.bt_upload_Image.Click += new System.EventHandler(this.bt_upload_Image_Click);
            // 
            // pic_box_Std
            // 
            this.pic_box_Std.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pic_box_Std.BackColor = System.Drawing.Color.Orchid;
            this.pic_box_Std.Location = new System.Drawing.Point(125, 345);
            this.pic_box_Std.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pic_box_Std.Name = "pic_box_Std";
            this.pic_box_Std.Size = new System.Drawing.Size(212, 140);
            this.pic_box_Std.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_box_Std.TabIndex = 36;
            this.pic_box_Std.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 345);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 35;
            this.label8.Text = "Picture";
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(125, 262);
            this.textAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textAddress.Multiline = true;
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(211, 62);
            this.textAddress.TabIndex = 34;
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(126, 220);
            this.textPhone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(209, 22);
            this.textPhone.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 262);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 32;
            this.label7.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 220);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 178);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Gender";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(232, 176);
            this.rbFemale.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(81, 21);
            this.rbFemale.TabIndex = 29;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(126, 178);
            this.rbMale.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(63, 21);
            this.rbMale.TabIndex = 28;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            this.rbMale.CheckedChanged += new System.EventHandler(this.rbMale_CheckedChanged);
            // 
            // dt_picker_student
            // 
            this.dt_picker_student.CalendarMonthBackground = System.Drawing.Color.Yellow;
            this.dt_picker_student.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_picker_student.Location = new System.Drawing.Point(126, 135);
            this.dt_picker_student.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dt_picker_student.Name = "dt_picker_student";
            this.dt_picker_student.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dt_picker_student.Size = new System.Drawing.Size(210, 22);
            this.dt_picker_student.TabIndex = 27;
            this.dt_picker_student.Value = new System.DateTime(2021, 3, 18, 10, 7, 40, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "BirthDate";
            // 
            // textLname
            // 
            this.textLname.Location = new System.Drawing.Point(125, 95);
            this.textLname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textLname.Name = "textLname";
            this.textLname.Size = new System.Drawing.Size(210, 22);
            this.textLname.TabIndex = 25;
            // 
            // textFname
            // 
            this.textFname.Location = new System.Drawing.Point(125, 55);
            this.textFname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textFname.Name = "textFname";
            this.textFname.Size = new System.Drawing.Size(210, 22);
            this.textFname.TabIndex = 24;
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(125, 21);
            this.textId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(102, 22);
            this.textId.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "ID";
            // 
            // dt_gridview_mangeStudent
            // 
            this.dt_gridview_mangeStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_gridview_mangeStudent.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dt_gridview_mangeStudent.ColumnHeadersHeight = 29;
            this.dt_gridview_mangeStudent.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dt_gridview_mangeStudent.Location = new System.Drawing.Point(367, 55);
            this.dt_gridview_mangeStudent.Name = "dt_gridview_mangeStudent";
            this.dt_gridview_mangeStudent.RowHeadersWidth = 51;
            this.dt_gridview_mangeStudent.RowTemplate.Height = 80;
            this.dt_gridview_mangeStudent.Size = new System.Drawing.Size(704, 468);
            this.dt_gridview_mangeStudent.TabIndex = 40;
            this.dt_gridview_mangeStudent.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_gridview_mangeStudent_CellDoubleClick);
            // 
            // bt_reset
            // 
            this.bt_reset.BackColor = System.Drawing.Color.RoyalBlue;
            this.bt_reset.Location = new System.Drawing.Point(541, 599);
            this.bt_reset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(123, 38);
            this.bt_reset.TabIndex = 41;
            this.bt_reset.Text = "Reset";
            this.bt_reset.UseVisualStyleBackColor = false;
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click);
            // 
            // bt_edit
            // 
            this.bt_edit.BackColor = System.Drawing.Color.DeepPink;
            this.bt_edit.Location = new System.Drawing.Point(214, 599);
            this.bt_edit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(123, 38);
            this.bt_edit.TabIndex = 42;
            this.bt_edit.Text = "Edit";
            this.bt_edit.UseVisualStyleBackColor = false;
            this.bt_edit.Click += new System.EventHandler(this.bt_edit_Click);
            // 
            // bt_total_student
            // 
            this.bt_total_student.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_total_student.Location = new System.Drawing.Point(777, 538);
            this.bt_total_student.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bt_total_student.Name = "bt_total_student";
            this.bt_total_student.Size = new System.Drawing.Size(226, 38);
            this.bt_total_student.TabIndex = 43;
            this.bt_total_student.Text = "Total Student";
            this.bt_total_student.UseVisualStyleBackColor = false;
            this.bt_total_student.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(682, 15);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 22);
            this.textBox1.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(420, 18);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(239, 17);
            this.label9.TabIndex = 45;
            this.label9.Text = "Search Fname, Lname, Address";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // bt_Search
            // 
            this.bt_Search.BackColor = System.Drawing.Color.DarkCyan;
            this.bt_Search.Location = new System.Drawing.Point(934, 12);
            this.bt_Search.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bt_Search.Name = "bt_Search";
            this.bt_Search.Size = new System.Drawing.Size(137, 28);
            this.bt_Search.TabIndex = 46;
            this.bt_Search.Text = "Search";
            this.bt_Search.UseVisualStyleBackColor = false;
            // 
            // bt_download_image
            // 
            this.bt_download_image.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_download_image.Location = new System.Drawing.Point(125, 491);
            this.bt_download_image.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bt_download_image.Name = "bt_download_image";
            this.bt_download_image.Size = new System.Drawing.Size(102, 32);
            this.bt_download_image.TabIndex = 47;
            this.bt_download_image.Text = "Download";
            this.bt_download_image.UseVisualStyleBackColor = true;
            this.bt_download_image.Click += new System.EventHandler(this.button5_Click);
            // 
            // bt_Find
            // 
            this.bt_Find.BackColor = System.Drawing.Color.RoyalBlue;
            this.bt_Find.Location = new System.Drawing.Point(250, 18);
            this.bt_Find.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bt_Find.Name = "bt_Find";
            this.bt_Find.Size = new System.Drawing.Size(85, 28);
            this.bt_Find.TabIndex = 48;
            this.bt_Find.Text = "Find";
            this.bt_Find.UseVisualStyleBackColor = false;
            // 
            // ManageStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1125, 679);
            this.Controls.Add(this.bt_Find);
            this.Controls.Add(this.bt_download_image);
            this.Controls.Add(this.bt_Search);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bt_total_student);
            this.Controls.Add(this.bt_edit);
            this.Controls.Add(this.bt_reset);
            this.Controls.Add(this.dt_gridview_mangeStudent);
            this.Controls.Add(this.bt_Add);
            this.Controls.Add(this.bt_remove);
            this.Controls.Add(this.bt_upload_Image);
            this.Controls.Add(this.pic_box_Std);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.dt_picker_student);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textLname);
            this.Controls.Add(this.textFname);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "ManageStudentForm";
            this.Text = "ManageStudentForm";
            this.Load += new System.EventHandler(this.ManageStudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_box_Std)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_gridview_mangeStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.Button bt_remove;
        private System.Windows.Forms.Button bt_upload_Image;
        private System.Windows.Forms.PictureBox pic_box_Std;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.DateTimePicker dt_picker_student;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textLname;
        private System.Windows.Forms.TextBox textFname;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dt_gridview_mangeStudent;
        private System.Windows.Forms.Button bt_reset;
        private System.Windows.Forms.Button bt_edit;
        private System.Windows.Forms.Button bt_total_student;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bt_Search;
        private System.Windows.Forms.Button bt_download_image;
        private System.Windows.Forms.Button bt_Find;
    }
}