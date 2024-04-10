namespace CarGallery.Presenter.Forms
{
    partial class Frm_AddCompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AddCompany));
            this.richTextBox_Description = new System.Windows.Forms.RichTextBox();
            this.txt_CompanyName = new Guna.UI.WinForms.GunaTextBox();
            this.but_AddLogo = new Guna.UI.WinForms.GunaGradientTileButton();
            this.Lbl_Description = new System.Windows.Forms.Label();
            this.Lbl_CompanyName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2CirclePictureBox3 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Company = new System.Windows.Forms.PictureBox();
            this.but_AddCompany = new Guna.UI.WinForms.GunaGradientTileButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Company)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox_Description
            // 
            this.richTextBox_Description.Location = new System.Drawing.Point(105, 509);
            this.richTextBox_Description.Name = "richTextBox_Description";
            this.richTextBox_Description.Size = new System.Drawing.Size(635, 218);
            this.richTextBox_Description.TabIndex = 46;
            this.richTextBox_Description.Text = "";
            // 
            // txt_CompanyName
            // 
            this.txt_CompanyName.BaseColor = System.Drawing.Color.White;
            this.txt_CompanyName.BorderColor = System.Drawing.Color.Silver;
            this.txt_CompanyName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CompanyName.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_CompanyName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_CompanyName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_CompanyName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_CompanyName.Location = new System.Drawing.Point(105, 420);
            this.txt_CompanyName.Name = "txt_CompanyName";
            this.txt_CompanyName.PasswordChar = '\0';
            this.txt_CompanyName.SelectedText = "";
            this.txt_CompanyName.Size = new System.Drawing.Size(287, 32);
            this.txt_CompanyName.TabIndex = 44;
            // 
            // but_AddLogo
            // 
            this.but_AddLogo.AnimationHoverSpeed = 0.07F;
            this.but_AddLogo.AnimationSpeed = 0.03F;
            this.but_AddLogo.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(67)))), ((int)(((byte)(117)))));
            this.but_AddLogo.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(67)))), ((int)(((byte)(117)))));
            this.but_AddLogo.BorderColor = System.Drawing.Color.Transparent;
            this.but_AddLogo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.but_AddLogo.FocusedColor = System.Drawing.Color.Empty;
            this.but_AddLogo.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.but_AddLogo.ForeColor = System.Drawing.Color.White;
            this.but_AddLogo.Image = null;
            this.but_AddLogo.ImageSize = new System.Drawing.Size(52, 52);
            this.but_AddLogo.Location = new System.Drawing.Point(503, 332);
            this.but_AddLogo.Name = "but_AddLogo";
            this.but_AddLogo.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.but_AddLogo.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.but_AddLogo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.but_AddLogo.OnHoverForeColor = System.Drawing.Color.White;
            this.but_AddLogo.OnHoverImage = null;
            this.but_AddLogo.OnPressedColor = System.Drawing.Color.Black;
            this.but_AddLogo.Size = new System.Drawing.Size(238, 45);
            this.but_AddLogo.TabIndex = 35;
            this.but_AddLogo.Text = "Add Logo";
            this.but_AddLogo.Click += new System.EventHandler(this.but_AddLogo_Click);
            // 
            // Lbl_Description
            // 
            this.Lbl_Description.AutoSize = true;
            this.Lbl_Description.Location = new System.Drawing.Point(102, 483);
            this.Lbl_Description.Name = "Lbl_Description";
            this.Lbl_Description.Size = new System.Drawing.Size(122, 23);
            this.Lbl_Description.TabIndex = 33;
            this.Lbl_Description.Text = "Description:";
            // 
            // Lbl_CompanyName
            // 
            this.Lbl_CompanyName.AutoSize = true;
            this.Lbl_CompanyName.Location = new System.Drawing.Point(102, 383);
            this.Lbl_CompanyName.Name = "Lbl_CompanyName";
            this.Lbl_CompanyName.Size = new System.Drawing.Size(181, 23);
            this.Lbl_CompanyName.TabIndex = 32;
            this.Lbl_CompanyName.Text = "Company Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(498, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Company";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(67)))), ((int)(((byte)(117)))));
            this.panel1.Controls.Add(this.guna2CirclePictureBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1270, 80);
            this.panel1.TabIndex = 31;
            // 
            // guna2CirclePictureBox3
            // 
            this.guna2CirclePictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2CirclePictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox3.Image")));
            this.guna2CirclePictureBox3.Location = new System.Drawing.Point(1199, 13);
            this.guna2CirclePictureBox3.Name = "guna2CirclePictureBox3";
            this.guna2CirclePictureBox3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox3.ShadowDecoration.Parent = this.guna2CirclePictureBox3;
            this.guna2CirclePictureBox3.Size = new System.Drawing.Size(55, 58);
            this.guna2CirclePictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox3.TabIndex = 48;
            this.guna2CirclePictureBox3.TabStop = false;
            this.guna2CirclePictureBox3.Click += new System.EventHandler(this.guna2CirclePictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CarGallery.Properties.Resources.Carly;
            this.pictureBox1.Location = new System.Drawing.Point(25, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox_Company
            // 
            this.pictureBox_Company.Location = new System.Drawing.Point(441, 95);
            this.pictureBox_Company.Name = "pictureBox_Company";
            this.pictureBox_Company.Size = new System.Drawing.Size(360, 206);
            this.pictureBox_Company.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Company.TabIndex = 34;
            this.pictureBox_Company.TabStop = false;
            // 
            // but_AddCompany
            // 
            this.but_AddCompany.AnimationHoverSpeed = 0.07F;
            this.but_AddCompany.AnimationSpeed = 0.03F;
            this.but_AddCompany.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(67)))), ((int)(((byte)(117)))));
            this.but_AddCompany.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(67)))), ((int)(((byte)(117)))));
            this.but_AddCompany.BorderColor = System.Drawing.Color.Transparent;
            this.but_AddCompany.DialogResult = System.Windows.Forms.DialogResult.None;
            this.but_AddCompany.FocusedColor = System.Drawing.Color.Empty;
            this.but_AddCompany.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.but_AddCompany.ForeColor = System.Drawing.Color.White;
            this.but_AddCompany.Image = null;
            this.but_AddCompany.ImageSize = new System.Drawing.Size(52, 52);
            this.but_AddCompany.Location = new System.Drawing.Point(503, 745);
            this.but_AddCompany.Name = "but_AddCompany";
            this.but_AddCompany.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.but_AddCompany.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.but_AddCompany.OnHoverBorderColor = System.Drawing.Color.Black;
            this.but_AddCompany.OnHoverForeColor = System.Drawing.Color.White;
            this.but_AddCompany.OnHoverImage = null;
            this.but_AddCompany.OnPressedColor = System.Drawing.Color.Black;
            this.but_AddCompany.Size = new System.Drawing.Size(238, 45);
            this.but_AddCompany.TabIndex = 47;
            this.but_AddCompany.Text = "Add Company";
            this.but_AddCompany.Click += new System.EventHandler(this.but_AddCompany_Click);
            // 
            // Frm_AddCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 820);
            this.ControlBox = false;
            this.Controls.Add(this.but_AddCompany);
            this.Controls.Add(this.richTextBox_Description);
            this.Controls.Add(this.txt_CompanyName);
            this.Controls.Add(this.but_AddLogo);
            this.Controls.Add(this.Lbl_Description);
            this.Controls.Add(this.Lbl_CompanyName);
            this.Controls.Add(this.pictureBox_Company);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_AddCompany";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_AddCompany";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Company)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaGradientTileButton but_AddLogo;
        private System.Windows.Forms.Label Lbl_Description;
        private System.Windows.Forms.Label Lbl_CompanyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox3;
        public System.Windows.Forms.RichTextBox richTextBox_Description;
        public Guna.UI.WinForms.GunaTextBox txt_CompanyName;
        public System.Windows.Forms.PictureBox pictureBox_Company;
        public Guna.UI.WinForms.GunaGradientTileButton but_AddCompany;
    }
}