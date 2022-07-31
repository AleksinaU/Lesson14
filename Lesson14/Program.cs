using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Кошка");
            cat.ShowInfo();
            Dog dog = new Dog("Собака");
            dog.ShowInfo();
            Console.ReadKey();

        }
    }
}
