using CarGallery.Logic.Presenter;
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
    public partial class UserControl_CarMangment : UserControl, ICarMangment
    {
        CarMangmentPresenter carMangmentPresenter;
        Frm_AddCar frm_AddCar = new Frm_AddCar();
        UserControl_CompanyMangment userControl_CompanyMangment = new UserControl_CompanyMangment();
        Frm_CarDetails frm_CarDetails = new Frm_CarDetails();
        public event EventHandler EditCar_butclick;
        private string message;
        public UserControl_CarMangment()
        {
            InitializeComponent();
            carMangmentPresenter = new CarMangmentPresenter(this);
            this.Cursor = Cursors.Default;
        }

        public object Datagrid { get => guna2DataGridView1.DataSource; set => guna2DataGridView1.DataSource = value; }

        public int FormCarId => (int)guna2DataGridView1.CurrentRow.Cells[0].Value;
        public string FormCarNametxtbox { get => guna2DataGridView1.CurrentRow.Cells[1].Value.ToString(); set => frm_AddCar.txt_CarName.Text = value; }
        public string FormCarDescriptionrichbox { get => guna2DataGridView1.CurrentRow.Cells[2].Value.ToString(); set => frm_AddCar.richTextBox1.Text = value; }
        public int FormCarprice { get => (int)guna2DataGridView1.CurrentRow.Cells[3].Value; set => frm_AddCar.numericUpDown_Price.Value = value; }
        public string FormCarModel { get => guna2DataGridView1.CurrentRow.Cells[4].Value.ToString(); set => frm_AddCar.txt_Model.Text = value; }
        public string FormCarContactNum { get => guna2DataGridView1.CurrentRow.Cells[5].Value.ToString(); set => frm_AddCar.txt_ContactNumber.Text = value; }
        public string FormCarContactEmail { get => guna2DataGridView1.CurrentRow.Cells[6].Value.ToString(); set => frm_AddCar.txt_ContactEmail.Text = value; }
        public byte[] FormCarimagepicbox { get => (byte[])guna2DataGridView1.CurrentRow.Cells[7].Value; set => setCarImage(value); }
        public string Formcompany_Name { get => guna2DataGridView1.CurrentRow.Cells[8].Value.ToString(); set => frm_AddCar.ComboBox_Company.Text = value; }
        public int FormCarRent_id { get => (int)guna2DataGridView1.CurrentRow.Cells[9].Value; set => frm_AddCar.ComboBox_Lenth.SelectedValue = value; }
        public int FormCarUsed_id { get => (int)guna2DataGridView1.CurrentRow.Cells[10].Value; set => frm_AddCar.ComboBox_Lenth.SelectedValue = value; }
        public object AddCar_but { get => but_Add.Enabled; set => but_Add.Enabled = Convert.ToBoolean(value); }
        public object EditCar_but { get => but_Edit.Enabled; set => but_Edit.Enabled = Convert.ToBoolean(value); }
        public object CarDetails_but { get => but_Delete.Enabled; set => but_Delete.Enabled = Convert.ToBoolean(value); }
        public object DeleteCar_but { get => but_Details.Enabled; set => but_Details.Enabled = Convert.ToBoolean(value); }
        public string Message { get => message; set => message = value; }

        public string CarName { get => frm_AddCar.txt_CarName.Text; set => frm_AddCar.txt_CarName.Text = value; }
        public string Description { get => frm_AddCar.richTextBox1.Text; set => frm_AddCar.richTextBox1.Text = value; }
        public string ContactNum { get => frm_AddCar.txt_ContactNumber.Text; set => frm_AddCar.txt_ContactNumber.Text = value; }
        public string ContactEmail { get => frm_AddCar.txt_ContactEmail.Text; set => frm_AddCar.txt_ContactEmail.Text = value; }
        public int price { get => Convert.ToInt32(frm_AddCar.numericUpDown_Price.Value); set => frm_AddCar.numericUpDown_Price.Value = value; }
        public string Model { get => frm_AddCar.txt_Model.Text; set => frm_AddCar.txt_Model.Text = value; }
        public int company_id { get => Convert.ToInt32(frm_AddCar.ComboBox_Company.SelectedValue); set => frm_AddCar.ComboBox_Company.SelectedValue = value; }
        public int Rent_id { get => Convert.ToInt32(frm_AddCar.ComboBox_Lenth.SelectedValue); set => frm_AddCar.ComboBox_Lenth.SelectedValue = value; }
        public int Used_id { get => Convert.ToInt32(frm_AddCar.ComboBox_Lenth.SelectedValue); set => frm_AddCar.ComboBox_Lenth.SelectedValue = value; }
        public string Length { get => Convert.ToString(frm_AddCar.ComboBox_Lenth.SelectedValue); set => frm_AddCar.ComboBox_Lenth.SelectedValue = value; }





        public byte[] Carimage => getimage();
        public void setCarImage(byte[] value)
        {
            if (value != null && value.Length > 0)
            {
                MemoryStream ms = new MemoryStream(value);
                frm_AddCar.pictureBox_Car.Image = Image.FromStream(ms);
            }
            else { frm_AddCar.pictureBox_Car.Image = null; }
        }
        public byte[] getimage()
        {
            if (frm_AddCar.pictureBox_Car.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    frm_AddCar.pictureBox_Car.Image.Save(ms, frm_AddCar.pictureBox_Car.Image.RawFormat);
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
            frm_AddCar.gunaGradientTileButton.Click += delegate
            {
                EditCar_butclick?.Invoke(this, EventArgs.Empty);
                frm_AddCar.Close();
            };
        }


        private void UserControl_CarMangment_Load_1(object sender, EventArgs e)
        {
            carMangmentPresenter.SelectAllCars();
        }

        private void but_Delete_Click_1(object sender, EventArgs e)
        {
            carMangmentPresenter.CarDelete();
        }

        private void but_Edit_Click_1(object sender, EventArgs e)
        {
            frm_AddCar.Show();
            frm_AddCar.txt_CarName.Text = FormCarNametxtbox;
            frm_AddCar.richTextBox1.Text = FormCarDescriptionrichbox;
            frm_AddCar.numericUpDown_Price.Text = FormCarprice.ToString();
            frm_AddCar.txt_Model.Text = FormCarModel;
            frm_AddCar.txt_ContactEmail.Text = FormCarContactEmail;
            frm_AddCar.txt_ContactNumber.Text = FormCarContactNum;
            frm_AddCar.ComboBox_Company.Text = Formcompany_Name;
            frm_AddCar.gunaGradientTileButton.Text = "Edit Car";
            setCarImage(FormCarimagepicbox);
            perfromevent();
        }

        private void but_Details_Click_1(object sender, EventArgs e)
        {
            frm_CarDetails.Show();
            frm_CarDetails.setCarImage(FormCarimagepicbox);
            frm_CarDetails.CarNametxtbox = FormCarNametxtbox;
            frm_CarDetails.CarModeltxtbox = FormCarModel;
            frm_CarDetails.CarPricetxtbox = FormCarprice.ToString();
        }

        private void but_Add_Click(object sender, EventArgs e)
        {
            frm_AddCar.Show();
        }

    }
}
