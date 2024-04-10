using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CarGallery.Logic.Services
{
    internal class UserServices
    {
     
        //this method to sign up the user to the application
        public static bool Userinsert(string Name, string Password, string ContactNumber,
            string ContactEmail, byte[] Image, string Gender)
        {
            return DbHelper.Excute("UserInsert", () => signupInsertParameters(Name, Password, ContactNumber,
                ContactEmail, Image, Gender, DbHelper.command));
        }
        //this method to add the user signup parameters 
        private static void signupInsertParameters(string Name, string Password, string ContactNumber,
            string ContactEmail, byte[] Image, string Gender, SqlCommand command)
        {
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = Name;
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = Password;
            command.Parameters.Add("@phone", SqlDbType.VarChar).Value = ContactNumber;
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = ContactEmail;
            command.Parameters.Add("@image", SqlDbType.Image).Value = Image;
            command.Parameters.Add("@gender", SqlDbType.VarChar).Value = Gender;
        }



        //this method to login  to the application  
        public static DataTable Login(string LoginEmail, string Password)
        {
            return DbHelper.Select("Login", () => Userinfo(LoginEmail, Password, DbHelper.command));
        }
        //this method to get the user Email and password parameters 
        private static void Userinfo(string LoginEmail, string Password, SqlCommand command)
        {
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = LoginEmail;
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = Password;
        }

        //Method to get all User In DB
        public static DataTable SelectAllUser()
        {
            return DbHelper.Select("SelectAllUser", () => { });
        }

        //Method used to update user information 
        public static bool UserUpdate(int Id, string Name, string ContactEmail,
            string ContactNumber, string Gender, byte[] Image)
        {
            return DbHelper.Excute("UpdateUser", () => UserUpdateParameters(Id, Name, ContactEmail, ContactNumber,
                Gender, Image, DbHelper.command));
        }
        //Method used to add paremeters that used to update user information 
        private static void UserUpdateParameters(int Id,string Name, string ContactEmail,
           string ContactNumber, string Gender, byte[] Image,SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = Name;
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = ContactEmail;
            command.Parameters.Add("@phone", SqlDbType.VarChar).Value = ContactNumber;
            command.Parameters.Add("@gender", SqlDbType.VarChar).Value = Gender;
            command.Parameters.Add("@image", SqlDbType.Image).Value = Image;
        }

        //delete a user from DB
        public static bool UserDelete(int id)
        {
            return DbHelper.Excute("DeleteUser", () => UserParametersDelete(id, DbHelper.command));
        }
        //Method used to get id paremeters to delete company
        private static void UserParametersDelete(int id, SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
        }

    }
}
