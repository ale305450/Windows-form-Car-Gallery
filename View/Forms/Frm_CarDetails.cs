using CarGallery.Presenter.Interface;
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
    public partial class Frm_CarDetails : Form, ICarDetails
    {
        public Frm_CarDetails()
        {
            InitializeComponent();
        }

        public byte[] CarPic { set { setCarImage(value);} }
        public byte[] companyLogo { set { setCarLogo(value); } }
        public string CarNametxtbox { get => txt_CarName.Text; set => txt_CarName.Text = value; }
        public string CarPricetxtbox { get => txt_Price.Text; set => txt_Price.Text = value; }
        public string CarModeltxtbox { get => txt_Model.Text; set => txt_Model.Text = value; }

        public void setCarImage(byte[] value)
        {
            if (value != null && value.Length > 0)
            {
                MemoryStream ms = new MemoryStream(value);
                PictureBox_car.Image = Image.FromStream(ms);
            }
            else { PictureBox_car.Image = null; }
        }
        public void setCarLogo(byte[] value)
        {
            if (value != null && value.Length > 0)
            {
                MemoryStream ms = new MemoryStream(value);
                PictureBox_Company.Image = Image.FromStream(ms);
            }
            else { PictureBox_Company.Image = null; }
        }


        private void but_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
