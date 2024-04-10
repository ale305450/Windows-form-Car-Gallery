using CarGallery.Logic.Services;
using CarGallery.Model;
using CarGallery.Presenter.Forms;
using CarGallery.Presenter.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace CarGallery.Logic.Presenter
{
    class CompanyMangmentPresenter
    {
        ICompanyMangment Icompany;
        CompanyModel companyModel = new CompanyModel();
        public CompanyMangmentPresenter(ICompanyMangment view)
        {
            this.Icompany = view;
            this.Icompany.EditCompany_butclick += Icompany_EditCompany_butclick;
        }
        //Connect between the model and the interface
        private void connectionBetweenModelInterface()
        {
            companyModel.Id = Icompany.FormCompanyId;
            companyModel.CompanyName = Icompany.CompanyNametxtbox;
            companyModel.Description = Icompany.CompanyDescriptionrichbox;
            companyModel.Logo = Icompany.CompanyLogo;
        }

        //Event to Edit company
        private void Icompany_EditCompany_butclick(object sender, EventArgs e)
        {
            Update();
            selectAll();
        }

        //Method to select All company In DB
        public void selectAll()
        {
            Icompany.Datagrid = CompanyServices.SelectAll();
        }

        //Method to Edit company In DB  
        public bool Update()
        {
            connectionBetweenModelInterface();
            return CompanyServices.CompanyUpdate(companyModel.Id, companyModel.CompanyName,companyModel.Description, companyModel.Logo); ;
        }
        //Method to delete company
        public bool Delete()
        {
            bool check = CompanyServices.CompanyDelete(Icompany.FormCompanyId);
            selectAll();
            return check;
        }

        //Method to stop un selected button
        public void disableBut()
        {
            Icompany.EditCompany_but = false;
            Icompany.DeleteCompany_but = false;
        }
        //Method to open selected button
        public void CellSelcted()
        {
            Icompany.EditCompany_but =   true;
            Icompany.DeleteCompany_but = true;
        }
        //Method to get car image from DB
        public void setCarImage(byte[] value)
        {
            Icompany.setCompanyImage(value);
        }

    }
}
