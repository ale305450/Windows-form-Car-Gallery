namespace CarGallery
{
    partial class Frm_AddCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AddCar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2CirclePictureBox3 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lbl_CarName = new System.Windows.Forms.Label();
            this.Lbl_Description = new System.Windows.Forms.Label();
            this.butAddImage = new Guna.UI.WinForms.GunaGradientTileButton();
            this.Lbl_Price = new System.Windows.Forms.Label();
            this.Lbl_Model = new System.Windows.Forms.Label();
            this.Lbl_Company = new System.Windows.Forms.Label();
            this.Lbl_ContactEmail = new System.Windows.Forms.Label();
            this.Lbl_ContactNumber = new System.Windows.Forms.Label();
            this.RbutForRent = new System.Windows.Forms.RadioButton();
            this.RbutForUsedSell = new System.Windows.Forms.RadioButton();
            this.Lbl_Length = new System.Windows.Forms.Label();
            this.txt_CarName = new Guna.UI.WinForms.GunaTextBox();
            this.txt_Model = new Guna.UI.WinForms.GunaTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.ComboBox_Company = new Guna.UI.WinForms.GunaComboBox();
            this.numericUpDown_Price = new System.Windows.Forms.NumericUpDown();
            this.txt_ContactNumber = new Guna.UI.WinForms.GunaTextBox();
            this.txt_ContactEmail = new Guna.UI.WinForms.GunaTextBox();
            this.ComboBox_Lenth = new Guna.UI.WinForms.GunaComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox_Car = new System.Windows.Forms.PictureBox();
            this.but_AddCar = new Guna.UI.WinForms.GunaGradientTileButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Car)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(67)))), ((int)(((byte)(117)))));
            this.panel1.Controls.Add(this.guna2CirclePictureBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1271, 80);
            this.panel1.TabIndex = 8;
            // 
            // guna2CirclePictureBox3
            // 
            this.guna2CirclePictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2CirclePictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox3.Image")));
            this.guna2CirclePictureBox3.Location = new System.Drawing.Point(1200, 13);
            this.guna2CirclePictureBox3.Name = "guna2CirclePictureBox3";
            this.guna2CirclePictureBox3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox3.ShadowDecoration.Parent = this.guna2CirclePictureBox3;
            this.guna2CirclePictureBox3.Size = new System.Drawing.Size(55, 58);
            this.guna2CirclePictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox3.TabIndex = 49;
            this.guna2CirclePictureBox3.TabStop = false;
            this.guna2CirclePictureBox3.Click += new System.EventHandler(this.guna2CirclePictureBox3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(570, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Car";
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
            // Lbl_CarName
            // 
            this.Lbl_CarName.AutoSize = true;
            this.Lbl_CarName.Location = new System.Drawing.Point(484, 123);
            this.Lbl_CarName.Name = "Lbl_CarName";
            this.Lbl_CarName.Size = new System.Drawing.Size(118, 23);
            this.Lbl_CarName.TabIndex = 9;
            this.Lbl_CarName.Text = "Car Name:";
            // 
            // Lbl_Description
            // 
            this.Lbl_Description.AutoSize = true;
            this.Lbl_Description.Location = new System.Drawing.Point(860, 445);
            this.Lbl_Description.Name = "Lbl_Description";
            this.Lbl_Description.Size = new System.Drawing.Size(122, 23);
            this.Lbl_Description.TabIndex = 10;
            this.Lbl_Description.Text = "Description:";
            // 
            // butAddImage
            // 
            this.butAddImage.AnimationHoverSpeed = 0.07F;
            this.butAddImage.AnimationSpeed = 0.03F;
            this.butAddImage.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(67)))), ((int)(((byte)(117)))));
            this.butAddImage.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(67)))), ((int)(((byte)(117)))));
            this.butAddImage.BorderColor = System.Drawing.Color.Transparent;
            this.butAddImage.DialogResult = System.Windows.Forms.DialogResult.None;
            this.butAddImage.FocusedColor = System.Drawing.Color.Empty;
            this.butAddImage.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.butAddImage.ForeColor = System.Drawing.Color.White;
            this.butAddImage.Image = null;
            this.butAddImage.ImageSize = new System.Drawing.Size(52, 52);
            this.butAddImage.Location = new System.Drawing.Point(125, 372);
            this.butAddImage.Name = "butAddImage";
            this.butAddImage.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.butAddImage.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.butAddImage.OnHoverBorderColor = System.Drawing.Color.Black;
            this.butAddImage.OnHoverForeColor = System.Drawing.Color.White;
            this.butAddImage.OnHoverImage = null;
            this.butAddImage.OnPressedColor = System.Drawing.Color.Black;
            this.butAddImage.Size = new System.Drawing.Size(238, 45);
            this.butAddImage.TabIndex = 12;
            this.butAddImage.Text = "Add Image";
            this.butAddImage.Click += new System.EventHandler(this.butAddImage_Click);
            // 
            // Lbl_Price
            // 
            this.Lbl_Price.AutoSize = true;
            this.Lbl_Price.Location = new System.Drawing.Point(860, 123);
            this.Lbl_Price.Name = "Lbl_Price";
            this.Lbl_Price.Size = new System.Drawing.Size(62, 23);
            this.Lbl_Price.TabIndex = 13;
            this.Lbl_Price.Text = "Price:";
            // 
            // Lbl_Model
            // 
            this.Lbl_Model.AutoSize = true;
            this.Lbl_Model.Location = new System.Drawing.Point(860, 220);
            this.Lbl_Model.Name = "Lbl_Model";
            this.Lbl_Model.Size = new System.Drawing.Size(77, 23);
            this.Lbl_Model.TabIndex = 14;
            this.Lbl_Model.Text = "Model:";
            // 
            // Lbl_Company
            // 
            this.Lbl_Company.AutoSize = true;
            this.Lbl_Company.Location = new System.Drawing.Point(488, 220);
            this.Lbl_Company.Name = "Lbl_Company";
            this.Lbl_Company.Size = new System.Drawing.Size(114, 23);
            this.Lbl_Company.TabIndex = 15;
            this.Lbl_Company.Text = "Company:";
            // 
            // Lbl_ContactEmail
            // 
            this.Lbl_ContactEmail.AutoSize = true;
            this.Lbl_ContactEmail.Location = new System.Drawing.Point(860, 335);
            this.Lbl_ContactEmail.Name = "Lbl_ContactEmail";
            this.Lbl_ContactEmail.Size = new System.Drawing.Size(161, 23);
            this.Lbl_ContactEmail.TabIndex = 17;
            this.Lbl_ContactEmail.Text = " Contact Email:";
            // 
            // Lbl_ContactNumber
            // 
            this.Lbl_ContactNumber.AutoSize = true;
            this.Lbl_ContactNumber.Location = new System.Drawing.Point(488, 335);
            this.Lbl_ContactNumber.Name = "Lbl_ContactNumber";
            this.Lbl_ContactNumber.Size = new System.Drawing.Size(182, 23);
            this.Lbl_ContactNumber.TabIndex = 16;
            this.Lbl_ContactNumber.Text = "Contact Number:";
            // 
            // RbutForRent
            // 
            this.RbutForRent.AutoSize = true;
            this.RbutForRent.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbutForRent.Location = new System.Drawing.Point(496, 489);
            this.RbutForRent.Name = "RbutForRent";
            this.RbutForRent.Size = new System.Drawing.Size(128, 27);
            this.RbutForRent.TabIndex = 18;
            this.RbutForRent.TabStop = true;
            this.RbutForRent.Text = "For Rent ?";
            this.RbutForRent.UseVisualStyleBackColor = true;
            this.RbutForRent.CheckedChanged += new System.EventHandler(this.RbutForRent_CheckedChanged);
            // 
            // RbutForUsedSell
            // 
            this.RbutForUsedSell.AutoSize = true;
            this.RbutForUsedSell.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbutForUsedSell.Location = new System.Drawing.Point(639, 489);
            this.RbutForUsedSell.Name = "RbutForUsedSell";
            this.RbutForUsedSell.Size = new System.Drawing.Size(161, 27);
            this.RbutForUsedSell.TabIndex = 19;
            this.RbutForUsedSell.TabStop = true;
            this.RbutForUsedSell.Text = "Sell as used  ?";
            this.RbutForUsedSell.UseVisualStyleBackColor = true;
            this.RbutForUsedSell.CheckedChanged += new System.EventHandler(this.RbutForRent_CheckedChanged);
            // 
            // Lbl_Length
            // 
            this.Lbl_Length.AutoSize = true;
            this.Lbl_Length.Location = new System.Drawing.Point(493, 538);
            this.Lbl_Length.Name = "Lbl_Length";
            this.Lbl_Length.Size = new System.Drawing.Size(81, 23);
            this.Lbl_Length.TabIndex = 20;
            this.Lbl_Length.Text = "Length:";
            // 
            // txt_CarName
            // 
            this.txt_CarName.BaseColor = System.Drawing.Color.White;
            this.txt_CarName.BorderColor = System.Drawing.Color.Silver;
            this.txt_CarName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CarName.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_CarName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_CarName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_CarName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_CarName.Location = new System.Drawing.Point(488, 160);
            this.txt_CarName.Name = "txt_CarName";
            this.txt_CarName.PasswordChar = '\0';
            this.txt_CarName.SelectedText = "";
            this.txt_CarName.Size = new System.Drawing.Size(287, 32);
            this.txt_CarName.TabIndex = 21;
            // 
            // txt_Model
            // 
            this.txt_Model.BaseColor = System.Drawing.Color.White;
            this.txt_Model.BorderColor = System.Drawing.Color.Silver;
            this.txt_Model.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Model.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Model.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_Model.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Model.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Model.Location = new System.Drawing.Point(864, 267);
            this.txt_Model.Name = "txt_Model";
            this.txt_Model.PasswordChar = '\0';
            this.txt_Model.SelectedText = "";
            this.txt_Model.Size = new System.Drawing.Size(287, 32);
            this.txt_Model.TabIndex = 22;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(864, 489);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(286, 172);
            this.richTextBox1.TabIndex = 23;
            this.richTextBox1.Text = "";
            // 
            // ComboBox_Company
            // 
            this.ComboBox_Company.BackColor = System.Drawing.Color.Transparent;
            this.ComboBox_Company.BaseColor = System.Drawing.Color.White;
            this.ComboBox_Company.BorderColor = System.Drawing.Color.Silver;
            this.ComboBox_Company.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_Company.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Company.FocusedColor = System.Drawing.Color.Empty;
            this.ComboBox_Company.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBox_Company.ForeColor = System.Drawing.Color.Black;
            this.ComboBox_Company.FormattingEnabled = true;
            this.ComboBox_Company.Location = new System.Drawing.Point(488, 267);
            this.ComboBox_Company.Name = "ComboBox_Company";
            this.ComboBox_Company.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ComboBox_Company.OnHoverItemForeColor = System.Drawing.Color.White;
            this.ComboBox_Company.Size = new System.Drawing.Size(287, 31);
            this.ComboBox_Company.TabIndex = 25;
            // 
            // numericUpDown_Price
            // 
            this.numericUpDown_Price.Location = new System.Drawing.Point(864, 160);
            this.numericUpDown_Price.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_Price.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_Price.Name = "numericUpDown_Price";
            this.numericUpDown_Price.Size = new System.Drawing.Size(287, 32);
            this.numericUpDown_Price.TabIndex = 26;
            this.numericUpDown_Price.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
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
            this.txt_ContactNumber.Location = new System.Drawing.Point(492, 372);
            this.txt_ContactNumber.Name = "txt_ContactNumber";
            this.txt_ContactNumber.PasswordChar = '\0';
            this.txt_ContactNumber.SelectedText = "";
            this.txt_ContactNumber.Size = new System.Drawing.Size(287, 32);
            this.txt_ContactNumber.TabIndex = 27;
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
            this.txt_ContactEmail.Location = new System.Drawing.Point(864, 377);
            this.txt_ContactEmail.Name = "txt_ContactEmail";
            this.txt_ContactEmail.PasswordChar = '\0';
            this.txt_ContactEmail.SelectedText = "";
            this.txt_ContactEmail.Size = new System.Drawing.Size(287, 32);
            this.txt_ContactEmail.TabIndex = 28;
            // 
            // ComboBox_Lenth
            // 
            this.ComboBox_Lenth.BackColor = System.Drawing.Color.Transparent;
            this.ComboBox_Lenth.BaseColor = System.Drawing.Color.White;
            this.ComboBox_Lenth.BorderColor = System.Drawing.Color.Silver;
            this.ComboBox_Lenth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_Lenth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Lenth.FocusedColor = System.Drawing.Color.Empty;
            this.ComboBox_Lenth.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBox_Lenth.ForeColor = System.Drawing.Color.Black;
            this.ComboBox_Lenth.FormattingEnabled = true;
            this.ComboBox_Lenth.Location = new System.Drawing.Point(497, 582);
            this.ComboBox_Lenth.Name = "ComboBox_Lenth";
            this.ComboBox_Lenth.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ComboBox_Lenth.OnHoverItemForeColor = System.Drawing.Color.White;
            this.ComboBox_Lenth.Size = new System.Drawing.Size(287, 31);
            this.ComboBox_Lenth.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(493, 440);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 23);
            this.label2.TabIndex = 30;
            this.label2.Text = "Is the car:";
            // 
            // pictureBox_Car
            // 
            this.pictureBox_Car.Location = new System.Drawing.Point(22, 104);
            this.pictureBox_Car.Name = "pictureBox_Car";
            this.pictureBox_Car.Size = new System.Drawing.Size(447, 254);
            this.pictureBox_Car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Car.TabIndex = 11;
            this.pictureBox_Car.TabStop = false;
            // 
            // but_AddCar
            // 
            this.but_AddCar.AnimationHoverSpeed = 0.07F;
            this.but_AddCar.AnimationSpeed = 0.03F;
            this.but_AddCar.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(67)))), ((int)(((byte)(117)))));
            this.but_AddCar.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(67)))), ((int)(((byte)(117)))));
            this.but_AddCar.BorderColor = System.Drawing.Color.Transparent;
            this.but_AddCar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.but_AddCar.FocusedColor = System.Drawing.Color.Empty;
            this.but_AddCar.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.but_AddCar.ForeColor = System.Drawing.Color.White;
            this.but_AddCar.Image = null;
            this.but_AddCar.ImageSize = new System.Drawing.Size(52, 52);
            this.but_AddCar.Location = new System.Drawing.Point(497, 711);
            this.but_AddCar.Name = "but_AddCar";
            this.but_AddCar.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.but_AddCar.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.but_AddCar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.but_AddCar.OnHoverForeColor = System.Drawing.Color.White;
            this.but_AddCar.OnHoverImage = null;
            this.but_AddCar.OnPressedColor = System.Drawing.Color.Black;
            this.but_AddCar.Size = new System.Drawing.Size(238, 45);
            this.but_AddCar.TabIndex = 31;
            this.but_AddCar.Text = "Add Car";
            this.but_AddCar.Click += new System.EventHandler(this.but_AddCar_Click);
            // 
            // Frm_AddCar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 820);
            this.ControlBox = false;
            this.Controls.Add(this.but_AddCar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComboBox_Lenth);
            this.Controls.Add(this.txt_ContactEmail);
            this.Controls.Add(this.txt_ContactNumber);
            this.Controls.Add(this.numericUpDown_Price);
            this.Controls.Add(this.ComboBox_Company);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txt_Model);
            this.Controls.Add(this.txt_CarName);
            this.Controls.Add(this.Lbl_Length);
            this.Controls.Add(this.RbutForUsedSell);
            this.Controls.Add(this.RbutForRent);
            this.Controls.Add(this.Lbl_ContactEmail);
            this.Controls.Add(this.Lbl_ContactNumber);
            this.Controls.Add(this.Lbl_Company);
            this.Controls.Add(this.Lbl_Model);
            this.Controls.Add(this.Lbl_Price);
            this.Controls.Add(this.butAddImage);
            this.Controls.Add(this.pictureBox_Car);
            this.Controls.Add(this.Lbl_Description);
            this.Controls.Add(this.Lbl_CarName);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_AddCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Car";
            this.Load += new System.EventHandler(this.Frm_AddCar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Car)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label Lbl_CarName;
        public System.Windows.Forms.Label Lbl_Description;
        public System.Windows.Forms.PictureBox pictureBox_Car;
        public Guna.UI.WinForms.GunaGradientTileButton butAddImage;
        public System.Windows.Forms.Label Lbl_Price;
        public System.Windows.Forms.Label Lbl_Model;
        public System.Windows.Forms.Label Lbl_Company;
        public System.Windows.Forms.Label Lbl_ContactEmail;
        public System.Windows.Forms.Label Lbl_ContactNumber;
        public System.Windows.Forms.RadioButton RbutForRent;
        public System.Windows.Forms.RadioButton RbutForUsedSell;
        public System.Windows.Forms.Label Lbl_Length;
        public Guna.UI.WinForms.GunaTextBox txt_CarName;
        public Guna.UI.WinForms.GunaTextBox txt_Model;
        public System.Windows.Forms.RichTextBox richTextBox1;
        public Guna.UI.WinForms.GunaComboBox ComboBox_Company;
        public System.Windows.Forms.NumericUpDown numericUpDown_Price;
        public Guna.UI.WinForms.GunaTextBox txt_ContactNumber;
        public Guna.UI.WinForms.GunaTextBox txt_ContactEmail;
        public Guna.UI.WinForms.GunaComboBox ComboBox_Lenth;
        public System.Windows.Forms.Label label2;
        public Guna.UI.WinForms.GunaGradientTileButton but_AddCar;
        public Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox3;
    }
}

