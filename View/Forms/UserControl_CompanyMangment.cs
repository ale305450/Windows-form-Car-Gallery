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
using CarGallery.Presenter.Forms;
using System.IO;

namespace CarGallery.Presenter.Forms
{
    public partial class UserControl_CompanyMangment : UserControl, ICompanyMangment
    {
        Frm_AddCompany frm_AddCompany = new Frm_AddCompany();
        CompanyMangmentPresenter companyMangmentPresenter;

        public event EventHandler EditCompany_butclick;

        public UserControl_CompanyMangment()
        {
            InitializeComponent();
            companyMangmentPresenter = new CompanyMangmentPresenter(this);

        }
        public object Datagrid { get => guna2DataGridView1.DataSource; set => guna2DataGridView1.DataSource = value; }
        public int FormCompanyId { get => (int)guna2DataGridView1.CurrentRow.Cells[0].Value; }
        public string FormCompanyNametxtbox { get => guna2DataGridView1.CurrentRow.Cells[1].Value.ToString(); set => frm_AddCompany.txt_CompanyName.Text = value; }
        public string FormCompanyDescriptionrichbox { get => guna2DataGridView1.CurrentRow.Cells[2].Value.ToString(); set => frm_AddCompany.richTextBox_Description.Text = value; }
        public object AddCompany_but {  get => but_Add.Enabled; set => but_Add.Enabled = Convert.ToBoolean(value); }
        public object EditCompany_but { get => but_Edit.Enabled; set => but_Edit.Enabled = Convert.ToBoolean(value); }
        public object DeleteCompany_but{ get => but_Delete.Enabled; set => but_Delete.Enabled = Convert.ToBoolean(value); }
        public byte[] FormCompanyLogopicbox
        {
            get
            {
                return (byte[])guna2DataGridView1.CurrentRow.Cells[3].Value;
            }
            set { setCompanyImage(value); }
        }

        public string CompanyNametxtbox { get => frm_AddCompany.txt_CompanyName.Text; set => frm_AddCompany.txt_CompanyName.Text = value; }
        public string CompanyDescriptionrichbox { get => frm_AddCompany.richTextBox_Description.Text; set => frm_AddCompany.richTextBox_Description.Text= value; }
        public byte[] CompanyLogo { get => getimage(); }

        public void setCompanyImage(byte[] value)
        {
            if (value != null && value.Length > 0)
            {
                MemoryStream ms = new MemoryStream(value);
                frm_AddCompany.pictureBox_Company.Image = Image.FromStream(ms);
            }
            else { frm_AddCompany.pictureBox_Company.Image = null; }
        }
        public byte[] getimage()
        {
            if (frm_AddCompany.pictureBox_Company.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    frm_AddCompany.pictureBox_Company.Image.Save(ms, frm_AddCompany.pictureBox_Company.Image.RawFormat);
                    return ms.ToArray();
                }
            }
            else return null;
        }

        private void peformEvent()
        {
            
            frm_AddCompany.gunaGradientTileButton.Click += delegate
            {
                EditCompany_butclick?.Invoke(this, EventArgs.Empty);
                frm_AddCompany.Close();
                MessageBox.Show("Company is updated");
            };
        }



        private void UserControl_CompanyMangment_Load(object sender, EventArgs e)
        {
            companyMangmentPresenter.selectAll();
            companyMangmentPresenter.disableBut();
        }
        private void but_Add_Click(object sender, EventArgs e)
        {
            frm_AddCompany.Show();
        }
        private void but_Edit_Click(object sender, EventArgs e)
        {
            frm_AddCompany.Show();
            frm_AddCompany.txt_CompanyName.Text = FormCompanyNametxtbox;
            frm_AddCompany.richTextBox_Description.Text = FormCompanyDescriptionrichbox;
            setCompanyImage(FormCompanyLogopicbox);
            frm_AddCompany.but_Addcompany = "Edit Company";
            peformEvent();
        }
        private void guna2DataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            companyMangmentPresenter.CellSelcted();
        }
        private void but_Delete_Click_1(object sender, EventArgs e)
        {
            try
            {
                bool check = companyMangmentPresenter.Delete();
                if (check) MessageBox.Show("The company is Deleted", "Company Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("The company is not Deleted", "Company not Deleted", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
