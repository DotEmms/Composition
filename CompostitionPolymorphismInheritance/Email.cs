using System;
using System.Collections.Generic;
using System.Text;

namespace CompostitionPolymorphismInheritance
{
    class Email : Notifications
    {
        public override void Send()
        {
            Console.WriteLine("You've got mail!");
        }
    }
}
