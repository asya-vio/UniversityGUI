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

            string name = sender.ToString();

            string connectionString =
                       "provider=Microsoft.Jet.OLEDB.4.0;" + "data source=L:\\ИИТ\\ООП\\Git\\UniversityGUI\\Biblio\\Biblio\\BD.mdb";
            OleDbConnection myOleDbConnection = new OleDbConnection(connectionString);
            OleDbCommand myOleDbCommand = myOleDbConnection.CreateCommand();

            myOleDbCommand.CommandText = "DELETE * FROM Book WHERE ";

            myOleDbConnection.Open();

            OleDbDataReader dr = myOleDbCommand.ExecuteReader();


            dr.Close();
            myOleDbConnection.Close();
            //throw new NotImplementedException();
        }
    }
}
