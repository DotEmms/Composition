using System;
using System.Collections.Generic;
using System.Text;

namespace CompostitionPolymorphismInheritance
{
    class Execution
    {
        //private SMS _sms;
        //private Email _email;
        //public Execution(SMS sms, Email email)
        //{
        //    _sms = sms;
        //    _email = email;
        //}
        //public void Process()
        //{
        //    _email.Send();
        //    _sms.Send();
        //}
        private List<Notifications> notificationsList; 

        public Execution(List<Notifications> list)
        {
            notificationsList = list;
        }

        public void Process()
        {
            foreach (Notifications notification in notificationsList)
            {
                notification.Send();
            }
        }
    }
}
