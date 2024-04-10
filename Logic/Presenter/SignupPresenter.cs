using CarGallery.Logic.Services;
using CarGallery.Model;
using CarGallery.Presenter.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGallery.Logic.Presenter
{
    internal class SignupPresenter
    {
        ISignUp Isignup;
        UserModel userModel = new UserModel();

        public SignupPresenter(ISignUp view)
        {
            this.Isignup = view;
            this.Isignup.CreateUser_butclick += Isignup_CreateUser_butclick;
        }

        private void Isignup_CreateUser_butclick(object sender, EventArgs e)
        {
            SignUp();
        }

        //Connect between the model and the interface
        private void connectionBetweenModelInterface()
        {
            userModel.FullName = Isignup.FullName;
            userModel.Password = Isignup.Password;
            userModel.ContactNum = Isignup.ContactNum;
            userModel.ContactEmail = Isignup.ContactEmail;
            userModel.image = Isignup.image;
            userModel.Gender = Isignup.Gender;
        }

        //Method to allow user to signup
        public bool SignUp()
        {
            connectionBetweenModelInterface();
            if(Isignup.ContactEmail.Contains("@") && Isignup.ContactNum.Length == 9)
            {
                Isignup.Message = "The User Added successfully";
                return UserServices.Userinsert(userModel.FullName, userModel.Password, userModel.ContactNum, userModel.ContactEmail
                , userModel.image, userModel.Gender);
            }
            else if (!Isignup.ContactEmail.Contains("@"))
            {
                Isignup.Message = "The Email should contain @ ";
                return false;
            }
            else if (Isignup.ContactNum.Length != 9)
            {
                Isignup.Message = "The number should be 9 numbers";
                return false;
            }
            else return false;

        }
        //Method to set user image
        public byte[] getimage()
        {
            connectionBetweenModelInterface();
            return Isignup.getimage();
        }
    }
}
