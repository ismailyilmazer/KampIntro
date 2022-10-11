using System;

namespace InterFacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //SOLID,Interface Segregation
            IWorker[] workers = new IWorker[3]
            {
                new Worker(),
                new Robot(),
                 new Manager()

            };

            IEat[] eat = new IEat[2] {new Manager(), new Worker() };
            
            
        }
    }
}
