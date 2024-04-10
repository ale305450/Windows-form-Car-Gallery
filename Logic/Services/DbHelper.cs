using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CarGallery.Logic.Services
{
    public static class DbHelper
    {
        public static SqlCommand command;
        private static string StoredPreName;
        private static SqlConnection connection;
        private static Action action;
        //Method used to estiblsh the connection with DB
        private static SqlConnection GetconnectionString()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = Properties.Settings.Default.DbServer;
            builder.InitialCatalog = Properties.Settings.Default.DbName;
            builder.IntegratedSecurity = true;
            return new SqlConnection (builder.ConnectionString);
        }
        //Method used to excute insert,delete and update opreation
        public static bool Excute(string StoredPreName,Action action)
        {
            using (SqlConnection connection = GetconnectionString())
            {
                try
                {
                    performCommand();
                    action.Invoke();
                    return true;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return false;
                }
                finally
                {
                    connection.Close();
                }
               
            }
        }
        //Method used to Select opreation
        public static DataTable Select(string StoredPreName, Action action)
        {
            SqlDataAdapter adapter;
            DataTable table = new DataTable();
            using (SqlConnection connection = GetconnectionString())
            {
                try
                {
                    performCommand();
                    action.Invoke();
                    adapter = new SqlDataAdapter(command);
                    adapter.Fill(table);
                    adapter.Dispose();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                finally
                {
                    connection.Close();
                }

            }
            return table;
        }
        private static void performCommand()
        {
            command = new SqlCommand(StoredPreName, connection);
            command.CommandType = CommandType.StoredProcedure;
            connection.Open();
            command.ExecuteNonQuery();
        }
    }
}
