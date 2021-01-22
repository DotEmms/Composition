using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    class Human
    {
        private Animal _animal; //human has an animal
        public Human()
        {
            _animal = new Animal();
        }
        public void DoStuff()
        {
            _animal.Sleep();
            _animal.Eat();
        }
    }
}
