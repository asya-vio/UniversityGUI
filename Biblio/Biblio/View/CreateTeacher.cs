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
    public partial class CreateTeacher : Form
    {
        public CreateTeacher()
        {
            BackColor = Color.CadetBlue;
            WindowState = FormWindowState.Maximized;

            InitializeComponent();

            var LastNameLabel = new Label
            {
                Text = "Фамилия",
                Dock = DockStyle.Left
            };

            var LastNameBox = new TextBox
            {
                Width = 250,
                Dock = DockStyle.Left,
            };

            var NameLabel = new Label
            {
                Text = "Имя",
                Dock = DockStyle.Fill
            };

            var NameBox = new TextBox
            {
                Width = 250,
                Dock = DockStyle.Left,
            };

            var SecondNameLabel = new Label
            {
                Text = "Отчество",
                Dock = DockStyle.Fill
            };

            var SecondNameBox = new TextBox
            {
                Width = 250,
                Dock = DockStyle.Left,
            };

            var AddressLabel = new Label
            {
                Text = "Адрес",
                Dock = DockStyle.Left
            };

            var AddressBox = new TextBox
            {
                Width = 250,
                Dock = DockStyle.Left
            };

            var PhoneNumberLabel = new Label
            {
                Text = "Телефон",
                Dock = DockStyle.Fill
            };

            var PhoneNumberBox = new TextBox
            {
                Dock = DockStyle.Fill,
            };

            var TeacherNumberLabel = new Label
            {
                Text = "Табельный номер",
                Dock = DockStyle.Fill
            };

            var TeacherNumberBox = new TextBox
            {
                Dock = DockStyle.Fill,
            };

            var FacultyLabel = new Label
            {
                Text = "Факультет",
                Dock = DockStyle.Fill
            };

            var FacultyBox = new TextBox
            {
                Dock = DockStyle.Fill,
            };

            var JobLabel = new Label
            {
                Text = "Должность",
                Dock = DockStyle.Fill
            };

            var JobBox = new TextBox
            {
                Width = 250,
                Dock = DockStyle.Fill,
            };

            var CreatingStudentButton = new Button
            {
                Text = "Внести в базу",
                BackColor = Color.Chocolate,
                Width = 200,
                Dock = DockStyle.Left
            };

            var table = new TableLayoutPanel();
            table.RowStyles.Clear();
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            table.RowStyles.Add(new RowStyle(SizeType.AutoSize, 30));
            table.RowStyles.Add(new RowStyle(SizeType.AutoSize, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.AutoSize, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

            table.Controls.Add(new Panel(), 0, 0);
            table.Controls.Add(LastNameLabel, 0, 1);
            table.Controls.Add(LastNameBox, 0, 2);
            table.Controls.Add(NameLabel, 0, 3);
            table.Controls.Add(NameBox, 0, 4);
            table.Controls.Add(SecondNameLabel, 0, 5);
            table.Controls.Add(SecondNameBox, 0, 6);
            table.Controls.Add(AddressLabel, 0, 7);
            table.Controls.Add(AddressBox, 0, 8);
            table.Controls.Add(PhoneNumberLabel, 0, 9);
            table.Controls.Add(PhoneNumberBox, 0, 10);
            table.Controls.Add(TeacherNumberLabel, 0, 11);
            table.Controls.Add(TeacherNumberBox, 0, 12);
            table.Controls.Add(FacultyLabel, 0, 13);
            table.Controls.Add(FacultyBox, 0, 14);
            table.Controls.Add(JobLabel, 0, 15);
            table.Controls.Add(JobBox, 0, 16);
            table.Controls.Add(CreatingStudentButton, 0, 17);
            table.Controls.Add(new Panel(), 0, 18);

            table.Dock = DockStyle.Fill;
            Controls.Add(table);
        }
    }
}
