using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithAbstructFactory.Pattern
{
    class Client
    {
        private AbstractWater water;
        private AbstractBottle bottle;

        public Client(AbstractFactory factory)
        {
            //Абстрагирование процесса инстанцирования
            water = factory.CreateWater();
            bottle = factory.CreateBottle();
        }

        public void Run()
        {
            //Абстрагирование вариантов использования
            bottle.Interact(water);
        }
    }
}
