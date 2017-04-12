using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewBostonTutorials
{
    class myclass
    {
        enum names
        {
            Adam = 1,
            Joe = 5,
            Bob, 
        }

        public string Name
        {
            get;
            private set;
        }
        public myclass(string name)
        {
            Name = name;
        }

        public string name()
        {
            return Name;
        }

        public static void ShowMessage(string message)
        {
            System.Windows.Forms.MessageBox.Show(message);
        }

        private names myName = names.Adam;

        public static void ShowMessage(int message)
        {
            System.Windows.Forms.MessageBox.Show(message.ToString());
        }
    }
}
