namespace check
{
    partial class fLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.login = new System.Windows.Forms.Button();
            this.register = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(115, 102);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(233, 24);
            this.textBoxUsername.TabIndex = 0;
            this.textBoxUsername.UseWaitCursor = true;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBoxUsername.MouseHover += new System.EventHandler(this.textBox1_MouseHover);
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(115, 138);
            this.textPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '#';
            this.textPassword.Size = new System.Drawing.Size(233, 24);
            this.textPassword.TabIndex = 1;
            this.textPassword.UseWaitCursor = true;
            this.textPassword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textPassword.MouseHover += new System.EventHandler(this.textBox2_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(4, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(542, 603);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(229, 197);
            this.login.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(94, 26);
            this.login.TabIndex = 5;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.UseWaitCursor = true;
            this.login.Click += new System.EventHandler(this.button3_Click);
            // 
            // register
            // 
            this.register.Location = new System.Drawing.Point(84, 197);
            this.register.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(94, 26);
            this.register.TabIndex = 6;
            this.register.Text = "Register";
            this.register.UseVisualStyleBackColor = true;
            this.register.UseWaitCursor = true;
            this.register.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(20, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "user name";
            this.label1.UseWaitCursor = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(20, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "pass word";
            this.label2.UseWaitCursor = true;
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // toolTip2
            // 
            this.toolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(13, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 55);
            this.label3.TabIndex = 9;
            this.label3.Text = "Log in";
            this.label3.UseWaitCursor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.login);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxUsername);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textPassword);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.register);
            this.panel1.Location = new System.Drawing.Point(553, 354);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 246);
            this.panel1.TabIndex = 10;
            this.panel1.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(735, 603);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Phan Vĩnh Phúc - 19110434";
            this.label4.UseWaitCursor = true;
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(961, 630);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "fLogin";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Login";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

