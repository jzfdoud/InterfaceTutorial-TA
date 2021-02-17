using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceTutorial_TA
{
    class BassetHound : IBarkable
    {

        public string Name { get; set; }

        public string Bark()
        {
            return "it howls";
        }

        public string GetName()
        {
            return Name;
        }

        public void SetName(string name)
        {
            this.Name = name;
        }

    }
}
