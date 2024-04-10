using CarGallery.View.Forms;
using Guna.UI.WinForms;
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
    public partial class Frm_Home : Form
    {
        public Frm_Home()
        {
            InitializeComponent();
            UserControl_Main userControl_Main = new UserControl_Main();
            AddUserControler(userControl_Main);
        }
        private void moveimage(object sender)
        {
            GunaAdvenceButton gunaAdvenceButton = (GunaAdvenceButton)sender;
            Image_slide.Location = new Point(gunaAdvenceButton.Location.X + 27, gunaAdvenceButton.Location.Y - 29);
            Image_slide.SendToBack();
        }
        private void But_Home_CheckedChanged(object sender, EventArgs e)
        {
            moveimage(sender);
        }

        private void AddUserControler(UserControl userControl)
        {
            PanelContainer.Controls.Clear();
            PanelContainer.Controls.Add(userControl);
            userControl.BringToFront();
            PanelContainer.Dock = DockStyle.Fill;                      
            //PanelContainer.Tag = userControl;
            //userControl.Show();
        }
           
         private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void But_Cars_Click(object sender, EventArgs e)
        {
            UserControl_CarMangment userControl_CarMangment = new UserControl_CarMangment();
            AddUserControler(userControl_CarMangment);
        }

        private void But_Company_Click(object sender, EventArgs e)
        {
            UserControl_CompanyMangment userControl_CompanyMangment = new UserControl_CompanyMangment();
            AddUserControler(userControl_CompanyMangment);
        }

        private void But_Home_Click(object sender, EventArgs e)
        {
            UserControl_Main userControl_Main = new UserControl_Main();
            AddUserControler(userControl_Main);
        }

        private void But_User_Click(object sender, EventArgs e)
        {
            UserControl_UserMangment userControl_UserMangment = new UserControl_UserMangment();
            AddUserControler(userControl_UserMangment);
        }
    }
}
