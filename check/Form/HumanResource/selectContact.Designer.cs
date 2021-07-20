namespace check
{
    partial class selectContact
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
            this.dataGridView_contact = new System.Windows.Forms.DataGridView();
            this.button_cancer = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_contact)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_contact
            // 
            this.dataGridView_contact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_contact.Location = new System.Drawing.Point(4, 52);
            this.dataGridView_contact.Name = "dataGridView_contact";
            this.dataGridView_contact.RowHeadersWidth = 51;
            this.dataGridView_contact.RowTemplate.Height = 80;
            this.dataGridView_contact.Size = new System.Drawing.Size(1089, 556);
            this.dataGridView_contact.TabIndex = 0;
            this.dataGridView_contact.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_contact_CellContentDoubleClick);
            this.dataGridView_contact.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_contact_CellDoubleClick);
            // 
            // button_cancer
            // 
            this.button_cancer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_cancer.Location = new System.Drawing.Point(986, 614);
            this.button_cancer.Name = "button_cancer";
            this.button_cancer.Size = new System.Drawing.Size(103, 35);
            this.button_cancer.TabIndex = 1;
            this.button_cancer.Text = "Cancer";
            this.button_cancer.UseVisualStyleBackColor = false;
            this.button_cancer.Click += new System.EventHandler(this.button_cancer_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(853, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(210, 19);
            this.label10.TabIndex = 46;
            this.label10.Text = "19110434 Phan Vĩnh Phúc";
            // 
            // selectContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 676);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button_cancer);
            this.Controls.Add(this.dataGridView_contact);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "selectContact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.selectContact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_contact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_contact;
        private System.Windows.Forms.Button button_cancer;
        private System.Windows.Forms.Label label10;
    }
}