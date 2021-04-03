using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiLibrary
{
    public class Label : System.Windows.Forms.Label, ILabel
    {
        private string name;
        public new string Name
        {
            get => name;
            set => name = value;
        }
    }
}
