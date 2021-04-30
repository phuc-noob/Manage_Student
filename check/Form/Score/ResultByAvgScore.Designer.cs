namespace check
{
    partial class ResultByAvgScore
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
            this.tb_lname = new System.Windows.Forms.TextBox();
            this.tb_sid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_fname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView_Result = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.button_search = new System.Windows.Forms.Button();
            this.tb_id_fname = new System.Windows.Forms.TextBox();
            this.button_print = new System.Windows.Forms.Button();
            this.bt_cancer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Result)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_lname
            // 
            this.tb_lname.Location = new System.Drawing.Point(196, 212);
            this.tb_lname.Multiline = true;
            this.tb_lname.Name = "tb_lname";
            this.tb_lname.Size = new System.Drawing.Size(134, 29);
            this.tb_lname.TabIndex = 33;
            // 
            // tb_sid
            // 
            this.tb_sid.Location = new System.Drawing.Point(196, 82);
            this.tb_sid.Multiline = true;
            this.tb_sid.Name = "tb_sid";
            this.tb_sid.Size = new System.Drawing.Size(134, 29);
            this.tb_sid.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(28, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 29);
            this.label3.TabIndex = 31;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(28, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 29);
            this.label2.TabIndex = 30;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(28, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 29);
            this.label1.TabIndex = 29;
            this.label1.Text = "Student Id";
            // 
            // tb_fname
            // 
            this.tb_fname.Location = new System.Drawing.Point(196, 150);
            this.tb_fname.Multiline = true;
            this.tb_fname.Name = "tb_fname";
            this.tb_fname.Size = new System.Drawing.Size(134, 29);
            this.tb_fname.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("VNI-OngDoHL", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Location = new System.Drawing.Point(344, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 61);
            this.label4.TabIndex = 36;
            this.label4.Text = "Student Result";
            // 
            // dataGridView_Result
            // 
            this.dataGridView_Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Result.Location = new System.Drawing.Point(355, 82);
            this.dataGridView_Result.Name = "dataGridView_Result";
            this.dataGridView_Result.RowHeadersWidth = 51;
            this.dataGridView_Result.RowTemplate.Height = 24;
            this.dataGridView_Result.Size = new System.Drawing.Size(758, 264);
            this.dataGridView_Result.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(28, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(302, 29);
            this.label5.TabIndex = 38;
            this.label5.Text = "Search By Id ,First Name";
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(33, 317);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(99, 29);
            this.button_search.TabIndex = 39;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // tb_id_fname
            // 
            this.tb_id_fname.Location = new System.Drawing.Point(158, 317);
            this.tb_id_fname.Multiline = true;
            this.tb_id_fname.Name = "tb_id_fname";
            this.tb_id_fname.Size = new System.Drawing.Size(172, 29);
            this.tb_id_fname.TabIndex = 40;
            // 
            // button_print
            // 
            this.button_print.Location = new System.Drawing.Point(355, 374);
            this.button_print.Name = "button_print";
            this.button_print.Size = new System.Drawing.Size(153, 34);
            this.button_print.TabIndex = 41;
            this.button_print.Text = "Print";
            this.button_print.UseVisualStyleBackColor = true;
            // 
            // bt_cancer
            // 
            this.bt_cancer.Location = new System.Drawing.Point(566, 374);
            this.bt_cancer.Name = "bt_cancer";
            this.bt_cancer.Size = new System.Drawing.Size(153, 34);
            this.bt_cancer.TabIndex = 42;
            this.bt_cancer.Text = "Cancer";
            this.bt_cancer.UseVisualStyleBackColor = true;
            this.bt_cancer.Click += new System.EventHandler(this.bt_cancer_Click);
            // 
            // ResultByAvgScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1125, 433);
            this.Controls.Add(this.bt_cancer);
            this.Controls.Add(this.button_print);
            this.Controls.Add(this.tb_id_fname);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView_Result);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_fname);
            this.Controls.Add(this.tb_lname);
            this.Controls.Add(this.tb_sid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ResultByAvgScore";
            this.Text = "ResultByAvgScore 19110434_phanVinhPhuc";
            this.Load += new System.EventHandler(this.ResultByAvgScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_lname;
        private System.Windows.Forms.TextBox tb_sid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_fname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView_Result;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox tb_id_fname;
        private System.Windows.Forms.Button button_print;
        private System.Windows.Forms.Button bt_cancer;
    }
}