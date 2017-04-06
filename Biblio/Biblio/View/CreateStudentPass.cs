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
    public partial class CreateStudentPass : Form
    {
        public CreateStudentPass(Student student)
        {
            InitializeComponent();


            var IDPassLabel = new Label
            {
                Text = "Номер читательского билета",
                Dock = DockStyle.Fill
            };

            var IDPassBox = new TextBox
            {
                Width = 300,
                Dock = DockStyle.Left,
            };

            var IDLibraryLabel = new Label
            {
                Text = "Номер библиотеки",
                Dock = DockStyle.Fill
            };

            var IDLibraryBox = new TextBox
            {
                Width = 250,
                Dock = DockStyle.Left,
            };

            var CreatePassButton = new Button
            {
                Text = "Зарегистрировать билет",
                BackColor = Color.Chocolate,
                Width = 200,
                Dock = DockStyle.Left
            };

            var table = new TableLayoutPanel();
            table.RowStyles.Clear();
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.AutoSize, 30));

            table.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

            table.Controls.Add(new Panel(), 0, 0);
            table.Controls.Add(IDPassLabel, 0, 1);
            table.Controls.Add(IDPassBox, 0, 2);
            table.Controls.Add(IDLibraryLabel, 0, 3);
            table.Controls.Add(IDLibraryBox, 0, 4);
            table.Controls.Add(CreatePassButton, 0, 5);
            table.Controls.Add(new Panel(), 0, 6);

            table.Dock = DockStyle.Fill;
            Controls.Add(table);

        }
    }
}
