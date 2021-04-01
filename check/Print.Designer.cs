namespace check
{
    partial class Print
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dtPicker_min = new System.Windows.Forms.DateTimePicker();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbMaleStd = new System.Windows.Forms.RadioButton();
            this.rbFemaleStd = new System.Windows.Forms.RadioButton();
            this.rb_AllStd = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView_Print = new System.Windows.Forms.DataGridView();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Print)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.rbMaleStd);
            this.panel1.Controls.Add(this.rbFemaleStd);
            this.panel1.Controls.Add(this.rb_AllStd);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1144, 122);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(1005, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.dtPicker_min);
            this.panel2.Controls.Add(this.radioButton5);
            this.panel2.Controls.Add(this.radioButton4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panel2.Location = new System.Drawing.Point(334, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(654, 90);
            this.panel2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(335, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "AND";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(396, 49);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(111, 27);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // dtPicker_min
            // 
            this.dtPicker_min.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPicker_min.Location = new System.Drawing.Point(203, 49);
            this.dtPicker_min.Name = "dtPicker_min";
            this.dtPicker_min.Size = new System.Drawing.Size(111, 27);
            this.dtPicker_min.TabIndex = 5;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Checked = true;
            this.radioButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButton5.Location = new System.Drawing.Point(329, 8);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(51, 24);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "No";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButton4.Location = new System.Drawing.Point(234, 8);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(58, 24);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "Yes";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(27, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "BirthDate Between";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(27, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Use Date Range";
            // 
            // rbMaleStd
            // 
            this.rbMaleStd.AutoSize = true;
            this.rbMaleStd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMaleStd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbMaleStd.Location = new System.Drawing.Point(122, 32);
            this.rbMaleStd.Name = "rbMaleStd";
            this.rbMaleStd.Size = new System.Drawing.Size(66, 24);
            this.rbMaleStd.TabIndex = 2;
            this.rbMaleStd.Text = "Male";
            this.rbMaleStd.UseVisualStyleBackColor = true;
            this.rbMaleStd.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rbFemaleStd
            // 
            this.rbFemaleStd.AutoSize = true;
            this.rbFemaleStd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemaleStd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbFemaleStd.Location = new System.Drawing.Point(210, 32);
            this.rbFemaleStd.Name = "rbFemaleStd";
            this.rbFemaleStd.Size = new System.Drawing.Size(85, 24);
            this.rbFemaleStd.TabIndex = 1;
            this.rbFemaleStd.Text = "Female";
            this.rbFemaleStd.UseVisualStyleBackColor = true;
            this.rbFemaleStd.CheckedChanged += new System.EventHandler(this.rbFemaleStd_CheckedChanged);
            // 
            // rb_AllStd
            // 
            this.rb_AllStd.AutoSize = true;
            this.rb_AllStd.Checked = true;
            this.rb_AllStd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_AllStd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rb_AllStd.Location = new System.Drawing.Point(39, 32);
            this.rb_AllStd.Name = "rb_AllStd";
            this.rb_AllStd.Size = new System.Drawing.Size(61, 24);
            this.rb_AllStd.TabIndex = 0;
            this.rb_AllStd.TabStop = true;
            this.rb_AllStd.Text = "ALL";
            this.rb_AllStd.UseVisualStyleBackColor = true;
            this.rb_AllStd.CheckedChanged += new System.EventHandler(this.rb_AllStd_CheckedChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.Location = new System.Drawing.Point(328, 627);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(229, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "Save To Text File";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.OrangeRed;
            this.button3.Location = new System.Drawing.Point(614, 627);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 36);
            this.button3.TabIndex = 3;
            this.button3.Text = "Printer";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView_Print
            // 
            this.dataGridView_Print.AllowUserToResizeRows = false;
            this.dataGridView_Print.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Print.Location = new System.Drawing.Point(12, 140);
            this.dataGridView_Print.Name = "dataGridView_Print";
            this.dataGridView_Print.RowHeadersWidth = 51;
            this.dataGridView_Print.RowTemplate.Height = 80;
            this.dataGridView_Print.RowTemplate.ReadOnly = true;
            this.dataGridView_Print.Size = new System.Drawing.Size(1148, 464);
            this.dataGridView_Print.TabIndex = 4;
            this.dataGridView_Print.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Print_CellContentClick_3);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1168, 700);
            this.Controls.Add(this.dataGridView_Print);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Name = "Print";
            this.Text = "Print";
            this.Load += new System.EventHandler(this.Print_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Print)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbMaleStd;
        private System.Windows.Forms.RadioButton rbFemaleStd;
        private System.Windows.Forms.RadioButton rb_AllStd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dtPicker_min;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView_Print;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}