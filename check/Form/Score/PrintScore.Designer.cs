namespace check
{
    partial class PrintScore
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
            this.dataGridView_Print = new System.Windows.Forms.DataGridView();
            this.button_File = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Print)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Print
            // 
            this.dataGridView_Print.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Print.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_Print.Name = "dataGridView_Print";
            this.dataGridView_Print.RowHeadersWidth = 51;
            this.dataGridView_Print.RowTemplate.Height = 24;
            this.dataGridView_Print.Size = new System.Drawing.Size(698, 409);
            this.dataGridView_Print.TabIndex = 0;
            // 
            // button_File
            // 
            this.button_File.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button_File.Location = new System.Drawing.Point(12, 438);
            this.button_File.Name = "button_File";
            this.button_File.Size = new System.Drawing.Size(124, 38);
            this.button_File.TabIndex = 1;
            this.button_File.Text = "Save To File";
            this.button_File.UseVisualStyleBackColor = false;
            this.button_File.Click += new System.EventHandler(this.button_File_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(185, 438);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 38);
            this.button2.TabIndex = 2;
            this.button2.Text = "Print";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // PrintScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 502);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_File);
            this.Controls.Add(this.dataGridView_Print);
            this.Name = "PrintScore";
            this.Text = "PrintScore";
            this.Load += new System.EventHandler(this.PrintScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Print)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Print;
        private System.Windows.Forms.Button button_File;
        private System.Windows.Forms.Button button2;
    }
}