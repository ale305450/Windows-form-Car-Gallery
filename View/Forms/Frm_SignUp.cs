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

namespace CarGallery.Presenter.Forms
{
    public partial class Frm_SignUp : Form,ISignUp
    {
        private string message;
        SignupPresenter signupPresenter;
        public GunaGradientTileButton gunaCreateButton;

        public event EventHandler CreateUser_butclick;

        public Frm_SignUp()
        {
            InitializeComponent();
            signupPresenter = new SignupPresenter(this);
            this.gunaCreateButton = butCreate;
        }
        public string FullName { get => txt_FullName.Text; set => txt_FullName.Text = value; }
        public string Password { get => txt_Password.Text; set => txt_Password.Text = value; }
        public string ContactEmail { get => txt_ContactEmail.Text; set => txt_ContactEmail.Text = value; }
        public string ContactNum { get => txt_ContactNumber.Text; set => txt_ContactNumber.Text = value; }
        public string Gender { get => ComboBox_Gender.SelectedValue.ToString(); set => ComboBox_Gender.SelectedValue = value; }
        public byte[] image { get { return getimage(); } }
        public string Message { get { return message; } set { message = value; } }

        public object Passwordtxtbox { get => txt_Password.Enabled; set => txt_Password.Enabled = (bool)value; }

        public byte[] getimage()
        {
            if(PictureBox_User.Image != null)
            {
                using(MemoryStream ms = new MemoryStream())
                {
                    PictureBox_User.Image.Save(ms, PictureBox_User.Image.RawFormat);
                    return ms.ToArray();
                }
            }
            else return null;
        }
        private void performevent()
        {
            gunaCreateButton.Click += delegate
             {
                 CreateUser_butclick?.Invoke(this, EventArgs.Empty);
                 MessageBox.Show(message);
             };
        }
        private void butAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image | *.png ; *.jpg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PictureBox_User.Image = new Bitmap(openFileDialog.FileName);
                getimage();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butCreate_Click(object sender, EventArgs e)
        {
            performevent();
        }
    }
}
