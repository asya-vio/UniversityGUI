using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblio
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();


            var SignUpButton = new Button
            {
                Text = "Зарегистрировать",
                Dock = DockStyle.Fill
            };

            var CatalogButton = new Button
            {
                Text = "Просмотреть каталог",
                Dock = DockStyle.Fill
            };

            var LandedItemsButton = new Button
            {
                Text = "Просмотр выданных книг",
                Dock = DockStyle.Fill
            };

            var table = new TableLayoutPanel();
            table.RowStyles.Clear();
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));


            table.Controls.Add(new Panel(), 0, 0);
            table.Controls.Add(SignUpButton, 0, 1);
            table.Controls.Add(CatalogButton, 0, 2);
            table.Controls.Add(LandedItemsButton, 0, 3);
            table.Controls.Add(new Panel(), 0, 4);

            table.Dock = DockStyle.Fill;
            Controls.Add(table);
        }

    }
}
