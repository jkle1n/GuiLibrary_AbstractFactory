using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiLibrary
{
    public partial class Theme2Factory : Form, IAbstractFactory
    {
        private int tabIndex = 0;
        public new int TabIndex
        {
            get => tabIndex;
            set => tabIndex = value;
        }
        public void CreateTextBox(Point position, string name, Size size)
        {
            TextBox textBox = new TextBox();
            textBox.Location = position;
            textBox.Name = name;
            textBox.Size = size;
            textBox.TabIndex = TabIndex;
            Controls.Add(textBox);
            TabIndex++;
        }

        public void CreateButton(Point position, Color color, string name, Font font, Color foreColor,
            Size size, string text, EventHandler onClick)
        {
            Button button = new Button();
            button.BackColor = color;
            button.Font = font;
            button.ForeColor = foreColor;
            button.Location = position;
            button.Name = name;
            button.Size = size;
            button.TabIndex = TabIndex;
            button.Text = text;
            button.UseVisualStyleBackColor = false;
            button.Click += onClick;
            Controls.Add(button);
            TabIndex++;
        }
        public void CreateLabel(Point position, string name, Font font,
            Size size, string text, EventHandler onClick,
            ContentAlignment textAlign = ContentAlignment.TopLeft)
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Font = font;
            label.Location = position;
            label.Name = name;
            label.Size = size;
            label.TabIndex = TabIndex;
            label.Text = text;
            label.Click += onClick;
            label.TextAlign = textAlign;
            Controls.Add(label);
            TabIndex++;
        }
        public void CreateMonthCalendar(Point position, string name, Font font, Color foreColor, bool showWeekNumbers = false)
        {
            MonthCalendar monthCalendar = new MonthCalendar();
            monthCalendar.Font = font;
            monthCalendar.Location = position;
            monthCalendar.Name = name;
            monthCalendar.TabIndex = TabIndex;
            monthCalendar.TrailingForeColor = foreColor;
            monthCalendar.ShowWeekNumbers = showWeekNumbers;
            Controls.Add(monthCalendar);
            TabIndex++;
        }

        public void Init()
        {
            InitializeComponent();
            CreateButton(new Point(12, 271), SystemColors.ControlDark, "save", new Font("Microsoft Sans Serif", 10F, FontStyle.Italic, GraphicsUnit.Point, ((byte)(0))),
                SystemColors.Info, new Size(415,33), "Speichern", null);
            CreateMonthCalendar(new Point(439, 51), "monthCalendar", new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                 SystemColors.MenuHighlight, showWeekNumbers: true);
            CreateLabel(new Point(167, 15), "label_login", new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))),
                new Size(129, 27), "Anmelden", null, textAlign: ContentAlignment.MiddleCenter);
            CreateTextBox(new Point(149, 51), "textBox_name", new Size(278, 26));
            CreateLabel(new Point(9, 51), "label_name", new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                new Size(54, 18), "Name", null);
            CreateTextBox(new Point(149, 105), "textBox_email", new Size(278, 26));
            CreateLabel(new Point(9, 109), "label_name", new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                new Size(56, 18), "E-Mail", null);
            CreateTextBox(new Point(149, 157), "textBox_plz", new Size(278, 26));
            CreateLabel(new Point(9, 161), "label_plz", new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                new Size(116, 18), "Wohnort, PLZ", null);
            CreateTextBox(new Point(149, 210), "textBox_street", new Size(278, 26));
            CreateLabel(new Point(9, 214), "label_plz", new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                new Size(61, 18), "Straße", null);
            CreateLabel(new Point(436, 24), "label_bday", new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                new Size(121, 18), "Geburtsdatum", null);
        }
        public void Build()
        {
            Application.Run(this);
        }
    }
}
