using CarGallery.Logic.Presenter;
using CarGallery.Presenter.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Guna.UI.WinForms;

namespace CarGallery
{
    public partial class Frm_AddCar : Form, IAddCar
    {
        private string message;
        AddCarPresenter addCarPresenter;
        public GunaGradientTileButton gunaGradientTileButton;
        public event EventHandler EditCar_butclick;

        public Frm_AddCar()
        {
            InitializeComponent();
            addCarPresenter = new AddCarPresenter(this);
            this.gunaGradientTileButton = but_AddCar;
        }
        public string CarName { get => txt_CarName.Text; set => txt_CarName.Text = value; }
        public string Description { get => richTextBox1.Text; set => richTextBox1.Text = value; }
        public string ContactNum { get => txt_ContactNumber.Text; set => txt_ContactNumber.Text = value; }
        public string ContactEmail { get => txt_ContactEmail.Text; set => txt_ContactEmail.Text = value; }
        public int price { get => Convert.ToInt32(numericUpDown_Price.Value); set => numericUpDown_Price.Value = value; }
        public string Model { get => txt_Model.Text; set => txt_Model.Text = value; }
        public object comboxCompany { get => ComboBox_Company.DataSource; set => ComboBox_Company.DataSource = value; }
        public int company_id { get => Convert.ToInt32(ComboBox_Company.SelectedValue); set => ComboBox_Company.SelectedValue = value; }
        public string CompanyValueMember { get => ComboBox_Company.ValueMember; set => ComboBox_Company.ValueMember = value; }
        string IAddCar.CompanyDisplayMember { get => ComboBox_Company.DisplayMember; set => ComboBox_Company.DisplayMember = value; }
        public string Length { get => Convert.ToString(ComboBox_Lenth.SelectedValue); set => ComboBox_Lenth.SelectedValue = value; }
        public object RadiobutRent { get => RbutForRent.Checked; set => RbutForRent.Checked = Convert.ToBoolean(value); }
        public object RadiobutUsed { get => RbutForUsedSell.Checked; set => RbutForUsedSell.Checked = Convert.ToBoolean(value); }
        public int Rent_id { get => Convert.ToInt32(ComboBox_Lenth.SelectedValue); set => ComboBox_Lenth.SelectedValue = value; }
        public int Used_id { get => Convert.ToInt32(ComboBox_Lenth.SelectedValue); set => ComboBox_Lenth.SelectedValue = value; }
        public object combox_Length { get => ComboBox_Lenth.DataSource; set => ComboBox_Lenth.DataSource = value; }
        public string LengthValueMember { get => ComboBox_Lenth.ValueMember; set => ComboBox_Lenth.ValueMember = value; }
        public string LengthDisplayMember { get => ComboBox_Lenth.DisplayMember; set => ComboBox_Lenth.DisplayMember = value; }
        byte[] IAddCar.image
        {
            get
            {
                return getimage();
            }
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public byte[] getimage()
        {
            if (pictureBox_Car.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBox_Car.Image.Save(ms, pictureBox_Car.Image.RawFormat);
                    return ms.ToArray();
                }
            }
            else
            {
                return null;
            }
        }
        private void perfromevent()
        {
            gunaGradientTileButton.Click += delegate
            {
                EditCar_butclick?.Invoke(this, EventArgs.Empty);
                MessageBox.Show(Message, "Adding Car", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            };
        }
       
        private void but_AddCar_Click(object sender, EventArgs e)
        {
            perfromevent();
        }
        private void butAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image | *.png ; *.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox_Car.Image = new Bitmap(ofd.FileName);
                getimage();
            }            
        }
        private void guna2CirclePictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Frm_AddCar_Load(object sender, EventArgs e)
        {
            addCarPresenter.selectcompany();
            ComboBox_Lenth.Hide();
            Lbl_Length.Hide();
        }
        //Method to check which radio button checked
        private void RbutForRent_CheckedChanged(object sender, EventArgs e)
        {
            Lbl_Length.Show();
            ComboBox_Lenth.Show();
            if (RbutForRent.Checked)
            {
                addCarPresenter.SelectRentLength();
            }
            else if (RbutForUsedSell.Checked)
            {
                addCarPresenter.SelectUsedLength();
            }
        }

        
    }
}
