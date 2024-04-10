using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace CarGallery.Logic.Services
{
    internal class CarServices
    {
        //Insert

        //Add paremeters to add a new car
        private static void  AddCarInsertParementers(string name , string description, int price , string model
            ,string contact_Number, string contact_Email , byte[] car_image , int company_Id,SqlCommand command)
        {
            command.Parameters.Add("@name",SqlDbType.VarChar).Value = name;
            command.Parameters.Add("@description", SqlDbType.VarChar).Value = description;
            command.Parameters.Add("@price", SqlDbType.Int).Value = price;
            command.Parameters.Add("@model", SqlDbType.VarChar).Value = model;
            command.Parameters.Add("@contact_Number", SqlDbType.VarChar).Value = contact_Number;
            command.Parameters.Add("@contact_Email", SqlDbType.VarChar).Value = contact_Email;
            command.Parameters.Add("@car_image", SqlDbType.Image).Value = car_image;
            command.Parameters.Add("@company_Id", SqlDbType.Int).Value = company_Id;

        }
        //Insert a new car to DB
        public static bool insertCar(string name, string description, int price, string model
            , string contact_Number, string contact_Email, byte[] car_image, int company_Id)
        {
            return DbHelper.Excute("CarInsert", () => AddCarInsertParementers(name, description, price, model, contact_Number, contact_Email, car_image, company_Id, DbHelper.command));
            
        }

        //Add paremeters to add a Rented car
        private static void AddRentedCarInsertParementers(string name, string description, int price, string model
           , string contact_Number, string contact_Email, byte[] car_image, int company_Id,int rent_Id, SqlCommand command)
        {
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
            command.Parameters.Add("@description", SqlDbType.VarChar).Value = description;
            command.Parameters.Add("@price", SqlDbType.Int).Value = price;
            command.Parameters.Add("@model", SqlDbType.VarChar).Value = model;
            command.Parameters.Add("@contact_Number", SqlDbType.VarChar).Value = contact_Number;
            command.Parameters.Add("@contact_Email", SqlDbType.VarChar).Value = contact_Email;
            command.Parameters.Add("@car_image", SqlDbType.Image).Value = car_image;
            command.Parameters.Add("@company_Id", SqlDbType.Int).Value = company_Id;
            command.Parameters.Add("@rent_Id", SqlDbType.Int).Value = rent_Id;

        }
        //Insert a Rented car to DB
        public static bool insertRentedCar(string name, string description, int price, string model
           , string contact_Number, string contact_Email, byte[] car_image, int company_Id, int rent_Id)
        {
            return DbHelper.Excute("CarRentInsert", () => AddRentedCarInsertParementers(name, description, price, model, contact_Number,contact_Email,car_image,company_Id,rent_Id,DbHelper.command));
        }

        //Add paremeters to add a used car
        private static void AddUsedCarInsertParementers(string name, string description, int price, string model
          , string contact_Number, string contact_Email, byte[] car_image, int company_Id, int used_Id, SqlCommand command)
        {
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
            command.Parameters.Add("@description", SqlDbType.VarChar).Value = description;
            command.Parameters.Add("@price", SqlDbType.Int).Value = price;
            command.Parameters.Add("@model", SqlDbType.VarChar).Value = model;
            command.Parameters.Add("@contact_Number", SqlDbType.VarChar).Value = contact_Number;
            command.Parameters.Add("@contact_Email", SqlDbType.VarChar).Value = contact_Email;
            command.Parameters.Add("@car_image", SqlDbType.Image).Value = car_image;
            command.Parameters.Add("@company_Id", SqlDbType.Int).Value = company_Id;
            command.Parameters.Add("@used_Id", SqlDbType.Int).Value = used_Id;

        }
        //Insert a Used car to DB
        public static bool insertUsedCar(string name, string description, int price, string model
          , string contact_Number, string contact_Email, byte[] car_image, int company_Id, int used_Id)
        {
            return DbHelper.Excute("CarRentInsert", () => AddUsedCarInsertParementers(name, description, price, model, contact_Number, contact_Email, car_image, company_Id, used_Id, DbHelper.command));
        }


        //Update

        //Add paremeters to update a new car
        private static void CarUdateParementers(int id,string name, string description, int price, string model
            , string contact_Number, string contact_Email, byte[] car_image, int company_Id, SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
            command.Parameters.Add("@description", SqlDbType.VarChar).Value = description;
            command.Parameters.Add("@price", SqlDbType.Int).Value = price;
            command.Parameters.Add("@model", SqlDbType.VarChar).Value = model;
            command.Parameters.Add("@contact_Number", SqlDbType.VarChar).Value = contact_Number;
            command.Parameters.Add("@contact_Email", SqlDbType.VarChar).Value = contact_Email;
            command.Parameters.Add("@car_image", SqlDbType.Image).Value = car_image;
            command.Parameters.Add("@company_Id", SqlDbType.Int).Value = company_Id;

        }
        //update a new car to DB
        public static bool updateCar(int id,string name, string description, int price, string model
            , string contact_Number, string contact_Email, byte[] car_image, int company_Id)
        {
            return DbHelper.Excute("CarUpdate", () => CarUdateParementers(id,name, description, price, model, contact_Number, contact_Email, car_image, company_Id, DbHelper.command));

        }

        //Add paremeters to update a Used car
        private static void CarUsedUdateParementers(int id, string name, string description, int price, string model
            , string contact_Number, string contact_Email, byte[] car_image, int company_Id, int used_id, SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
            command.Parameters.Add("@description", SqlDbType.VarChar).Value = description;
            command.Parameters.Add("@price", SqlDbType.Int).Value = price;
            command.Parameters.Add("@model", SqlDbType.VarChar).Value = model;
            command.Parameters.Add("@contact_Number", SqlDbType.VarChar).Value = contact_Number;
            command.Parameters.Add("@contact_Email", SqlDbType.VarChar).Value = contact_Email;
            command.Parameters.Add("@car_image", SqlDbType.Image).Value = car_image;
            command.Parameters.Add("@company_Id", SqlDbType.Int).Value = company_Id;
            command.Parameters.Add("@used_Id", SqlDbType.Int).Value = used_id;
        }
        //update a Used car to DB
        public static bool updateUsedCar(int id, string name, string description, int price, string model
            , string contact_Number, string contact_Email, byte[] car_image, int company_Id, int used_id)
        {
            return DbHelper.Excute("CarUsedUpdate", () => CarUsedUdateParementers(id, name, description, price, model, contact_Number, contact_Email, car_image, company_Id, used_id, DbHelper.command));

        }
        //Add paremeters to Rented a Used car
        private static void CarRentUdateParementers(int id, string name, string description, int price, string model
            , string contact_Number, string contact_Email, byte[] car_image, int company_Id, int rent_id, SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
            command.Parameters.Add("@description", SqlDbType.VarChar).Value = description;
            command.Parameters.Add("@price", SqlDbType.Int).Value = price;
            command.Parameters.Add("@model", SqlDbType.VarChar).Value = model;
            command.Parameters.Add("@contact_Number", SqlDbType.VarChar).Value = contact_Number;
            command.Parameters.Add("@contact_Email", SqlDbType.VarChar).Value = contact_Email;
            command.Parameters.Add("@car_image", SqlDbType.Image).Value = car_image;
            command.Parameters.Add("@company_Id", SqlDbType.Int).Value = company_Id;
            command.Parameters.Add("@rent_Id", SqlDbType.Int).Value = rent_id;

        }
        //update a Rented car to DB
        public static bool updateRentCar(int id, string name, string description, int price, string model
            , string contact_Number, string contact_Email, byte[] car_image, int company_Id, int rent_id)
        {
            return DbHelper.Excute("CarRentUpdate", () => CarRentUdateParementers(id, name, description, price, model, contact_Number, contact_Email, car_image, company_Id, rent_id, DbHelper.command));

        }





        //Method to delete car from DB
        public static bool CarDelete(int id)
        {
            return DbHelper.Excute("CarDelete", () => CarParametersDelete(id, DbHelper.command));
        }
        //Method used to get id paremeters to delete car
        private static void CarParametersDelete(int id, SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
        }


        //Method to get the name of the company to put in combobox
        public static DataTable getCompanyData()
        {
            return DbHelper.Select("Selectcompany", () => { });
        }
        //Method to get the Rent Length of the car and to put in combobox
        public static DataTable getRentLength()
        {
            return DbHelper.Select("SelectRentLength", ()=> { });
        }
        //Method to get the Used Length of the car and to put in combobox
        public static DataTable getUsedLength()
        {
            return DbHelper.Select("SelectUsedLength", () => { });
        }
        //Method to get all cars In DB
        public static DataTable SelectAllCar()
        {
            return DbHelper.Select("SelectAllCar", () => { });
        }

        //Method to get some car details to display in form
        public static DataTable CarDetalis(int Id)
        {
            return DbHelper.Select("CarDetalis", () => Cardetalis(Id, DbHelper.command));
        }
        //Method to get car paremeters details to display in form
        private static void Cardetalis(int Id, SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
        }

        //Method to get some car details to display in form
        public static DataTable MainCarDetalis()
        {
            return DbHelper.Select("MainCarDetalis", () => { });
        }
    }

}
