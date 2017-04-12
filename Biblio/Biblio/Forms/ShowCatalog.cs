﻿using System;
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

            BackColor = Color.AntiqueWhite;
            WindowState = FormWindowState.Maximized;
            Font = new Font("Tahoma", 12, FontStyle.Regular);

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
            deleteBookButton.Click += deleteBookButton_Click;
            addExemplarBookButton.Click += AddExemplarBookButton_Click;

            ReadTree();
        }

        void ReadTree()
        {
            treeView.Nodes.Clear();

            var treeView1 = DBManager.GetBookTree();

            foreach (TreeNode node in treeView1.Nodes)
            {
                treeView.Nodes.Add((TreeNode)node.Clone());
            }

            treeView1.Nodes.Clear();

            Controls.Add(treeView);

        }


        void AddBookButton_Click(object sender, EventArgs e)
        {
            Form createBook = new CreateBook();

            createBook.ShowDialog();

            treeView.Nodes.Add(DBManager.GetNewBook());

            var numb = treeView.VisibleCount - 1;

            treeView.Nodes[numb].Nodes.Add(DBManager.GetNewExemplar());

            Controls.Add(treeView);

        }

        void deleteBookButton_Click(object sender, EventArgs e)
        {
            treeView.SelectedNode.Remove();
            string name = treeView.SelectedNode.Name.ToString();

            DBManager.DeleteBook(name);

        }

        private void AddExemplarBookButton_Click(object sender, EventArgs e)
        {
            string name = treeView.SelectedNode.Name.ToString();

            Form createBookExamplar = new CreateBookExemplar(name);

            createBookExamplar.ShowDialog();

            treeView.SelectedNode.Nodes.Add(DBManager.GetNewExemplar());

            Controls.Add(treeView);
        }

        //private void DeleteExemplarBookButton_Click(object sender, EventArgs e) 
        //{ 
        // string name = treeView.SelectedNode.Name.ToString(); 

        // //DBManager.DeleteBookExemplar(name); 

        // treeView.SelectedNode.Remove(); 
        //}




    }
}
