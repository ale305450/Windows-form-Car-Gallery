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
using CarGallery.Properties;
using Guna.UI.WinForms;
namespace CarGallery.Presenter.Forms
{
    public partial class Frm_AddCompany : Form,ICompanyAdd
    {
        private string message;
        public event EventHandler EditCompany_butclick;
        public GunaGradientTileButton gunaGradientTileButton;
        AddCompanyPresenter companyPresenter;
        public Frm_AddCompany()
        {
            InitializeComponent();
            this.gunaGradientTileButton = but_AddCompany;
            companyPresenter = new AddCompanyPresenter(this);
        }
        string ICompanyAdd.CompanyName { get => txt_CompanyName.Text; set => txt_CompanyName.Text = value; }
        string ICompanyAdd.Description { get => richTextBox_Description.Text; set => richTextBox_Description.Text = value; }
        public string Message { get { return message; } set { message = value; }}
        public byte[] Logo
        {
            get { return getimage(); }
        }
        public object but_Addcompany { get => but_AddCompany.Text; set => but_AddCompany.Text = value.ToString(); }


        public byte[] getimage()
        {
            if(pictureBox_Company.Image != null)
            {
                using(MemoryStream ms = new MemoryStream())
                {
                    pictureBox_Company.Image.Save(ms, pictureBox_Company.Image.RawFormat);
                    return ms.ToArray();
                }
            }
            else return null;
        }
        private void performClickEvent()
        {
            gunaGradientTileButton.Click += delegate
            {
                EditCompany_butclick?.Invoke(this, EventArgs.Empty);
                MessageBox.Show(message);
                this.Close();
            };
        }        


        private void but_AddLogo_Click(object sender, EventArgs e)
        {
           OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image | *.png ; *.jpg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox_Company.Image = new Bitmap(openFileDialog.FileName);
                getimage();
            }
        }

        private void guna2CirclePictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void but_AddCompany_Click(object sender, EventArgs e)
        {
            performClickEvent();
        }
    }
}
