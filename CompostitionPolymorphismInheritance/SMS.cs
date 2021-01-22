using System;
using System.Collections.Generic;
using System.Text;

namespace CompostitionPolymorphismInheritance
{
    class SMS : INotifications
    {
        public void Send()
        {
            Console.Beep(500, 600);
            Console.WriteLine("Textmessage received!");
        }
    }
}
