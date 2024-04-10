using CarGallery.Logic.Services;
using CarGallery.Model;
using CarGallery.Presenter.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGallery.Logic.Presenter
{
    internal class LoginPresenter
    {
        ILogin Ilogin;
        UserModel userModel = new UserModel();
        public LoginPresenter(ILogin view)
        {
            this.Ilogin = view;
        }

        //Connect between the model and the interface
        private void ConnectionBetweenModelInterface()
        {
            userModel.ContactEmail = this.Ilogin.LoginEmail;
            userModel.Password = this.Ilogin.LoginPassword;  
        }
        //Method to allow user to login
        public bool Login()
        {
            ConnectionBetweenModelInterface();
            DataTable dataTable = UserServices.Login(userModel.ContactEmail, userModel.Password);
            if(dataTable != null)
            {
                if(dataTable.Rows.Count > 0)
                {
                   return true;
                }
                else
                {
                    Ilogin.ErrorMessage = "the Email or password not correct ";
                }
            }
            return false;

        }
    }
}
