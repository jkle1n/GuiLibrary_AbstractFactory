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
    public class Client
    {
        public Client()
        {
            ClientMethod(new WindowsFeelFactory());
        }
        public void ClientMethod(IAbstractFactory factory)
        {
            factory.Init();
            factory.Build();
        }
    }
}
