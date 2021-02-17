using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceTutorial_TA
{
    class GermanShephard : IBarkable
    {

        public string Name { get; set; }


        
        public string Bark()
        {
            return "roof";
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
