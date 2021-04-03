using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiLibrary
{
    public class MonthCalendar : System.Windows.Forms.MonthCalendar, IMonthCalendar
    {
        private string name;
        public new string Name
        {
            get => name;
            set => name = value;
        }
    }
}
