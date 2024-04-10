namespace CarGallery.Presenter.Forms
{
    partial class Frm_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Home));
            this.gunaGradient2Panel1 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.But_Company = new Guna.UI.WinForms.GunaAdvenceButton();
            this.But_User = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton4 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.But_Cars = new Guna.UI.WinForms.GunaAdvenceButton();
            this.But_Home = new Guna.UI.WinForms.GunaAdvenceButton();
            this.Image_slide = new System.Windows.Forms.PictureBox();
            this.PanelContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.gunaGradient2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image_slide)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaGradient2Panel1
            // 
            this.gunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel1.Controls.Add(this.guna2CirclePictureBox1);
            this.gunaGradient2Panel1.Controls.Add(this.But_Company);
            this.gunaGradient2Panel1.Controls.Add(this.But_User);
            this.gunaGradient2Panel1.Controls.Add(this.gunaAdvenceButton4);
            this.gunaGradient2Panel1.Controls.Add(this.But_Cars);
            this.gunaGradient2Panel1.Controls.Add(this.But_Home);
            this.gunaGradient2Panel1.Controls.Add(this.Image_slide);
            this.gunaGradient2Panel1.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(67)))), ((int)(((byte)(117)))));
            this.gunaGradient2Panel1.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(67)))), ((int)(((byte)(117)))));
            this.gunaGradient2Panel1.Location = new System.Drawing.Point(11, 24);
            this.gunaGradient2Panel1.Name = "gunaGradient2Panel1";
            this.gunaGradient2Panel1.Radius = 24;
            this.gunaGradient2Panel1.Size = new System.Drawing.Size(81, 777);
            this.gunaGradient2Panel1.TabIndex = 0;
            // 
            // But_Company
            // 
            this.But_Company.AnimationHoverSpeed = 0.07F;
            this.But_Company.AnimationSpeed = 0.03F;
            this.But_Company.BackColor = System.Drawing.Color.Transparent;
            this.But_Company.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(67)))), ((int)(((byte)(117)))));
            this.But_Company.BorderColor = System.Drawing.Color.Empty;
            this.But_Company.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.But_Company.CheckedBaseColor = System.Drawing.Color.White;
            this.But_Company.CheckedBorderColor = System.Drawing.Color.Empty;
            this.But_Company.CheckedForeColor = System.Drawing.Color.Empty;
            this.But_Company.CheckedImage = ((System.Drawing.Image)(resources.GetObject("But_Company.CheckedImage")));
            this.But_Company.CheckedLineColor = System.Drawing.Color.Empty;
            this.But_Company.Cursor = System.Windows.Forms.Cursors.Hand;
            this.But_Company.DialogResult = System.Windows.Forms.DialogResult.None;
            this.But_Company.FocusedColor = System.Drawing.Color.Empty;
            this.But_Company.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.But_Company.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(67)))), ((int)(((byte)(117)))));
            this.But_Company.Image = ((System.Drawing.Image)(resources.GetObject("But_Company.Image")));
            this.But_Company.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.But_Company.ImageSize = new System.Drawing.Size(35, 35);
            this.But_Company.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(67)))), ((int)(((byte)(117)))));
            this.But_Company.Location = new System.Drawing.Point(10, 426);
            this.But_Company.Name = "But_Company";
            this.But_Company.OnHoverBaseColor = System.Drawing.Color.Empty;
            this.But_Company.OnHoverBorderColor = System.Drawing.Color.Empty;
            this.But_Company.OnHoverForeColor = System.Drawing.Color.Empty;
            this.But_Company.OnHoverImage = null;
            this.But_Company.OnHoverLineColor = System.Drawing.Color.Empty;
            this.But_Company.OnPressedColor = System.Drawing.Color.Empty;
            this.But_Company.Radius = 14;
            this.But_Company.Size = new System.Drawing.Size(60, 51);
            this.But_Company.TabIndex = 7;
            this.But_Company.UseTransfarantBackground = true;
            this.But_Company.CheckedChanged += new System.EventHandler(this.But_Home_CheckedChanged);
            this.But_Company.Click += new System.EventHandler(this.But_Company_Click);
            // 
            // But_User
            // 
            this.But_User.AnimationHoverSpeed = 0.07F;
            this.But_User.AnimationSpeed = 0.03F;
            this.But_User.BackColor = System.Drawing.Color.Transparent;
            this.But_User.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(67)))), ((int)(((byte)(117)))));
            this.But_User.BorderColor = System.Drawing.Color.Empty;
            this.But_User.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.But_User.CheckedBaseColor = System.Drawing.Color.White;
            this.But_User.CheckedBorderColor = System.Drawing.Color.Empty;
            this.But_User.CheckedForeColor = System.Drawing.Color.Empty;
            this.But_User.CheckedImage = ((System.Drawing.Image)(resources.GetObject("But_User.CheckedImage")));
            this.But_User.CheckedLineColor = System.Drawing.Color.Empty;
            this.But_User.Cursor = System.Windows.Forms.Cursors.Hand;
            this.But_User.DialogResult = System.Windows.Forms.DialogResult.None;
            this.But_User.FocusedColor = System.Drawing.Color.Empty;
            this.But_User.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.But_User.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(67)))), ((int)(((byte)(117)))));
            this.But_User.Image = ((System.Drawing.Image)(resources.GetObject("But_User.Image")));
            this.But_User.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.But_User.ImageSize = new System.Drawing.Size(35, 35);
            this.But_User.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(67)))), ((int)(((byte)(117)))));
            this.But_User.Location = new System.Drawing.Point(10, 565);
            this.But_User.Name = "But_User";
            this.But_User.OnHoverBaseColor = System.Drawing.Color.Empty;
            this.But_User.OnHoverBorderColor = System.Drawing.Color.Empty;
            this.But_User.OnHoverForeColor = System.Drawing.Color.Empty;
            this.But_User.OnHoverImage = null;
            this.But_User.OnHoverLineColor = System.Drawing.Color.Empty;
            this.But_User.OnPressedColor = System.Drawing.Color.Empty;
            this.But_User.Radius = 14;
            this.But_User.Size = new System.Drawing.Size(60, 51);
            this.But_User.TabIndex = 6;
            this.But_User.UseTransfarantBackground = true;
            this.But_User.CheckedChanged += new System.EventHandler(this.But_Home_CheckedChanged);
            this.But_User.Click += new System.EventHandler(this.But_User_Click);
            // 
            // gunaAdvenceButton4
            // 
            this.gunaAdvenceButton4.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton4.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton4.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(67)))), ((int)(((byte)(117)))));
            this.gunaAdvenceButton4.BorderColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton4.CheckedBaseColor = System.Drawing.Color.White;
            this.gunaAdvenceButton4.CheckedBorderColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton4.CheckedForeColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton4.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton4.CheckedImage")));
            this.gunaAdvenceButton4.CheckedLineColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaAdvenceButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton4.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaAdvenceButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(67)))), ((int)(((byte)(117)))));
            this.gunaAdvenceButton4.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton4.Image")));
            this.gunaAdvenceButton4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton4.ImageSize = new System.Drawing.Size(35, 35);
            this.gunaAdvenceButton4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(67)))), ((int)(((byte)(117)))));
            this.gunaAdvenceButton4.Location = new System.Drawing.Point(10, 704);
            this.gunaAdvenceButton4.Name = "gunaAdvenceButton4";
            this.gunaAdvenceButton4.OnHoverBaseColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton4.OnHoverBorderColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton4.OnHoverForeColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton4.OnHoverImage = null;
            this.gunaAdvenceButton4.OnHoverLineColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton4.OnPressedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton4.Radius = 14;
            this.gunaAdvenceButton4.Size = new System.Drawing.Size(60, 51);
            this.gunaAdvenceButton4.TabIndex = 5;
            this.gunaAdvenceButton4.UseTransfarantBackground = true;
            this.gunaAdvenceButton4.Click += new System.EventHandler(this.gunaAdvenceButton4_Click);
            // 
            // But_Cars
            // 
            this.But_Cars.AnimationHoverSpeed = 0.07F;
            this.But_Cars.AnimationSpeed = 0.03F;
            this.But_Cars.BackColor = System.Drawing.Color.Transparent;
            this.But_Cars.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(67)))), ((int)(((byte)(117)))));
            this.But_Cars.BorderColor = System.Drawing.Color.Empty;
            this.But_Cars.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.But_Cars.CheckedBaseColor = System.Drawing.Color.White;
            this.But_Cars.CheckedBorderColor = System.Drawing.Color.Empty;
            this.But_Cars.CheckedForeColor = System.Drawing.Color.Empty;
            this.But_Cars.CheckedImage = ((System.Drawing.Image)(resources.GetObject("But_Cars.CheckedImage")));
            this.But_Cars.CheckedLineColor = System.Drawing.Color.Empty;
            this.But_Cars.Cursor = System.Windows.Forms.Cursors.Hand;
            this.But_Cars.DialogResult = System.Windows.Forms.DialogResult.None;
            this.But_Cars.FocusedColor = System.Drawing.Color.Empty;
            this.But_Cars.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.But_Cars.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(67)))), ((int)(((byte)(117)))));
            this.But_Cars.Image = ((System.Drawing.Image)(resources.GetObject("But_Cars.Image")));
            this.But_Cars.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.But_Cars.ImageSize = new System.Drawing.Size(35, 35);
            this.But_Cars.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(67)))), ((int)(((byte)(117)))));
            this.But_Cars.Location = new System.Drawing.Point(10, 287);
            this.But_Cars.Name = "But_Cars";
            this.But_Cars.OnHoverBaseColor = System.Drawing.Color.Empty;
            this.But_Cars.OnHoverBorderColor = System.Drawing.Color.Empty;
            this.But_Cars.OnHoverForeColor = System.Drawing.Color.Empty;
            this.But_Cars.OnHoverImage = null;
            this.But_Cars.OnHoverLineColor = System.Drawing.Color.Empty;
            this.But_Cars.OnPressedColor = System.Drawing.Color.Empty;
            this.But_Cars.Radius = 14;
            this.But_Cars.Size = new System.Drawing.Size(60, 51);
            this.But_Cars.TabIndex = 2;
            this.But_Cars.UseTransfarantBackground = true;
            this.But_Cars.CheckedChanged += new System.EventHandler(this.But_Home_CheckedChanged);
            this.But_Cars.Click += new System.EventHandler(this.But_Cars_Click);
            // 
            // But_Home
            // 
            this.But_Home.AnimationHoverSpeed = 0.07F;
            this.But_Home.AnimationSpeed = 0.03F;
            this.But_Home.BackColor = System.Drawing.Color.Transparent;
            this.But_Home.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(67)))), ((int)(((byte)(117)))));
            this.But_Home.BorderColor = System.Drawing.Color.Empty;
            this.But_Home.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.But_Home.Checked = true;
            this.But_Home.CheckedBaseColor = System.Drawing.Color.White;
            this.But_Home.CheckedBorderColor = System.Drawing.Color.Empty;
            this.But_Home.CheckedForeColor = System.Drawing.Color.Empty;
            this.But_Home.CheckedImage = ((System.Drawing.Image)(resources.GetObject("But_Home.CheckedImage")));
            this.But_Home.CheckedLineColor = System.Drawing.Color.Empty;
            this.But_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.But_Home.DialogResult = System.Windows.Forms.DialogResult.None;
            this.But_Home.FocusedColor = System.Drawing.Color.Empty;
            this.But_Home.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.But_Home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(67)))), ((int)(((byte)(117)))));
            this.But_Home.Image = ((System.Drawing.Image)(resources.GetObject("But_Home.Image")));
            this.But_Home.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.But_Home.ImageSize = new System.Drawing.Size(35, 35);
            this.But_Home.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(67)))), ((int)(((byte)(117)))));
            this.But_Home.Location = new System.Drawing.Point(8, 148);
            this.But_Home.Name = "But_Home";
            this.But_Home.OnHoverBaseColor = System.Drawing.Color.Empty;
            this.But_Home.OnHoverBorderColor = System.Drawing.Color.Empty;
            this.But_Home.OnHoverForeColor = System.Drawing.Color.Empty;
            this.But_Home.OnHoverImage = null;
            this.But_Home.OnHoverLineColor = System.Drawing.Color.Empty;
            this.But_Home.OnPressedColor = System.Drawing.Color.Empty;
            this.But_Home.Radius = 14;
            this.But_Home.Size = new System.Drawing.Size(60, 51);
            this.But_Home.TabIndex = 1;
            this.But_Home.UseTransfarantBackground = true;
            this.But_Home.CheckedChanged += new System.EventHandler(this.But_Home_CheckedChanged);
            this.But_Home.Click += new System.EventHandler(this.But_Home_Click);
            // 
            // Image_slide
            // 
            this.Image_slide.Image = ((System.Drawing.Image)(resources.GetObject("Image_slide.Image")));
            this.Image_slide.Location = new System.Drawing.Point(41, 119);
            this.Image_slide.Name = "Image_slide";
            this.Image_slide.Size = new System.Drawing.Size(46, 101);
            this.Image_slide.TabIndex = 3;
            this.Image_slide.TabStop = false;
            // 
            // PanelContainer
            // 
            this.PanelContainer.BackColor = System.Drawing.Color.White;
            this.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContainer.Location = new System.Drawing.Point(98, 0);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.Size = new System.Drawing.Size(1166, 820);
            this.PanelContainer.TabIndex = 1;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.gunaGradient2Panel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(98, 820);
            this.panel1.TabIndex = 0;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(8, 14);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(68, 60);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 8;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // Frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 820);
            this.Controls.Add(this.PanelContainer);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Home";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.gunaGradient2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Image_slide)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel1;
        private System.Windows.Forms.PictureBox Image_slide;
        private Guna.UI.WinForms.GunaAdvenceButton But_Home;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaAdvenceButton But_Cars;
        private Guna.UI.WinForms.GunaAdvenceButton But_User;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton4;
        private System.Windows.Forms.FlowLayoutPanel PanelContainer;
        private Guna.UI.WinForms.GunaAdvenceButton But_Company;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
    }
}