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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Total = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_totalMale = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_Female = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            // StatisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 283);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "StatisForm";
            this.Text = "StatisForm";
            this.Load += new System.EventHandler(this.StatisForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_Total;
        private System.Windows.Forms.Label label_totalMale;
        private System.Windows.Forms.Label label_Female;
    }
}