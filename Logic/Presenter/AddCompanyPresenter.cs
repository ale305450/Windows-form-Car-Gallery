using CarGallery.Logic.Services;
using CarGallery.Model;
using CarGallery.Presenter.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace CarGallery.Logic.Presenter
{
    class AddCompanyPresenter
    {
        ICompanyAdd Icompany;
        CompanyModel companyModel=new CompanyModel();
        public AddCompanyPresenter(ICompanyAdd view)
        {
            this.Icompany = view;
            this.Icompany.EditCompany_butclick += Icompany_EditCompany_butclick;
        }
        //Event to add company
        private void Icompany_EditCompany_butclick(object sender, EventArgs e)
        {
            bool check = insert();
            if (check)
            {
                Icompany.Message = "The Company Inserted Successufully";
            }
            else
            {
                Icompany.Message = "The Company is not inserted";
            }

        }

        //Connect between the model and the interface
        private void connectionBetweenModelInterface()
        {
            companyModel.CompanyName = Icompany.CompanyName;
            companyModel.Description = Icompany.Description;
            companyModel.Logo = Icompany.Logo;
        }
        // Method to insert Company info In DB
        public bool insert()
        {
            connectionBetweenModelInterface();
            Icompany.but_Addcompany = "Add Company";
            return CompanyServices.CompanyInsert(companyModel.CompanyName, companyModel.Description, companyModel.Logo);
        }
        public byte[] getimage()
        {
            connectionBetweenModelInterface();
            return Icompany.getimage();
        }

    }
}
