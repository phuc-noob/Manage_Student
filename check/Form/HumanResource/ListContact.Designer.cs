namespace check
{
    partial class ListContact
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
            this.listBox_listContact = new System.Windows.Forms.ListBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.dataGridView_contact = new System.Windows.Forms.DataGridView();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.button_cancer = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.button_all = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_contact)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_listContact
            // 
            this.listBox_listContact.FormattingEnabled = true;
            this.listBox_listContact.ItemHeight = 16;
            this.listBox_listContact.Location = new System.Drawing.Point(12, 74);
            this.listBox_listContact.Name = "listBox_listContact";
            this.listBox_listContact.Size = new System.Drawing.Size(211, 436);
            this.listBox_listContact.TabIndex = 0;
            this.listBox_listContact.Click += new System.EventHandler(this.listBox_listContact_Click);
            this.listBox_listContact.SelectedIndexChanged += new System.EventHandler(this.listBox_listContact_SelectedIndexChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Navy;
            this.linkLabel1.Location = new System.Drawing.Point(14, 26);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(126, 35);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Group";
            // 
            // dataGridView_contact
            // 
            this.dataGridView_contact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_contact.Location = new System.Drawing.Point(238, 74);
            this.dataGridView_contact.Name = "dataGridView_contact";
            this.dataGridView_contact.RowHeadersWidth = 51;
            this.dataGridView_contact.RowTemplate.Height = 80;
            this.dataGridView_contact.Size = new System.Drawing.Size(737, 436);
            this.dataGridView_contact.TabIndex = 2;
            this.dataGridView_contact.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_contact_CellDoubleClick);
            // 
            // linkLabel2
            // 
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.Color.Navy;
            this.linkLabel2.Location = new System.Drawing.Point(242, 24);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(185, 35);
            this.linkLabel2.TabIndex = 3;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Show All";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // button_cancer
            // 
            this.button_cancer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_cancer.Location = new System.Drawing.Point(858, 524);
            this.button_cancer.Name = "button_cancer";
            this.button_cancer.Size = new System.Drawing.Size(118, 33);
            this.button_cancer.TabIndex = 4;
            this.button_cancer.Text = "Cancer";
            this.button_cancer.UseVisualStyleBackColor = false;
            this.button_cancer.Click += new System.EventHandler(this.button_cancer_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(716, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(210, 19);
            this.label10.TabIndex = 46;
            this.label10.Text = "19110434 Phan Vĩnh Phúc";
            // 
            // button_all
            // 
            this.button_all.BackColor = System.Drawing.Color.Gainsboro;
            this.button_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_all.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_all.Location = new System.Drawing.Point(404, 22);
            this.button_all.Name = "button_all";
            this.button_all.Size = new System.Drawing.Size(178, 35);
            this.button_all.TabIndex = 47;
            this.button_all.Text = "Show All";
            this.button_all.UseVisualStyleBackColor = false;
            this.button_all.Click += new System.EventHandler(this.button_all_Click);
            // 
            // ListContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(983, 571);
            this.Controls.Add(this.button_all);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button_cancer);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.dataGridView_contact);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.listBox_listContact);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListContact";
            this.Text = "ListContact";
            this.Load += new System.EventHandler(this.ListContact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_contact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_listContact;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridView dataGridView_contact;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button button_cancer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button_all;
    }
}