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
        private void OpenConnection()
        {
            var con = System.Configuration.ConfigurationManager.ConnectionStrings["DBConnect"];
            OleDbConnection myOleDbConnection = new OleDbConnection(con.ConnectionString);
            OleDbCommand myOleDbCommand = myOleDbConnection.CreateCommand();
        }

        public void DeleteBook(string name)
        {
            OpenConnection();


        }
    }
}
