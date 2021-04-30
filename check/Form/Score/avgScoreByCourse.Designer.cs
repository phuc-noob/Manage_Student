namespace check
{
    partial class avgScoreByCourse
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
            this.dataGridView_Score = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.chart_avg = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_avg)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Score
            // 
            this.dataGridView_Score.BackgroundColor = System.Drawing.Color.LightCoral;
            this.dataGridView_Score.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Score.Location = new System.Drawing.Point(12, 6);
            this.dataGridView_Score.Name = "dataGridView_Score";
            this.dataGridView_Score.RowHeadersWidth = 51;
            this.dataGridView_Score.RowTemplate.Height = 24;
            this.dataGridView_Score.Size = new System.Drawing.Size(330, 264);
            this.dataGridView_Score.TabIndex = 0;
            // 
            // chart1
            // 
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 0;
            // 
            // chart_avg
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_avg.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_avg.Legends.Add(legend1);
            this.chart_avg.Location = new System.Drawing.Point(12, 276);
            this.chart_avg.Name = "chart_avg";
            this.chart_avg.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Avg Score";
            this.chart_avg.Series.Add(series1);
            this.chart_avg.Size = new System.Drawing.Size(330, 374);
            this.chart_avg.TabIndex = 1;
            this.chart_avg.Text = "chart2";
            this.chart_avg.Click += new System.EventHandler(this.chart_avg_Click);
            // 
            // avgScoreByCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 704);
            this.Controls.Add(this.chart_avg);
            this.Controls.Add(this.dataGridView_Score);
            this.Name = "avgScoreByCourse";
            this.Text = "avgScoreByCourse_19110434_PhanVinhPhuc";
            this.Load += new System.EventHandler(this.avgScoreByCourse_19110434_PhanVinhPhuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_avg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Score;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_avg;
    }
}