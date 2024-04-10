namespace CarGallery.Presenter.Forms
{
    partial class Frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_CreateAcc = new System.Windows.Forms.Label();
            this.but_Login = new Guna.UI2.WinForms.Guna2Button();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lbl_CreateAcc);
            this.panel1.Controls.Add(this.but_Login);
            this.panel1.Controls.Add(this.txt_Password);
            this.panel1.Controls.Add(this.txt_Email);
            this.panel1.Controls.Add(this.lbl_Password);
            this.panel1.Controls.Add(this.lbl_Email);
            this.panel1.ForeColor = System.Drawing.Color.Yellow;
            this.panel1.Location = new System.Drawing.Point(259, 344);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 270);
            this.panel1.TabIndex = 4;
            // 
            // lbl_CreateAcc
            // 
            this.lbl_CreateAcc.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CreateAcc.ForeColor = System.Drawing.Color.SeaShell;
            this.lbl_CreateAcc.Location = new System.Drawing.Point(3, 152);
            this.lbl_CreateAcc.Name = "lbl_CreateAcc";
            this.lbl_CreateAcc.Size = new System.Drawing.Size(287, 45);
            this.lbl_CreateAcc.TabIndex = 5;
            this.lbl_CreateAcc.Text = "Create account";
            this.lbl_CreateAcc.Click += new System.EventHandler(this.lbl_CreateAcc_Click);
            this.lbl_CreateAcc.MouseLeave += new System.EventHandler(this.lbl_CreateAcc_MouseLeave);
            this.lbl_CreateAcc.MouseHover += new System.EventHandler(this.lbl_CreateAcc_MouseHover);
            // 
            // but_Login
            // 
            this.but_Login.BackColor = System.Drawing.Color.DodgerBlue;
            this.but_Login.CheckedState.Parent = this.but_Login;
            this.but_Login.CustomImages.Parent = this.but_Login;
            this.but_Login.FillColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.but_Login.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(67)))), ((int)(((byte)(117)))));
            this.but_Login.HoverState.Parent = this.but_Login;
            this.but_Login.Location = new System.Drawing.Point(324, 152);
            this.but_Login.Name = "but_Login";
            this.but_Login.ShadowDecoration.Parent = this.but_Login;
            this.but_Login.Size = new System.Drawing.Size(158, 45);
            this.but_Login.TabIndex = 4;
            this.but_Login.Text = "Login";
            this.but_Login.Click += new System.EventHandler(this.but_Login_Click);
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(234, 102);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(291, 24);
            this.txt_Password.TabIndex = 3;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(234, 41);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(291, 24);
            this.txt_Email.TabIndex = 2;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(67)))), ((int)(((byte)(117)))));
            this.lbl_Password.Location = new System.Drawing.Point(67, 90);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(153, 37);
            this.lbl_Password.TabIndex = 1;
            this.lbl_Password.Text = "Password";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(67)))), ((int)(((byte)(117)))));
            this.lbl_Email.Location = new System.Drawing.Point(111, 31);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(95, 37);
            this.lbl_Email.TabIndex = 0;
            this.lbl_Email.Text = "Email";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(262, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(681, 146);
            this.label1.TabIndex = 3;
            this.label1.Text = "A place to Find the type of car you need at amazing prices";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 820);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_CreateAcc;
        private Guna.UI2.WinForms.Guna2Button but_Login;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label label1;
    }
}