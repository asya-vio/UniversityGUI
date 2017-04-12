using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Biblio
{
    public static class DBManager
    {
        private static void OpenConnection()
        {
            var con = System.Configuration.ConfigurationManager.ConnectionStrings["DBConnect"];
            OleDbConnection myOleDbConnection = new OleDbConnection(con.ConnectionString);
            OleDbCommand myOleDbCommand = myOleDbConnection.CreateCommand();
        }

        public static void DeleteBook(string name)
        {
            var con = System.Configuration.ConfigurationManager.ConnectionStrings["DBConnect"];
            OleDbConnection myOleDbConnection = new OleDbConnection(con.ConnectionString);
            OleDbCommand myOleDbCommand = myOleDbConnection.CreateCommand();

            myOleDbCommand.CommandText = string.Format("{0}'{1}'", "DELETE FROM Book WHERE [Name] = ", name);

            myOleDbConnection.Open();

            myOleDbCommand.ExecuteNonQuery();

            myOleDbConnection.Close();

        }

        public static string GetNewBook()
        {
            string resultString = "";

            var con = System.Configuration.ConfigurationManager.ConnectionStrings["DBConnect"];
            OleDbConnection myOleDbConnection = new OleDbConnection(con.ConnectionString);
            OleDbCommand myOleDbCommand = myOleDbConnection.CreateCommand();

            myOleDbCommand.CommandText = "SELECT top 1 [Name], [Authors] FROM Book order by [Код] desc";

            myOleDbConnection.Open();

            OleDbDataReader dr = myOleDbCommand.ExecuteReader();

            if (dr.HasRows)
            {

                while (dr.Read())
                {
                    resultString += ["Name"].ToString() + " \"  " + dr["Authors"].ToString();
                }

            }

            return resultString;
        }
    }
}
