using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
                    resultString += dr["Name"].ToString() + " \"  " + dr["Authors"].ToString();
                }

            }

            return resultString;
        }

        public static TreeView GetBookTree()
        {
            TreeView treeView = new TreeView();

            var con = System.Configuration.ConfigurationManager.ConnectionStrings["DBConnect"];
            OleDbConnection myOleDbConnection = new OleDbConnection(con.ConnectionString);

            myOleDbConnection.Open();

            OleDbCommand myOleDbCommand = myOleDbConnection.CreateCommand();
            myOleDbCommand.CommandText = "SELECT [Name], [Authors] FROM Book";
            OleDbDataReader dr = myOleDbCommand.ExecuteReader();

            int n = 0;

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    treeView.Nodes.Add("\"" + dr["Name"].ToString() + "\"  " + dr["Authors"].ToString());

                    OleDbCommand myOleDbCommand2 = myOleDbConnection.CreateCommand();
                    myOleDbCommand2.CommandText = string.Format("{0}'{1}'",
                        "SELECT [PublicationDate], [InventoryNumber], [Presence] FROM BookExemplar WHERE Name = ",
                        dr["Name"].ToString());
                    OleDbDataReader dr2 = myOleDbCommand2.ExecuteReader();

                    if (dr2.HasRows)
                    {
                        while (dr2.Read())
                        {
                            string text = string.Format("Инв. № {0}, Год издания: {1}, в наличии: {2}",
                                dr2["InventoryNumber"].ToString(),
                                dr2["PublicationDate"].ToString(),
                                dr2["Presence"].ToString());

                            treeView.Nodes[n].Nodes.Add(text);
                        }
                    }
                    dr2.Close();
                    n++;
                }
            }

            dr.Close();
            myOleDbConnection.Close();

            return treeView;
        }
    }
}
