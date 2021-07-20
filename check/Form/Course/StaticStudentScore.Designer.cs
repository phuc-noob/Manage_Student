namespace check
{
    partial class StaticStudentScore
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_count = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_percent = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart_count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_percent)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_count
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_count.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_count.Legends.Add(legend1);
            this.chart_count.Location = new System.Drawing.Point(12, 12);
            this.chart_count.Name = "chart_count";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Amount";
            this.chart_count.Series.Add(series1);
            this.chart_count.Size = new System.Drawing.Size(411, 476);
            this.chart_count.TabIndex = 0;
            this.chart_count.Text = "chart1";
            // 
            // chart_percent
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_percent.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_percent.Legends.Add(legend2);
            this.chart_percent.Location = new System.Drawing.Point(456, 12);
            this.chart_percent.Name = "chart_percent";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "percent";
            this.chart_percent.Series.Add(series2);
            this.chart_percent.Size = new System.Drawing.Size(447, 476);
            this.chart_percent.TabIndex = 1;
            this.chart_percent.Text = "chart2";
            // 
            // StaticStudentScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 500);
            this.Controls.Add(this.chart_percent);
            this.Controls.Add(this.chart_count);
            this.Name = "StaticStudentScore";
            this.Text = "StaticStudentScore";
            this.Load += new System.EventHandler(this.StaticStudentScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_percent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_count;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_percent;
    }
}