using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceTutorial_TA
{
    interface IBarkable
    {

        string Bark();
        string GetName(); // get Name
        void SetName(string name); // gives Name a new value
    }
}
