namespace CarGallery.Presenter.Forms
{
    partial class Frm_SignUp
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
            this.PictureBox_User = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.butAddImage = new Guna.UI.WinForms.GunaGradientTileButton();
            this.butCreate = new Guna.UI.WinForms.GunaGradientTileButton();
            this.btnCancel = new Guna.UI.WinForms.GunaGradientTileButton();
            this.Lbl_Gender = new System.Windows.Forms.Label();
            this.txt_ContactEmail = new Guna.UI.WinForms.GunaTextBox();
            this.txt_Password = new Guna.UI.WinForms.GunaTextBox();
            this.ComboBox_Gender = new Guna.UI.WinForms.GunaComboBox();
            this.txt_FullName = new Guna.UI.WinForms.GunaTextBox();
            this.Lbl_ContactEmail = new System.Windows.Forms.Label();
            this.Lbl_ContactNumber = new System.Windows.Forms.Label();
            this.Lbl_Password = new System.Windows.Forms.Label();
            this.Lbl_FullName = new System.Windows.Forms.Label();
            this.txt_ContactNumber = new Guna.UI.WinForms.GunaTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_User)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox_User
            // 
            this.PictureBox_User.BaseColor = System.Drawing.Color.White;
            this.PictureBox_User.Location = new System.Drawing.Point(110, 12);
            this.PictureBox_User.Name = "PictureBox_User";
            this.PictureBox_User.Size = new System.Drawing.Size(120, 120);
            this.PictureBox_User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox_User.TabIndex = 0;
            this.PictureBox_User.TabStop = false;
            this.PictureBox_User.UseTransfarantBackground = false;
            // 
            // butAddImage
            // 
            this.butAddImage.AnimationHoverSpeed = 0.07F;
            this.butAddImage.AnimationSpeed = 0.03F;
            this.butAddImage.BackColor = System.Drawing.Color.White;
            this.butAddImage.BaseColor1 = System.Drawing.Color.White;
            this.butAddImage.BaseColor2 = System.Drawing.Color.White;
            this.butAddImage.BorderColor = System.Drawing.Color.Transparent;
            this.butAddImage.DialogResult = System.Windows.Forms.DialogResult.None;
            this.butAddImage.FocusedColor = System.Drawing.Color.Empty;
            this.butAddImage.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.butAddImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(67)))), ((int)(((byte)(117)))));
            this.butAddImage.Image = null;
            this.butAddImage.ImageSize = new System.Drawing.Size(52, 52);
            this.butAddImage.Location = new System.Drawing.Point(117, 608);
            this.butAddImage.Name = "butAddImage";
            this.butAddImage.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.butAddImage.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.butAddImage.OnHoverBorderColor = System.Drawing.Color.Black;
            this.butAddImage.OnHoverForeColor = System.Drawing.Color.White;
            this.butAddImage.OnHoverImage = null;
            this.butAddImage.OnPressedColor = System.Drawing.Color.Black;
            this.butAddImage.Size = new System.Drawing.Size(130, 45);
            this.butAddImage.TabIndex = 36;
            this.butAddImage.Text = "Add Image";
            this.butAddImage.Click += new System.EventHandler(this.butAddImage_Click);
            // 
            // butCreate
            // 
            this.butCreate.AnimationHoverSpeed = 0.07F;
            this.butCreate.AnimationSpeed = 0.03F;
            this.butCreate.BackColor = System.Drawing.Color.White;
            this.butCreate.BaseColor1 = System.Drawing.Color.White;
            this.butCreate.BaseColor2 = System.Drawing.Color.White;
            this.butCreate.BorderColor = System.Drawing.Color.Transparent;
            this.butCreate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.butCreate.FocusedColor = System.Drawing.Color.Empty;
            this.butCreate.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.butCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(67)))), ((int)(((byte)(117)))));
            this.butCreate.Image = null;
            this.butCreate.ImageSize = new System.Drawing.Size(52, 52);
            this.butCreate.Location = new System.Drawing.Point(19, 685);
            this.butCreate.Name = "butCreate";
            this.butCreate.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.butCreate.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.butCreate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.butCreate.OnHoverForeColor = System.Drawing.Color.White;
            this.butCreate.OnHoverImage = null;
            this.butCreate.OnPressedColor = System.Drawing.Color.Black;
            this.butCreate.Size = new System.Drawing.Size(130, 45);
            this.butCreate.TabIndex = 37;
            this.butCreate.Text = "Create";
            this.butCreate.Click += new System.EventHandler(this.butCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AnimationHoverSpeed = 0.07F;
            this.btnCancel.AnimationSpeed = 0.03F;
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.BaseColor1 = System.Drawing.Color.White;
            this.btnCancel.BaseColor2 = System.Drawing.Color.White;
            this.btnCancel.BorderColor = System.Drawing.Color.Transparent;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancel.FocusedColor = System.Drawing.Color.Empty;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(67)))), ((int)(((byte)(117)))));
            this.btnCancel.Image = null;
            this.btnCancel.ImageSize = new System.Drawing.Size(52, 52);
            this.btnCancel.Location = new System.Drawing.Point(201, 685);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnCancel.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnCancel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCancel.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCancel.OnHoverImage = null;
            this.btnCancel.OnPressedColor = System.Drawing.Color.Black;
            this.btnCancel.Size = new System.Drawing.Size(130, 45);
            this.btnCancel.TabIndex = 38;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Lbl_Gender
            // 
            this.Lbl_Gender.AutoSize = true;
            this.Lbl_Gender.ForeColor = System.Drawing.Color.White;
            this.Lbl_Gender.Location = new System.Drawing.Point(31, 331);
            this.Lbl_Gender.Name = "Lbl_Gender";
            this.Lbl_Gender.Size = new System.Drawing.Size(90, 23);
            this.Lbl_Gender.TabIndex = 49;
            this.Lbl_Gender.Text = "Gender:";
            // 
            // txt_ContactEmail
            // 
            this.txt_ContactEmail.BaseColor = System.Drawing.Color.White;
            this.txt_ContactEmail.BorderColor = System.Drawing.Color.Silver;
            this.txt_ContactEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ContactEmail.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_ContactEmail.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_ContactEmail.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_ContactEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_ContactEmail.Location = new System.Drawing.Point(33, 454);
            this.txt_ContactEmail.Name = "txt_ContactEmail";
            this.txt_ContactEmail.PasswordChar = '\0';
            this.txt_ContactEmail.SelectedText = "";
            this.txt_ContactEmail.Size = new System.Drawing.Size(287, 30);
            this.txt_ContactEmail.TabIndex = 48;
            // 
            // txt_Password
            // 
            this.txt_Password.BaseColor = System.Drawing.Color.White;
            this.txt_Password.BorderColor = System.Drawing.Color.Silver;
            this.txt_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Password.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Password.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_Password.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Password.Location = new System.Drawing.Point(33, 287);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.SelectedText = "";
            this.txt_Password.Size = new System.Drawing.Size(287, 30);
            this.txt_Password.TabIndex = 47;
            // 
            // ComboBox_Gender
            // 
            this.ComboBox_Gender.BackColor = System.Drawing.Color.Transparent;
            this.ComboBox_Gender.BaseColor = System.Drawing.Color.White;
            this.ComboBox_Gender.BorderColor = System.Drawing.Color.Silver;
            this.ComboBox_Gender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Gender.FocusedColor = System.Drawing.Color.Empty;
            this.ComboBox_Gender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBox_Gender.ForeColor = System.Drawing.Color.Black;
            this.ComboBox_Gender.FormattingEnabled = true;
            this.ComboBox_Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.ComboBox_Gender.Location = new System.Drawing.Point(35, 370);
            this.ComboBox_Gender.Name = "ComboBox_Gender";
            this.ComboBox_Gender.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ComboBox_Gender.OnHoverItemForeColor = System.Drawing.Color.White;
            this.ComboBox_Gender.Size = new System.Drawing.Size(287, 31);
            this.ComboBox_Gender.TabIndex = 46;
            // 
            // txt_FullName
            // 
            this.txt_FullName.BaseColor = System.Drawing.Color.White;
            this.txt_FullName.BorderColor = System.Drawing.Color.Silver;
            this.txt_FullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_FullName.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_FullName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_FullName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_FullName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_FullName.Location = new System.Drawing.Point(33, 208);
            this.txt_FullName.Name = "txt_FullName";
            this.txt_FullName.PasswordChar = '\0';
            this.txt_FullName.SelectedText = "";
            this.txt_FullName.Size = new System.Drawing.Size(287, 30);
            this.txt_FullName.TabIndex = 45;
            // 
            // Lbl_ContactEmail
            // 
            this.Lbl_ContactEmail.AutoSize = true;
            this.Lbl_ContactEmail.ForeColor = System.Drawing.Color.White;
            this.Lbl_ContactEmail.Location = new System.Drawing.Point(29, 417);
            this.Lbl_ContactEmail.Name = "Lbl_ContactEmail";
            this.Lbl_ContactEmail.Size = new System.Drawing.Size(161, 23);
            this.Lbl_ContactEmail.TabIndex = 44;
            this.Lbl_ContactEmail.Text = " Contact Email:";
            // 
            // Lbl_ContactNumber
            // 
            this.Lbl_ContactNumber.AutoSize = true;
            this.Lbl_ContactNumber.ForeColor = System.Drawing.Color.White;
            this.Lbl_ContactNumber.Location = new System.Drawing.Point(31, 505);
            this.Lbl_ContactNumber.Name = "Lbl_ContactNumber";
            this.Lbl_ContactNumber.Size = new System.Drawing.Size(182, 23);
            this.Lbl_ContactNumber.TabIndex = 43;
            this.Lbl_ContactNumber.Text = "Contact Number:";
            // 
            // Lbl_Password
            // 
            this.Lbl_Password.AutoSize = true;
            this.Lbl_Password.ForeColor = System.Drawing.Color.White;
            this.Lbl_Password.Location = new System.Drawing.Point(31, 251);
            this.Lbl_Password.Name = "Lbl_Password";
            this.Lbl_Password.Size = new System.Drawing.Size(108, 23);
            this.Lbl_Password.TabIndex = 42;
            this.Lbl_Password.Text = "Password:";
            // 
            // Lbl_FullName
            // 
            this.Lbl_FullName.AutoSize = true;
            this.Lbl_FullName.ForeColor = System.Drawing.Color.White;
            this.Lbl_FullName.Location = new System.Drawing.Point(29, 171);
            this.Lbl_FullName.Name = "Lbl_FullName";
            this.Lbl_FullName.Size = new System.Drawing.Size(114, 23);
            this.Lbl_FullName.TabIndex = 39;
            this.Lbl_FullName.Text = "Full Name:";
            // 
            // txt_ContactNumber
            // 
            this.txt_ContactNumber.BaseColor = System.Drawing.Color.White;
            this.txt_ContactNumber.BorderColor = System.Drawing.Color.Silver;
            this.txt_ContactNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ContactNumber.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_ContactNumber.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_ContactNumber.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_ContactNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_ContactNumber.Location = new System.Drawing.Point(35, 540);
            this.txt_ContactNumber.Name = "txt_ContactNumber";
            this.txt_ContactNumber.PasswordChar = '\0';
            this.txt_ContactNumber.SelectedText = "";
            this.txt_ContactNumber.Size = new System.Drawing.Size(287, 32);
            this.txt_ContactNumber.TabIndex = 50;
            // 
            // Frm_SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(67)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(362, 752);
            this.ControlBox = false;
            this.Controls.Add(this.txt_ContactNumber);
            this.Controls.Add(this.Lbl_Gender);
            this.Controls.Add(this.txt_ContactEmail);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.ComboBox_Gender);
            this.Controls.Add(this.txt_FullName);
            this.Controls.Add(this.Lbl_ContactEmail);
            this.Controls.Add(this.Lbl_ContactNumber);
            this.Controls.Add(this.Lbl_Password);
            this.Controls.Add(this.Lbl_FullName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.butCreate);
            this.Controls.Add(this.butAddImage);
            this.Controls.Add(this.PictureBox_User);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_SignUp";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_AddUser";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_User)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI.WinForms.GunaCirclePictureBox PictureBox_User;
        public Guna.UI.WinForms.GunaGradientTileButton butAddImage;
        public Guna.UI.WinForms.GunaGradientTileButton butCreate;
        public Guna.UI.WinForms.GunaGradientTileButton btnCancel;
        public System.Windows.Forms.Label Lbl_Gender;
        public Guna.UI.WinForms.GunaTextBox txt_ContactEmail;
        public Guna.UI.WinForms.GunaTextBox txt_Password;
        public Guna.UI.WinForms.GunaComboBox ComboBox_Gender;
        public Guna.UI.WinForms.GunaTextBox txt_FullName;
        public System.Windows.Forms.Label Lbl_ContactEmail;
        public System.Windows.Forms.Label Lbl_ContactNumber;
        public System.Windows.Forms.Label Lbl_Password;
        public System.Windows.Forms.Label Lbl_FullName;
        public Guna.UI.WinForms.GunaTextBox txt_ContactNumber;
    }
}