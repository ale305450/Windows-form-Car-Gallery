using CarGallery.Logic.Presenter;
using CarGallery.Presenter.Forms;
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

namespace CarGallery.View.Forms
{
    public partial class UserControl_UserMangment : UserControl,IUserMangment
    {
        UserMangmentPresenter userMangmentPresenter;
        Frm_SignUp frm_SignUp = new Frm_SignUp();
        private string message;
        public UserControl_UserMangment()
        {
            InitializeComponent();
            userMangmentPresenter = new UserMangmentPresenter(this);
        }

        public object datagrid { get => guna2DataGridView1.DataSource; set => guna2DataGridView1.DataSource = value; }
        public int userId {get => Convert.ToInt32( guna2DataGridView1.CurrentRow.Cells[0].Value); }
        public string FullName { get => frm_SignUp.txt_FullName.Text; set => frm_SignUp.txt_FullName.Text = value; }
        public string Form_FullName { get => guna2DataGridView1.CurrentRow.Cells[1].Value.ToString(); }
        public string ContactEmail { get => frm_SignUp.txt_ContactEmail.Text; set => frm_SignUp.txt_ContactEmail.Text = value; }
        public string Form_ContactEmail { get => guna2DataGridView1.CurrentRow.Cells[2].Value.ToString(); }
        public string ContactNum { get => frm_SignUp.txt_ContactNumber.Text; set => frm_SignUp.txt_ContactNumber.Text = value; }
        public string Form_ContactNum { get => guna2DataGridView1.CurrentRow.Cells[3].Value.ToString(); }
        public string Gender { get => frm_SignUp.ComboBox_Gender.Text; set => frm_SignUp.ComboBox_Gender.Text = value; }
        public string Form_Gender { get => guna2DataGridView1.CurrentRow.Cells[4].Value.ToString(); }
        public byte[] Form_image { get => (byte[])guna2DataGridView1.CurrentRow.Cells[5].Value; set => setuserimage(value); }
        public string Message { get => message; set => message = value; }
        public byte[] image { get => getimage(); }

        public event EventHandler edituser;

        public void setuserimage(byte[] value)
        {
            if (value != null && value.Length > 0)
            {
                MemoryStream ms = new MemoryStream(value);
                frm_SignUp.PictureBox_User.Image = Image.FromStream(ms);
            }
            else { frm_SignUp.PictureBox_User.Image = null; }
        }
        public byte[] getimage()
        {
            if (frm_SignUp.PictureBox_User.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    frm_SignUp.PictureBox_User.Image.Save(ms, frm_SignUp.PictureBox_User.Image.RawFormat);
                    return ms.ToArray();
                }
            }
            else
            {
                return null;
            }
        }
        private void performEvent()
        {
            frm_SignUp.gunaCreateButton.Click += delegate
            {
                edituser?.Invoke(this, EventArgs.Empty);
                frm_SignUp.Close();
                MessageBox.Show(message, "User Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };
        }

        private void but_Edit_Click(object sender, EventArgs e)
        {
            frm_SignUp.Show();
            frm_SignUp.txt_FullName.Text = Form_FullName;
            frm_SignUp.txt_ContactEmail.Text = Form_ContactEmail;
            frm_SignUp.txt_ContactNumber.Text = Form_ContactNum;
            frm_SignUp.ComboBox_Gender.Text = Form_Gender;
            setuserimage(Form_image);
            frm_SignUp.gunaCreateButton.Text = "Edit";
            frm_SignUp.Passwordtxtbox = false;
            performEvent();
        }

        private void but_Delete_Click(object sender, EventArgs e)
        {
            userMangmentPresenter.Delete();
            MessageBox.Show(Message);
        }

        private void UserControl_UserMangment_Load(object sender, EventArgs e)
        {
            userMangmentPresenter.selectAll();
        }
    }
}
