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

namespace CarGallery.Presenter.Forms
{
    public partial class Frm_Login : Form, ILogin
    {
        private string message;
        LoginPresenter loginPresenter;
        Frm_Home frm_Home = new Frm_Home();
        public Frm_Login()
        {
            InitializeComponent();
            loginPresenter = new LoginPresenter(this);
        }

        public string LoginEmail { get => txt_Email.Text; set => txt_Email.Text = value; }
        public string LoginPassword { get => txt_Password.Text; set => txt_Password.Text = value; }
        public string ErrorMessage { get { return message; } set { message = value; } }

        private void lbl_CreateAcc_MouseHover(object sender, EventArgs e)
        {
            lbl_CreateAcc.ForeColor = Color.FromArgb(10, 67, 117);
        }

        private void lbl_CreateAcc_Click(object sender, EventArgs e)
        {
            Frm_SignUp frm_SignUp = new Frm_SignUp();
            frm_SignUp.Show();
        }

        private void lbl_CreateAcc_MouseLeave(object sender, EventArgs e)
        {
            lbl_CreateAcc.ForeColor = Color.SeaShell;
        }
        private void but_Login_Click(object sender, EventArgs e)
        {
            try
            {
                bool check = loginPresenter.Login();
                if (check)
                {
                    frm_Home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
