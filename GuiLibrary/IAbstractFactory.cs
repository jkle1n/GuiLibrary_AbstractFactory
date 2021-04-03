using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace GuiLibrary
{
    public interface IAbstractFactory
    {
        int TabIndex { get; set; }
        void CreateTextBox(Point position, string name, Size size);
        void CreateButton(Point position, Color color, string name, Font font, Color foreColor,
            Size size, string text, EventHandler onClick);
        void CreateLabel(Point position, string name, Font font, Size size, string text, EventHandler onClick,
            ContentAlignment textAlign = ContentAlignment.TopLeft);
        void CreateMonthCalendar(Point position, string name, Font font, Color foreColor, bool showWeekNumbers = false);
        void Init();
        void Build();
    }
}
