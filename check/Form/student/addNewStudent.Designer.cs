namespace check
{
    partial class infoStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(infoStudent));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.textFname = new System.Windows.Forms.TextBox();
            this.textLname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_upload_image = new System.Windows.Forms.Button();
            this.bt_cancer = new System.Windows.Forms.Button();
            this.bt_Add_student = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(173, 15);
            this.textId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(247, 28);
            this.textId.TabIndex = 3;
            this.textId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textFname
            // 
            this.textFname.Location = new System.Drawing.Point(173, 63);
            this.textFname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textFname.Name = "textFname";
            this.textFname.Size = new System.Drawing.Size(247, 28);
            this.textFname.TabIndex = 4;
            // 
            // textLname
            // 
            this.textLname.Location = new System.Drawing.Point(175, 112);
            this.textLname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textLname.Name = "textLname";
            this.textLname.Size = new System.Drawing.Size(247, 28);
            this.textLname.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "BirthDate";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Yellow;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(173, 164);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.Size = new System.Drawing.Size(247, 28);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.Value = new System.DateTime(2021, 3, 18, 10, 7, 40, 0);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(173, 217);
            this.rbMale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(76, 28);
            this.rbMale.TabIndex = 8;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(289, 217);
            this.rbFemale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(101, 28);
            this.rbFemale.TabIndex = 9;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 217);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 262);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 313);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Address";
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(175, 262);
            this.textPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(247, 28);
            this.textPhone.TabIndex = 13;
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(175, 313);
            this.textAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textAddress.Multiline = true;
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(247, 90);
            this.textAddress.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 417);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "Picture";
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Orchid;
            this.pictureBox1.Location = new System.Drawing.Point(172, 417);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // bt_upload_image
            // 
            this.bt_upload_image.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_upload_image.Location = new System.Drawing.Point(170, 575);
            this.bt_upload_image.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_upload_image.Name = "bt_upload_image";
            this.bt_upload_image.Size = new System.Drawing.Size(248, 39);
            this.bt_upload_image.TabIndex = 17;
            this.bt_upload_image.Text = "upload image";
            this.bt_upload_image.UseVisualStyleBackColor = true;
            this.bt_upload_image.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_cancer
            // 
            this.bt_cancer.BackColor = System.Drawing.Color.Brown;
            this.bt_cancer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_cancer.Location = new System.Drawing.Point(60, 636);
            this.bt_cancer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_cancer.Name = "bt_cancer";
            this.bt_cancer.Size = new System.Drawing.Size(126, 47);
            this.bt_cancer.TabIndex = 18;
            this.bt_cancer.Text = "Cancer";
            this.bt_cancer.UseVisualStyleBackColor = false;
            this.bt_cancer.Click += new System.EventHandler(this.bt_cancer_Click);
            // 
            // bt_Add_student
            // 
            this.bt_Add_student.BackColor = System.Drawing.Color.RoyalBlue;
            this.bt_Add_student.Location = new System.Drawing.Point(266, 636);
            this.bt_Add_student.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_Add_student.Name = "bt_Add_student";
            this.bt_Add_student.Size = new System.Drawing.Size(154, 47);
            this.bt_Add_student.TabIndex = 19;
            this.bt_Add_student.Text = "Add";
            this.bt_Add_student.UseVisualStyleBackColor = false;
            this.bt_Add_student.Click += new System.EventHandler(this.bt_Add_student_Click);
            // 
            // infoStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(466, 711);
            this.Controls.Add(this.bt_Add_student);
            this.Controls.Add(this.bt_cancer);
            this.Controls.Add(this.bt_upload_image);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textLname);
            this.Controls.Add(this.textFname);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "infoStudent";
            this.Text = "infoStudent";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.TextBox textFname;
        private System.Windows.Forms.TextBox textLname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_upload_image;
        private System.Windows.Forms.Button bt_cancer;
        private System.Windows.Forms.Button bt_Add_student;
    }
}