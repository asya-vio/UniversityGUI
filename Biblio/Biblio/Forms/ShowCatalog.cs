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
    public partial class ShowCatalog : Form
    {
        ListBox listBox;
        TreeView treeView;
        Button addBookButton;

        public ShowCatalog()
        {

            InitializeComponent();

            this.listBox = new ListBox
            {
                Width = 600,
                Height = 1000
            };

            this.treeView = new TreeView
            {
                Width = 800,
                Height = 1000
            };



            BackColor = Color.AntiqueWhite;
            WindowState = FormWindowState.Maximized;
            Font = new Font("Tahoma", 12, FontStyle.Regular);

            this.addBookButton = new Button()
            {
                Location = new Point(900,100),
                Width = 200,
                Height = 150,
                Text = "Добавить книгу",
                BackColor = Color.Azure
            };
            Controls.Add(addBookButton);

            string connectionString =
                        "provider=Microsoft.Jet.OLEDB.4.0;" + "data source=L:\\ИИТ\\ООП\\Git\\UniversityGUI\\Biblio\\Biblio\\BD.mdb";
            OleDbConnection myOleDbConnection = new OleDbConnection(connectionString);
            OleDbCommand myOleDbCommand = myOleDbConnection.CreateCommand();

            myOleDbCommand.CommandText  = "SELECT [Name], [Authors] FROM Book";

            myOleDbConnection.Open();


            OleDbDataReader dr = myOleDbCommand.ExecuteReader();

            int i = 0;
            if (dr.HasRows)
            {

                while (dr.Read())
                {

                    treeView.Nodes.Add(dr["Name"].ToString() + " " + dr["Authors"].ToString());

                    string connection1String =
                    "provider=Microsoft.Jet.OLEDB.4.0;" + "data source=L:\\ИИТ\\ООП\\Git\\UniversityGUI\\Biblio\\Biblio\\BD.mdb";

                    OleDbConnection myOleDbConnection1 = new OleDbConnection(connection1String);
                    OleDbCommand myOleDbCommand1 = myOleDbConnection1.CreateCommand();

                    myOleDbCommand1.CommandText = "SELECT [InventoryNumber], [PublicationDate], [Presence] FROM BookExemplar";

                    myOleDbConnection1.Open();

                    OleDbDataReader ex = myOleDbCommand1.ExecuteReader();

                    if (ex.HasRows)
                    {
                        while (ex.Read())
                        {
                            treeView.Nodes[i].Nodes.Add("Инвентарный номер: " + ex["InventoryNumber"].ToString() + "  "
                                + "Год публикации: " + ex["PublicationDate"].ToString() + " " + "Наличие: " +ex ["Presence"].ToString());
                        }

                    }
                    ex.Close();
                    myOleDbConnection1.Close();
                   

                    i++;
                }

            }

            dr.Close();
            myOleDbConnection.Close();

            Controls.Add(treeView);

            addBookButton.Click += AddBookButton_Click;

        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            Form createBook = new CreateBook();

            createBook.ShowDialog();


            string connectionString =
                       "provider=Microsoft.Jet.OLEDB.4.0;" + "data source=L:\\ИИТ\\ООП\\Git\\UniversityGUI\\Biblio\\Biblio\\BD.mdb";
            OleDbConnection myOleDbConnection = new OleDbConnection(connectionString);
            OleDbCommand myOleDbCommand = myOleDbConnection.CreateCommand();

            myOleDbCommand.CommandText = "SELECT top 1 [Name], [Authors] FROM Book order by [Код] desc";

            myOleDbConnection.Open();

            OleDbDataReader dr = myOleDbCommand.ExecuteReader();

            if (dr.HasRows)
            {

                while (dr.Read())
                {

                    treeView.Nodes.Add(dr["Name"].ToString() + " " + dr["Authors"].ToString());
                    
                }

            }
            Controls.Add(treeView);

        }


    }
}
