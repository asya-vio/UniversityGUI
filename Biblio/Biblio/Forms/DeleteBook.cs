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
    public partial class DeleteBook : Form
    {
        TreeView treeView;
       

        public DeleteBook(TreeView treeView)
        {
            InitializeComponent();

            this.treeView = treeView;

            Controls.Add(treeView);

            treeView.NodeMouseClick += TreeView_NodeMouseClick;




        }

        private void TreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            string treeNodeRow = sender.ToString();
            string name = "";

            for (int i = 0; i < treeNodeRow.Length; i++)
            {                
                if (treeNodeRow[i] != '"') continue;
                else
                {                    
                    while (treeNodeRow[i] != '"')
                    {
                        i++;
                        name += treeNodeRow[i];
                    }
                }

            }
            //name.TrimEnd();



            var con = System.Configuration.ConfigurationManager.ConnectionStrings["DBConnect"];
            OleDbConnection myOleDbConnection = new OleDbConnection(con.ConnectionString);
            OleDbCommand myOleDbCommand = myOleDbConnection.CreateCommand();

            myOleDbCommand.CommandText = "DELETE * FROM Book WHERE Name = '"+ name+"'";

            myOleDbConnection.Open();

            OleDbDataReader dr = myOleDbCommand.ExecuteReader();


            dr.Close();
            myOleDbConnection.Close();
            //throw new NotImplementedException();
        }
    }
}
