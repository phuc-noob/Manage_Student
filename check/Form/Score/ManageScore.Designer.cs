namespace check
{
    partial class ManageScore
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
            this.cb_course = new System.Windows.Forms.ComboBox();
            this.bt_avgScore = new System.Windows.Forms.Button();
            this.tb_des = new System.Windows.Forms.TextBox();
            this.tb_Score = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Remove = new System.Windows.Forms.Button();
            this.dataGridView_manage = new System.Windows.Forms.DataGridView();
            this.button_show_Student = new System.Windows.Forms.Button();
            this.button_ShowScore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_manage)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_course
            // 
            this.cb_course.FormattingEnabled = true;
            this.cb_course.ItemHeight = 16;
            this.cb_course.Location = new System.Drawing.Point(212, 90);
            this.cb_course.Name = "cb_course";
            this.cb_course.Size = new System.Drawing.Size(257, 24);
            this.cb_course.TabIndex = 28;
            this.cb_course.SelectedIndexChanged += new System.EventHandler(this.cb_course_SelectedIndexChanged);
            // 
            // bt_avgScore
            // 
            this.bt_avgScore.BackColor = System.Drawing.Color.DeepPink;
            this.bt_avgScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_avgScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_avgScore.Location = new System.Drawing.Point(37, 444);
            this.bt_avgScore.Name = "bt_avgScore";
            this.bt_avgScore.Size = new System.Drawing.Size(432, 46);
            this.bt_avgScore.TabIndex = 27;
            this.bt_avgScore.Text = "AVERAGE SCORE BY COURSE";
            this.bt_avgScore.UseVisualStyleBackColor = false;
            this.bt_avgScore.Click += new System.EventHandler(this.bt_avgScore_Click);
            // 
            // tb_des
            // 
            this.tb_des.Location = new System.Drawing.Point(212, 214);
            this.tb_des.Multiline = true;
            this.tb_des.Name = "tb_des";
            this.tb_des.Size = new System.Drawing.Size(257, 106);
            this.tb_des.TabIndex = 26;
            // 
            // tb_Score
            // 
            this.tb_Score.Location = new System.Drawing.Point(212, 152);
            this.tb_Score.Multiline = true;
            this.tb_Score.Name = "tb_Score";
            this.tb_Score.Size = new System.Drawing.Size(134, 29);
            this.tb_Score.TabIndex = 25;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(212, 22);
            this.tb_id.Multiline = true;
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(134, 29);
            this.tb_id.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(44, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 29);
            this.label4.TabIndex = 23;
            this.label4.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(108, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 29);
            this.label3.TabIndex = 22;
            this.label3.Text = "Score";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "Select Course";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(59, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "Student Id";
            // 
            // button_Add
            // 
            this.button_Add.BackColor = System.Drawing.Color.MediumBlue;
            this.button_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Add.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Add.Location = new System.Drawing.Point(37, 360);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(177, 46);
            this.button_Add.TabIndex = 29;
            this.button_Add.Text = "ADD";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Remove
            // 
            this.button_Remove.BackColor = System.Drawing.Color.SaddleBrown;
            this.button_Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Remove.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Remove.Location = new System.Drawing.Point(285, 360);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(184, 46);
            this.button_Remove.TabIndex = 30;
            this.button_Remove.Text = "REMOVE";
            this.button_Remove.UseVisualStyleBackColor = false;
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            // 
            // dataGridView_manage
            // 
            this.dataGridView_manage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_manage.Location = new System.Drawing.Point(503, 85);
            this.dataGridView_manage.Name = "dataGridView_manage";
            this.dataGridView_manage.RowHeadersWidth = 51;
            this.dataGridView_manage.RowTemplate.Height = 24;
            this.dataGridView_manage.Size = new System.Drawing.Size(601, 405);
            this.dataGridView_manage.TabIndex = 31;
            this.dataGridView_manage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_manage_CellClick);
            // 
            // button_show_Student
            // 
            this.button_show_Student.BackColor = System.Drawing.Color.LightSlateGray;
            this.button_show_Student.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_show_Student.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_show_Student.Location = new System.Drawing.Point(503, 22);
            this.button_show_Student.Name = "button_show_Student";
            this.button_show_Student.Size = new System.Drawing.Size(230, 35);
            this.button_show_Student.TabIndex = 32;
            this.button_show_Student.Text = "Show Student";
            this.button_show_Student.UseVisualStyleBackColor = false;
            this.button_show_Student.Click += new System.EventHandler(this.button_show_Student_Click);
            // 
            // button_ShowScore
            // 
            this.button_ShowScore.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_ShowScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ShowScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_ShowScore.Location = new System.Drawing.Point(873, 22);
            this.button_ShowScore.Name = "button_ShowScore";
            this.button_ShowScore.Size = new System.Drawing.Size(231, 35);
            this.button_ShowScore.TabIndex = 33;
            this.button_ShowScore.Text = "Show Score";
            this.button_ShowScore.UseVisualStyleBackColor = false;
            this.button_ShowScore.Click += new System.EventHandler(this.button_ShowScore_Click);
            // 
            // ManageScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1107, 550);
            this.Controls.Add(this.button_ShowScore);
            this.Controls.Add(this.button_show_Student);
            this.Controls.Add(this.dataGridView_manage);
            this.Controls.Add(this.button_Remove);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.cb_course);
            this.Controls.Add(this.bt_avgScore);
            this.Controls.Add(this.tb_des);
            this.Controls.Add(this.tb_Score);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ManageScore";
            this.Text = "ManageScore 19110434_phanVinhPhuc";
            this.Load += new System.EventHandler(this.ManageScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_manage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_course;
        private System.Windows.Forms.Button bt_avgScore;
        private System.Windows.Forms.TextBox tb_des;
        private System.Windows.Forms.TextBox tb_Score;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Remove;
        private System.Windows.Forms.DataGridView dataGridView_manage;
        private System.Windows.Forms.Button button_show_Student;
        private System.Windows.Forms.Button button_ShowScore;
    }
}