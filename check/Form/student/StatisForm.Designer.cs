namespace check
{
    partial class StatisForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Total = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_totalMale = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_Female = new System.Windows.Forms.Label();
            this.chart_sexualStudent = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_sexualStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label_Total);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 127);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label_Total
            // 
            this.label_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Total.Location = new System.Drawing.Point(6, 31);
            this.label_Total.Name = "label_Total";
            this.label_Total.Size = new System.Drawing.Size(651, 51);
            this.label_Total.TabIndex = 0;
            this.label_Total.Text = "label1";
            this.label_Total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Total.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.Controls.Add(this.label_totalMale);
            this.panel2.Location = new System.Drawing.Point(12, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(327, 121);
            this.panel2.TabIndex = 1;
            // 
            // label_totalMale
            // 
            this.label_totalMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_totalMale.Location = new System.Drawing.Point(6, 26);
            this.label_totalMale.Name = "label_totalMale";
            this.label_totalMale.Size = new System.Drawing.Size(314, 51);
            this.label_totalMale.TabIndex = 1;
            this.label_totalMale.Text = "label2";
            this.label_totalMale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.label_Female);
            this.panel3.Location = new System.Drawing.Point(335, 140);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(337, 121);
            this.panel3.TabIndex = 2;
            // 
            // label_Female
            // 
            this.label_Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Female.Location = new System.Drawing.Point(3, 25);
            this.label_Female.Name = "label_Female";
            this.label_Female.Size = new System.Drawing.Size(353, 52);
            this.label_Female.TabIndex = 1;
            this.label_Female.Text = "label3";
            this.label_Female.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chart_sexualStudent
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_sexualStudent.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_sexualStudent.Legends.Add(legend1);
            this.chart_sexualStudent.Location = new System.Drawing.Point(12, 280);
            this.chart_sexualStudent.Name = "chart_sexualStudent";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "student";
            this.chart_sexualStudent.Series.Add(series1);
            this.chart_sexualStudent.Size = new System.Drawing.Size(657, 391);
            this.chart_sexualStudent.TabIndex = 3;
            this.chart_sexualStudent.Text = "student";
            this.chart_sexualStudent.Click += new System.EventHandler(this.chart_sexualStudent_Click);
            // 
            // StatisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 683);
            this.Controls.Add(this.chart_sexualStudent);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StatisForm";
            this.Text = "StatisForm";
            this.Load += new System.EventHandler(this.StatisForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_sexualStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_Total;
        private System.Windows.Forms.Label label_totalMale;
        private System.Windows.Forms.Label label_Female;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_sexualStudent;
    }
}