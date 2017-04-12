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

            treeView = DBManager.GetBookTree();

            Controls.Add(treeView);

        }




        void AddBookButton_Click(object sender, EventArgs e)
        {
            Form createBook = new CreateBook();

            createBook.ShowDialog();

            treeView.Nodes.Add(DBManager.GetNewBook());

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

            DBManager.DeleteBook(name);

            treeView.SelectedNode.Remove();

        }


    }
}
