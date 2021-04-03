using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiLibrary
{
    public class Button : System.Windows.Forms.Button, IButton
    {
        private string name;
        public new string Name { 
            get => name;
            set => name = value; 
        }
    }
}
