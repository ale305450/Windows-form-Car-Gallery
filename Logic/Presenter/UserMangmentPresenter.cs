using CarGallery.Logic.Services;
using CarGallery.Model;
using CarGallery.View.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGallery.Logic.Presenter
{
    internal class UserMangmentPresenter
    {
        IUserMangment IuserMangment;
        UserModel userModel = new UserModel();

        public UserMangmentPresenter(IUserMangment view)
        {
            this.IuserMangment = view;
            this.IuserMangment.edituser += IuserMangment_edituser;
        }

        private void IuserMangment_edituser(object sender, EventArgs e)
        {
            Update();
        }

        //Connect between the model and the interface
        private void connectionBetweenModelInterface()
        {
            userModel.Id = IuserMangment.userId;
            userModel.FullName = IuserMangment.FullName;
            userModel.ContactEmail = IuserMangment.ContactEmail;
            userModel.ContactNum = IuserMangment.ContactNum;
            userModel.Gender = IuserMangment.Gender;
            userModel.image = IuserMangment.image;
        }
        //Method to select All user In DB
        public void selectAll()
        {
            IuserMangment.datagrid = UserServices.SelectAllUser();
        }

        //Method to Edit user In DB  
        public bool Update()
        {
            connectionBetweenModelInterface();
            if (IuserMangment.ContactEmail.Contains("@") && IuserMangment.ContactNum.Length == 9)
            {
                IuserMangment.Message = "The User Added successfully";
                bool check= UserServices.UserUpdate(userModel.Id, userModel.FullName, userModel.ContactEmail, 
                    userModel.ContactNum, userModel.Gender, userModel.image);
                selectAll();
                IuserMangment.Message = "The user is updated ";
                return check;
            }
            else if (!IuserMangment.ContactEmail.Contains("@"))
            {
                IuserMangment.Message = "The Email should contain @ ";
                return false;
            }
            else if (IuserMangment.ContactNum.Length != 9)
            {
                IuserMangment.Message = "The number should be 9 numbers";
                return false;
            }
            else return false;


        }
        //Method to delete user
        public bool Delete()
        {
            bool check = UserServices.UserDelete(IuserMangment.userId);
            if(check)
            {
                IuserMangment.Message = "The user is deleted";
            }
            else
            {
                IuserMangment.Message = "The user is not deleted";
            }
            selectAll();
            return check;
        }
        //Method to get user image from DB
        public void setuserimage(byte[] value)
        {
            IuserMangment.setuserimage(value);
        }
    }
}
