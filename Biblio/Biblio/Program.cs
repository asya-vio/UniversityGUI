using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Biblio
{
   public static class Program
    {
        [STAThread]
       public static OleDbCommand OpenCommandConnection()
       {

           var con = System.Configuration.ConfigurationManager.ConnectionStrings["DBConnect"];
           OleDbConnection myOleDbConnection = new OleDbConnection(con.ConnectionString);
           OleDbCommand myOleDbCommand = myOleDbConnection.CreateCommand();

           return myOleDbCommand;

       }
        public static void Main()
        {

            var command = OpenCommandConnection();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new MainForm());



        }
    }
}
