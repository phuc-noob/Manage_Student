namespace check
{
    partial class EditCourse
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
            this.bt_EDIT = new System.Windows.Forms.Button();
            this.tb_des = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_hour = new System.Windows.Forms.NumericUpDown();
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_hour)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_EDIT
            // 
            this.bt_EDIT.BackColor = System.Drawing.Color.DeepPink;
            this.bt_EDIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_EDIT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_EDIT.Location = new System.Drawing.Point(90, 367);
            this.bt_EDIT.Name = "bt_EDIT";
            this.bt_EDIT.Size = new System.Drawing.Size(475, 46);
            this.bt_EDIT.TabIndex = 17;
            this.bt_EDIT.Text = "EDIT";
            this.bt_EDIT.UseVisualStyleBackColor = false;
            this.bt_EDIT.Click += new System.EventHandler(this.bt_EDIT_Click);
            // 
            // tb_des
            // 
            this.tb_des.Location = new System.Drawing.Point(265, 230);
            this.tb_des.Multiline = true;
            this.tb_des.Name = "tb_des";
            this.tb_des.Size = new System.Drawing.Size(300, 106);
            this.tb_des.TabIndex = 16;
            this.tb_des.TextChanged += new System.EventHandler(this.tb_des_TextChanged);
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(265, 106);
            this.tb_Name.Multiline = true;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(300, 29);
            this.tb_Name.TabIndex = 15;
            this.tb_Name.TextChanged += new System.EventHandler(this.tb_Name_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(85, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "Description";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(140, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Period";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(153, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(53, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select Course";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // numericUpDown_hour
            // 
            this.numericUpDown_hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_hour.Location = new System.Drawing.Point(265, 176);
            this.numericUpDown_hour.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_hour.Name = "numericUpDown_hour";
            this.numericUpDown_hour.Size = new System.Drawing.Size(120, 27);
            this.numericUpDown_hour.TabIndex = 18;
            this.numericUpDown_hour.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_hour.ValueChanged += new System.EventHandler(this.numericUpDown_hour_ValueChanged);
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Location = new System.Drawing.Point(265, 43);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(300, 24);
            this.comboBoxCourse.TabIndex = 19;
            this.comboBoxCourse.SelectedIndexChanged += new System.EventHandler(this.comboBoxCourse_SelectedIndexChanged);
            // 
            // EditCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(651, 450);
            this.Controls.Add(this.comboBoxCourse);
            this.Controls.Add(this.numericUpDown_hour);
            this.Controls.Add(this.bt_EDIT);
            this.Controls.Add(this.tb_des);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditCourse";
            this.Text = "19110434_PhanVInhPhuc_EditCourse";
            this.Load += new System.EventHandler(this.EditCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_hour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_EDIT;
        private System.Windows.Forms.TextBox tb_des;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_hour;
        private System.Windows.Forms.ComboBox comboBoxCourse;
    }
}