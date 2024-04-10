using CarGallery.Logic.Presenter;
using CarGallery.View.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarGallery.Presenter.Forms
{
    public partial class UserControl_Main : UserControl, IMain
    {
        Frm_CarDetails frm_CarDetails = new Frm_CarDetails();
        MainPresenter mainPresenter;
        private byte[] Carimage1;
        private byte[] Carimage2;
        private byte[] Carimage3;

        private byte[] Companyimage1;
        private byte[] Companyimage2;
        private byte[] Companyimage3;
        public UserControl_Main()
        {
            InitializeComponent();
            mainPresenter = new MainPresenter(this);
            mainPresenter.GetCars();
        }

        public string CarName_1 { get => Lbl_Car1Name.Text; set => Lbl_Car1Name.Text = value; }
        public string CarPrice_1 { get => Lbl_Car1Price.Text; set => Lbl_Car1Price.Text = value; }
        public string CarModel_1 { get => frm_CarDetails.txt_Model.Text; set => frm_CarDetails.txt_Model.Text = value; }
        public byte[] CarImage_1 { set => setCarImage1(value); }
        public byte[] CarImageDetails_1 { get { return Carimage1; } set { Carimage1 = value; } }
        public byte[] CompanyImage_1 { get { return Companyimage1; } set { Companyimage1 = value; } }
        public string CarName_2  { get => Lbl_Car2Name.Text; set => Lbl_Car2Name.Text = value; }
        public string CarPrice_2 { get => Lbl_Car2Price.Text; set => Lbl_Car2Price.Text = value; }
        public string CarModel_2 { get => frm_CarDetails.txt_Model.Text; set => frm_CarDetails.txt_Model.Text = value; }
        public byte[] CarImage_2 {set => setCarImage2(value); }
        public byte[] CarImageDetails_2 { get { return Carimage2; } set { Carimage2 = value; } }
        public byte[] CompanyImage_2 { get { return Companyimage2; } set { Companyimage2 = value; } }
        public string CarName_3 {   get => Lbl_Car3Name.Text; set => Lbl_Car3Name.Text = value; }
        public string CarPrice_3 {  get => Lbl_Car3Price.Text; set => Lbl_Car3Price.Text = value; }
        public string CarModel_3 { get => frm_CarDetails.txt_Model.Text; set => frm_CarDetails.txt_Model.Text = value; }
        public byte[] CarImage_3 { set => setCarImage3(value); }
        public byte[] CarImageDetails_3 { get { return Carimage3; } set { Carimage3 = value; } }
        public byte[] CompanyImage_3 { get { return Companyimage3; } set { Companyimage3 = value; } }

        public void setCarImage1(byte[] value)
        {
            if (value != null && value.Length > 0)
            {
                MemoryStream ms = new MemoryStream(value);
                pictureBox1.Image = Image.FromStream(ms);
            }
            else { pictureBox1.Image = null; }
        }
        public void setCarImage2(byte[] value)
        {
            if (value != null && value.Length > 0)
            {
                MemoryStream ms = new MemoryStream(value);
                pictureBox2.Image = Image.FromStream(ms);
            }
            else { pictureBox2.Image = null; }
        }
        public void setCarImage3(byte[] value)
        {
            if (value != null && value.Length > 0)
            {
                MemoryStream ms = new MemoryStream(value);
                pictureBox3.Image = Image.FromStream(ms);
            }
            else { pictureBox3.Image = null; }
        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            Frm_CarDetails frm_CarDetails = new Frm_CarDetails();
            frm_CarDetails.Show();
            frm_CarDetails.txt_CarName.Text = CarName_1;
            frm_CarDetails.txt_Price.Text = CarPrice_1;
            frm_CarDetails.txt_Model.Text = CarModel_1;
            frm_CarDetails.setCarImage(Carimage1);
            frm_CarDetails.setCarLogo(CompanyImage_1);
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            Frm_CarDetails frm_CarDetails = new Frm_CarDetails();
            frm_CarDetails.Show();
            frm_CarDetails.txt_CarName.Text = CarName_2;
            frm_CarDetails.txt_Price.Text = CarPrice_2;
            frm_CarDetails.txt_Model.Text = CarModel_2;
            frm_CarDetails.setCarImage(Carimage2);
            frm_CarDetails.setCarLogo(CompanyImage_2);
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            Frm_CarDetails frm_CarDetails = new Frm_CarDetails();
            frm_CarDetails.Show();
            frm_CarDetails.txt_CarName.Text = CarName_3;
            frm_CarDetails.txt_Price.Text = CarPrice_3;
            frm_CarDetails.txt_Model.Text = CarModel_3;
            frm_CarDetails.setCarImage(Carimage3);
            frm_CarDetails.setCarLogo(CompanyImage_3);

        }
    }
}
