using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CarGallery.Logic.Services
{
    static class CompanyServices
    {
        //Insert a new cOMPANY to DB
        public static bool CompanyInsert(string name, string description, byte[] Logo)
        {
            return DbHelper.Excute("CompanyInsert", () => CompanyParametersInsert(name, description, Logo, DbHelper.command));
        }
        //Add paremeters to add a new Company
        private static void CompanyParametersInsert(string name,string description, byte[] Logo,SqlCommand command)
        {
            command.Parameters.Add("@name",SqlDbType.VarChar).Value=name;
            command.Parameters.Add("@Description",SqlDbType.VarChar).Value= description;
            command.Parameters.Add("@Logo", SqlDbType.Image).Value= Logo;
        }
        //delete a company from DB
        public static bool CompanyDelete(int id)
        {
            return DbHelper.Excute("CompanyDelete", () => CompanyParametersDelete(id, DbHelper.command));
        }
        //Method used to get id paremeters to delete company
        private static void CompanyParametersDelete(int id, SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
        }

        //Method used to update company information 
        public static bool CompanyUpdate(int id, string name, string description, byte[] logo)
        {
            return DbHelper.Excute("CompanyUpdate", () => CompanyParametersUpdate(id, name, description, logo, DbHelper.command));
        }
        //Method used to add paremeters that used to update company information 
        private static void CompanyParametersUpdate(int id, string name, string description, byte[] logo, SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
            command.Parameters.Add("@description", SqlDbType.VarChar).Value = description;
            command.Parameters.Add("@logo", SqlDbType.Image).Value = logo;
        }

        //Method to get all Companies In DB
        public static DataTable SelectAll()
        {
            return DbHelper.Select("SelectAll", () => { });
        }

    }
}
