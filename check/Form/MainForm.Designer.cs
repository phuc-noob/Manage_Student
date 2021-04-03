namespace check
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDSTUDENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lISTSTUDENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sTATICSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITREMOVEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTrip_manageStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.pRINTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.sCOREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.sCOREToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(725, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDSTUDENTToolStripMenuItem,
            this.lISTSTUDENTToolStripMenuItem,
            this.sTATICSToolStripMenuItem,
            this.eDITREMOVEToolStripMenuItem,
            this.toolTrip_manageStudent,
            this.pRINTToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(87, 24);
            this.toolStripMenuItem2.Text = "STUDENT";
            // 
            // aDDSTUDENTToolStripMenuItem
            // 
            this.aDDSTUDENTToolStripMenuItem.Name = "aDDSTUDENTToolStripMenuItem";
            this.aDDSTUDENTToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.aDDSTUDENTToolStripMenuItem.Text = "ADD NEW STUDENT";
            this.aDDSTUDENTToolStripMenuItem.Click += new System.EventHandler(this.aDDSTUDENTToolStripMenuItem_Click);
            // 
            // lISTSTUDENTToolStripMenuItem
            // 
            this.lISTSTUDENTToolStripMenuItem.Name = "lISTSTUDENTToolStripMenuItem";
            this.lISTSTUDENTToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.lISTSTUDENTToolStripMenuItem.Text = "STUDENT LIST";
            this.lISTSTUDENTToolStripMenuItem.Click += new System.EventHandler(this.lISTSTUDENTToolStripMenuItem_Click);
            // 
            // sTATICSToolStripMenuItem
            // 
            this.sTATICSToolStripMenuItem.Name = "sTATICSToolStripMenuItem";
            this.sTATICSToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.sTATICSToolStripMenuItem.Text = "STATICS";
            this.sTATICSToolStripMenuItem.Click += new System.EventHandler(this.sTATICSToolStripMenuItem_Click);
            // 
            // eDITREMOVEToolStripMenuItem
            // 
            this.eDITREMOVEToolStripMenuItem.Name = "eDITREMOVEToolStripMenuItem";
            this.eDITREMOVEToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.eDITREMOVEToolStripMenuItem.Text = "EDIT/ REMOVE";
            this.eDITREMOVEToolStripMenuItem.Click += new System.EventHandler(this.eDITREMOVEToolStripMenuItem_Click);
            // 
            // toolTrip_manageStudent
            // 
            this.toolTrip_manageStudent.Name = "toolTrip_manageStudent";
            this.toolTrip_manageStudent.Size = new System.Drawing.Size(266, 26);
            this.toolTrip_manageStudent.Text = "MANAGE STUDENT FORM";
            this.toolTrip_manageStudent.Click += new System.EventHandler(this.mANAGESTUDENTFORMToolStripMenuItem_Click);
            // 
            // pRINTToolStripMenuItem
            // 
            this.pRINTToolStripMenuItem.Name = "pRINTToolStripMenuItem";
            this.pRINTToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.pRINTToolStripMenuItem.Text = "PRINT";
            this.pRINTToolStripMenuItem.Click += new System.EventHandler(this.pRINTToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(78, 24);
            this.toolStripMenuItem3.Text = "COURSE";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // sCOREToolStripMenuItem
            // 
            this.sCOREToolStripMenuItem.Name = "sCOREToolStripMenuItem";
            this.sCOREToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.sCOREToolStripMenuItem.Text = "SCORE";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 463);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem aDDSTUDENTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lISTSTUDENTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sTATICSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITREMOVEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolTrip_manageStudent;
        private System.Windows.Forms.ToolStripMenuItem pRINTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sCOREToolStripMenuItem;
    }
}