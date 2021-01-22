using System;
using System.Collections.Generic;
using System.Text;

namespace CompostitionPolymorphismInheritance
{
    class PopUp : INotifications
    {
        public void Send()
        {
            Console.WriteLine("I am an annoying popup");
        }
    }
}
