namespace CarGallery.Presenter.Forms
{
    partial class Frm_CarDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CarDetails));
            this.txt_Model = new Guna.UI.WinForms.GunaTextBox();
            this.txt_CarName = new Guna.UI.WinForms.GunaTextBox();
            this.Lbl_Model = new System.Windows.Forms.Label();
            this.Lbl_Price = new System.Windows.Forms.Label();
            this.Lbl_CarName = new System.Windows.Forms.Label();
            this.but_Close = new Guna.UI.WinForms.GunaGradientTileButton();
            this.PictureBox_Company = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PictureBox_car = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_Price = new Guna.UI.WinForms.GunaTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Company)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_car)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Model
            // 
            this.txt_Model.BaseColor = System.Drawing.Color.White;
            this.txt_Model.BorderColor = System.Drawing.Color.Silver;
            this.txt_Model.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Model.Enabled = false;
            this.txt_Model.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Model.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_Model.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Model.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Model.Location = new System.Drawing.Point(496, 315);
            this.txt_Model.Name = "txt_Model";
            this.txt_Model.PasswordChar = '\0';
            this.txt_Model.SelectedText = "";
            this.txt_Model.Size = new System.Drawing.Size(287, 30);
            this.txt_Model.TabIndex = 31;
            // 
            // txt_CarName
            // 
            this.txt_CarName.BaseColor = System.Drawing.Color.White;
            this.txt_CarName.BorderColor = System.Drawing.Color.Silver;
            this.txt_CarName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CarName.Enabled = false;
            this.txt_CarName.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_CarName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_CarName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_CarName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_CarName.Location = new System.Drawing.Point(497, 147);
            this.txt_CarName.Name = "txt_CarName";
            this.txt_CarName.PasswordChar = '\0';
            this.txt_CarName.SelectedText = "";
            this.txt_CarName.Size = new System.Drawing.Size(287, 30);
            this.txt_CarName.TabIndex = 30;
            // 
            // Lbl_Model
            // 
            this.Lbl_Model.AutoSize = true;
            this.Lbl_Model.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Model.Location = new System.Drawing.Point(492, 278);
            this.Lbl_Model.Name = "Lbl_Model";
            this.Lbl_Model.Size = new System.Drawing.Size(70, 23);
            this.Lbl_Model.TabIndex = 29;
            this.Lbl_Model.Text = "Model:";
            // 
            // Lbl_Price
            // 
            this.Lbl_Price.AutoSize = true;
            this.Lbl_Price.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Price.Location = new System.Drawing.Point(493, 197);
            this.Lbl_Price.Name = "Lbl_Price";
            this.Lbl_Price.Size = new System.Drawing.Size(61, 23);
            this.Lbl_Price.TabIndex = 28;
            this.Lbl_Price.Text = "Price:";
            // 
            // Lbl_CarName
            // 
            this.Lbl_CarName.AutoSize = true;
            this.Lbl_CarName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CarName.Location = new System.Drawing.Point(493, 110);
            this.Lbl_CarName.Name = "Lbl_CarName";
            this.Lbl_CarName.Size = new System.Drawing.Size(103, 23);
            this.Lbl_CarName.TabIndex = 27;
            this.Lbl_CarName.Text = "Car Name:";
            // 
            // but_Close
            // 
            this.but_Close.AnimationHoverSpeed = 0.07F;
            this.but_Close.AnimationSpeed = 0.03F;
            this.but_Close.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(67)))), ((int)(((byte)(117)))));
            this.but_Close.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(67)))), ((int)(((byte)(117)))));
            this.but_Close.BorderColor = System.Drawing.Color.Transparent;
            this.but_Close.DialogResult = System.Windows.Forms.DialogResult.None;
            this.but_Close.FocusedColor = System.Drawing.Color.Empty;
            this.but_Close.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.but_Close.ForeColor = System.Drawing.Color.White;
            this.but_Close.Image = null;
            this.but_Close.ImageSize = new System.Drawing.Size(52, 52);
            this.but_Close.Location = new System.Drawing.Point(295, 397);
            this.but_Close.Name = "but_Close";
            this.but_Close.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.but_Close.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.but_Close.OnHoverBorderColor = System.Drawing.Color.Black;
            this.but_Close.OnHoverForeColor = System.Drawing.Color.White;
            this.but_Close.OnHoverImage = null;
            this.but_Close.OnPressedColor = System.Drawing.Color.Black;
            this.but_Close.Size = new System.Drawing.Size(238, 45);
            this.but_Close.TabIndex = 36;
            this.but_Close.Text = "Close";
            this.but_Close.Click += new System.EventHandler(this.but_Close_Click);
            // 
            // PictureBox_Company
            // 
            this.PictureBox_Company.Location = new System.Drawing.Point(295, 102);
            this.PictureBox_Company.Name = "PictureBox_Company";
            this.PictureBox_Company.ShadowDecoration.Parent = this.PictureBox_Company;
            this.PictureBox_Company.Size = new System.Drawing.Size(137, 101);
            this.PictureBox_Company.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox_Company.TabIndex = 1;
            this.PictureBox_Company.TabStop = false;
            // 
            // PictureBox_car
            // 
            this.PictureBox_car.Location = new System.Drawing.Point(12, 86);
            this.PictureBox_car.Name = "PictureBox_car";
            this.PictureBox_car.ShadowDecoration.Parent = this.PictureBox_car;
            this.PictureBox_car.Size = new System.Drawing.Size(254, 189);
            this.PictureBox_car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox_car.TabIndex = 0;
            this.PictureBox_car.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(67)))), ((int)(((byte)(117)))));
            this.panel1.Controls.Add(this.guna2CirclePictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 80);
            this.panel1.TabIndex = 37;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(753, 12);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(55, 58);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 50;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.Click += new System.EventHandler(this.guna2CirclePictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(313, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Car Details";
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
            // txt_Price
            // 
            this.txt_Price.BaseColor = System.Drawing.Color.White;
            this.txt_Price.BorderColor = System.Drawing.Color.Silver;
            this.txt_Price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Price.Enabled = false;
            this.txt_Price.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Price.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_Price.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Price.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Price.Location = new System.Drawing.Point(496, 236);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.PasswordChar = '\0';
            this.txt_Price.SelectedText = "";
            this.txt_Price.Size = new System.Drawing.Size(287, 30);
            this.txt_Price.TabIndex = 49;
            // 
            // Frm_CarDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 474);
            this.ControlBox = false;
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.but_Close);
            this.Controls.Add(this.txt_Model);
            this.Controls.Add(this.txt_CarName);
            this.Controls.Add(this.Lbl_Model);
            this.Controls.Add(this.Lbl_Price);
            this.Controls.Add(this.Lbl_CarName);
            this.Controls.Add(this.PictureBox_Company);
            this.Controls.Add(this.PictureBox_car);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_CarDetails";
            this.Text = "Frm_Details";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Company)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_car)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI2.WinForms.Guna2PictureBox PictureBox_car;
        public Guna.UI2.WinForms.Guna2PictureBox PictureBox_Company;
        public Guna.UI.WinForms.GunaTextBox txt_Model;
        public Guna.UI.WinForms.GunaTextBox txt_CarName;
        public System.Windows.Forms.Label Lbl_Model;
        public System.Windows.Forms.Label Lbl_Price;
        public System.Windows.Forms.Label Lbl_CarName;
        public Guna.UI.WinForms.GunaGradientTileButton but_Close;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox pictureBox1;
        public Guna.UI.WinForms.GunaTextBox txt_Price;
        public Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
    }
}