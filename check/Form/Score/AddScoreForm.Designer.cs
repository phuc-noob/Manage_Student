namespace check
{
    partial class AddScoreForm
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
            this.bt_ADDScore = new System.Windows.Forms.Button();
            this.tb_des = new System.Windows.Forms.TextBox();
            this.tb_Score = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtGridView_Std = new System.Windows.Forms.DataGridView();
            this.cb_course = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView_Std)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_ADDScore
            // 
            this.bt_ADDScore.BackColor = System.Drawing.Color.DeepPink;
            this.bt_ADDScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ADDScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_ADDScore.Location = new System.Drawing.Point(55, 355);
            this.bt_ADDScore.Name = "bt_ADDScore";
            this.bt_ADDScore.Size = new System.Drawing.Size(475, 46);
            this.bt_ADDScore.TabIndex = 17;
            this.bt_ADDScore.Text = "ADD SCORE";
            this.bt_ADDScore.UseVisualStyleBackColor = false;
            this.bt_ADDScore.Click += new System.EventHandler(this.bt_ADDScore_Click);
            // 
            // tb_des
            // 
            this.tb_des.Location = new System.Drawing.Point(221, 218);
            this.tb_des.Multiline = true;
            this.tb_des.Name = "tb_des";
            this.tb_des.Size = new System.Drawing.Size(300, 106);
            this.tb_des.TabIndex = 16;
            // 
            // tb_Score
            // 
            this.tb_Score.Location = new System.Drawing.Point(221, 156);
            this.tb_Score.Multiline = true;
            this.tb_Score.Name = "tb_Score";
            this.tb_Score.Size = new System.Drawing.Size(134, 29);
            this.tb_Score.TabIndex = 14;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(221, 26);
            this.tb_id.Multiline = true;
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(134, 29);
            this.tb_id.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(53, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(117, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Score";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(21, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Select Course";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(68, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Student Id";
            // 
            // dtGridView_Std
            // 
            this.dtGridView_Std.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridView_Std.Location = new System.Drawing.Point(536, 26);
            this.dtGridView_Std.Name = "dtGridView_Std";
            this.dtGridView_Std.RowHeadersWidth = 51;
            this.dtGridView_Std.RowTemplate.Height = 24;
            this.dtGridView_Std.Size = new System.Drawing.Size(476, 375);
            this.dtGridView_Std.TabIndex = 18;
            this.dtGridView_Std.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridView_Std_CellClick);
            // 
            // cb_course
            // 
            this.cb_course.FormattingEnabled = true;
            this.cb_course.ItemHeight = 16;
            this.cb_course.Location = new System.Drawing.Point(221, 94);
            this.cb_course.Name = "cb_course";
            this.cb_course.Size = new System.Drawing.Size(300, 24);
            this.cb_course.TabIndex = 19;
            // 
            // AddScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1024, 450);
            this.Controls.Add(this.cb_course);
            this.Controls.Add(this.dtGridView_Std);
            this.Controls.Add(this.bt_ADDScore);
            this.Controls.Add(this.tb_des);
            this.Controls.Add(this.tb_Score);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddScoreForm";
            this.Text = "19110434 Phan Vĩnh Phúc_AddScoreForm";
            this.Load += new System.EventHandler(this.AddScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView_Std)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_ADDScore;
        private System.Windows.Forms.TextBox tb_des;
        private System.Windows.Forms.TextBox tb_Score;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtGridView_Std;
        private System.Windows.Forms.ComboBox cb_course;
    }
}