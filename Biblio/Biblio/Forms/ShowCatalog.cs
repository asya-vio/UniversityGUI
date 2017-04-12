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
        Button deleteBookButton;
        Button addExemplarBookButton;
        Button deleteExemplarBookButton;

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
                Location = new Point(900, 100),
                Width = 200,
                Height = 150,
                Text = "Добавить книгу",
                BackColor = Color.Azure
            };

            this.deleteBookButton = new Button()
            {
                Location = new Point(1200, 100),
                Width = 200,
                Height = 150,
                Text = "Удалить книгу",
                BackColor = Color.Azure
            };

            this.addExemplarBookButton = new Button()
            {
                Location = new Point(900, 300),
                Width = 200,
                Height = 150,
                Text = "Добавить экземпляр книги",
                BackColor = Color.Azure
            };

            this.deleteExemplarBookButton = new Button()
            {
                Location = new Point(1200, 300),
                Width = 200,
                Height = 150,
                Text = "Удалить экземпляр книги",
                BackColor = Color.Azure
            };


            Controls.Add(addBookButton);
            Controls.Add(deleteBookButton);
            Controls.Add(addExemplarBookButton);
            Controls.Add(deleteExemplarBookButton);
            Controls.Add(treeView);
            addBookButton.Click += AddBookButton_Click;
            deleteBookButton.Click += deleteBookButton_Click;

            ReadTree();
        }

            void ReadTree()
            {
                treeView.Nodes.Clear();

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
                        //listBox.Items.Add(dr["Name"] + " " + dr["Authors"]);
                        treeView.Nodes.Add("\"" + dr["Name"].ToString() +"\"" + dr["Authors"].ToString());

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
            }


    

        void AddBookButton_Click(object sender, EventArgs e)
        {
            Form createBook = new CreateBook();

            createBook.ShowDialog();


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

                    treeView.Nodes.Add(dr["Name"].ToString() + " " + dr["Authors"].ToString());
                    
                }

            }
            Controls.Add(treeView);

        }

        void deleteBookButton_Click(object sender, EventArgs e)
        {
            var treeNodeRow = treeView.SelectedNode.ToString();

            string name = "";

            for (int i = 0; i < treeNodeRow.Length; i++)
            {
                if (treeNodeRow[i] == '"') 
                {
                    while (treeNodeRow[i] != '"')
                    {
                        i++;
                        name += treeNodeRow[i];
                    }

                }
                else continue;

            }

            var con = System.Configuration.ConfigurationManager.ConnectionStrings["DBConnect"];
            OleDbConnection myOleDbConnection = new OleDbConnection(con.ConnectionString);
            OleDbCommand myOleDbCommand = myOleDbConnection.CreateCommand();

            myOleDbCommand.CommandText = string.Format("{0}'{1}'", "DELETE FROM Book WHERE [Name] = ", name);

            myOleDbConnection.Open();

            myOleDbCommand.ExecuteNonQuery();

            myOleDbConnection.Close();

            treeView.SelectedNode.Remove();



        }


    }
}
