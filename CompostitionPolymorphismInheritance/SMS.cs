using System;
using System.Collections.Generic;
using System.Text;

namespace CompostitionPolymorphismInheritance
{
    class SMS : Notifications
    {
        public override void Send()
        {
            Console.Beep(500, 600);
            Console.WriteLine("Textmessage received!");
        }
    }
}
