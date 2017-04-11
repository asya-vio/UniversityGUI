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

        public ShowCatalog()
        {

            InitializeComponent();

            this.listBox = new ListBox()
            {
                Width = 800,
                Height = 1000
            };

            this.treeView = new TreeView()
            {
                Width = 800,
                Height = 1000
            };

            BackColor = Color.AntiqueWhite;
            WindowState = FormWindowState.Maximized;
            Font = new Font("Tahoma", 12, FontStyle.Regular);

            //int countLines = 0;
            //for (int i = 0; i < Catalog.ListOfExpertiseArea.Count(); i++)
            //    countLines += Catalog.ListOfExpertiseArea[i].ListOfBook.Count();

            //var table = new TableLayoutPanel();


            //table.RowStyles.Clear();
            //table.RowStyles.Add(new RowStyle(SizeType.Percent, 95));
            //for (int i = 0; i < countLines; i++)
            //{
            //    table.RowStyles.Add(new RowStyle(SizeType.AutoSize, 30));
            //}
            //table.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            //table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));


            //table.Controls.Add(new Panel(), 0, 0);
            //for (int i = 0; i < Catalog.ListOfExpertiseArea.Count(); i++)
            //{ 
            //    for (int j = 0; j < Catalog.ListOfExpertiseArea[i].ListOfBook.Count(); j++)
            //    {
            //        var label = new Label
            //        {
            //            Text = Catalog.ListOfExpertiseArea[i].ListOfBook[j].Name,
            //            Width = 200,
            //            Dock = DockStyle.Left,
            //            BorderStyle = BorderStyle.FixedSingle
            //        };

            //        //label.Click += label_Click(Catalog.ListOfExpertiseArea[i].ListOfBook[j], );

            //        var exemplars = new ComboBox()
            //        {
            //            Width = 1500,
            //            Dock = DockStyle.Right         
            //        };
            //        List<BookExemplar> exemplars1 = Catalog.ListOfExpertiseArea[i].ListOfBook[j].ShowExemplars();

            //        for (int k = 0; k < exemplars1.Count(); k++)
            //        {
            //            string info = "Инвентарный номер: "+ exemplars1[k].InventoryNumber +"    | " +
            //                " Наличие: " + exemplars1[k].Presence.ToString() + "    | "  + " Дата публикации: " +  exemplars1[k].PublicationDate;
            //            exemplars.Items.Add(info);
            //        }

            //        table.Controls.Add(label, 0, i+1);
            //        table.Controls.Add(exemplars, 1, i+1);






            //}
            //}
            //table.Controls.Add(new Panel(), 0, countLines + 1);

            //table.Dock = DockStyle.Fill;
            //Controls.Add(table);


            string connectionString =
                        "provider=Microsoft.Jet.OLEDB.4.0;" + "data source=L:\\ИИТ\\ООП\\Git\\UniversityGUI\\Biblio\\Biblio\\BD.mdb";
            OleDbConnection myOleDbConnection = new OleDbConnection(connectionString);
            OleDbCommand myOleDbCommand = myOleDbConnection.CreateCommand();

            myOleDbCommand.CommandText  = "SELECT [Name], [Authors] FROM Book";

            myOleDbConnection.Open();


            OleDbDataReader dr = myOleDbCommand.ExecuteReader();

            if (dr.HasRows)
            {

                while (dr.Read())
                {


                    //listBox.Items.Add(dr["Name"] + " " + dr["Authors"]);


                    treeView.Nodes.Add(dr["Name"].ToString() + " " + dr["Authors"].ToString());
                }

            }

            myOleDbConnection.Close();
            dr.Close();

            //Controls.Add(listBox);
            Controls.Add(treeView);



        }
        //EventArgs clickArg = new EventArgs(j)
        //{
        //};

        void label_Click(object sender, EventArgs e)
        {

            //throw new NotImplementedException();
        }
    }
}
