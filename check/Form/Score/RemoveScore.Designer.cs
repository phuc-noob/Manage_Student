namespace check
{
    partial class RemoveScore
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
            this.dataGridView_Score = new System.Windows.Forms.DataGridView();
            this.button_Remove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Score)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Score
            // 
            this.dataGridView_Score.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView_Score.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Score.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_Score.Name = "dataGridView_Score";
            this.dataGridView_Score.RowHeadersWidth = 51;
            this.dataGridView_Score.RowTemplate.Height = 24;
            this.dataGridView_Score.Size = new System.Drawing.Size(881, 490);
            this.dataGridView_Score.TabIndex = 0;
            // 
            // button_Remove
            // 
            this.button_Remove.BackColor = System.Drawing.Color.Chocolate;
            this.button_Remove.Location = new System.Drawing.Point(12, 508);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(119, 40);
            this.button_Remove.TabIndex = 1;
            this.button_Remove.Text = "Remove";
            this.button_Remove.UseVisualStyleBackColor = false;
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            // 
            // RemoveScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(899, 560);
            this.Controls.Add(this.button_Remove);
            this.Controls.Add(this.dataGridView_Score);
            this.Name = "RemoveScore";
            this.Text = "Remove Score 19110434_PhanVinhPhuc";
            this.Load += new System.EventHandler(this.RemoveScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Score)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Score;
        private System.Windows.Forms.Button button_Remove;
    }
}