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
    public partial class SignUpChoice : Form
    {
        public SignUpChoice()
        {
            InitializeComponent();

            var ChoiceLabel = new Label
            {
                Text = "Выберите тип абонемента",
                Dock = DockStyle.Fill
            };

            var StudentButton = new Button
            {
                Text = "Студент",
                Dock = DockStyle.Fill
            };

            var TeacherButton = new Button
            {
                Text = "Преподаватель",
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
            table.Controls.Add(ChoiceLabel, 0, 1);
            table.Controls.Add(StudentButton, 0, 2);
            table.Controls.Add(TeacherButton, 0, 3);
            table.Controls.Add(new Panel(), 0, 4);

            table.Dock = DockStyle.Fill;
            Controls.Add(table);
        }
    }
}
