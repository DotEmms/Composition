using System;
using System.Collections.Generic;

namespace CompostitionPolymorphismInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<INotifications> list = new List<INotifications>();
            list.Add(new Email());
            list.Add(new SMS());
            list.Add(new SMS());
            list.Add(new Email());
            list.Add(new Email());
            list.Add(new Email());
            list.Add(new PopUp());
            Execution exe = new Execution(list);
            exe.Process();
            Console.ReadLine();
        }
    }
}
