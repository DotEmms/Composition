using System;
using System.Collections.Generic;
using System.Text;

namespace CompostitionPolymorphismInheritance
{
    class Email : INotifications
    {
        public void Send()
        {
            Console.WriteLine("You've got mail!");
        }
    }
}
