using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallardDuck = new MallardDuck(); // экземпляр класса MallarDuck
            Duck redheadDuck = new RedheadDuck(); // экземпляр класса RedheadDuck
            Duck rubberDuck = new RubberDuck(); // экземпляр класса RubberDuck
            Duck decoyDuck = new DecoyDuck(); //  экземпляр класса DecoyDuck

            Duck[] ducks = new Duck[] { mallardDuck, redheadDuck, rubberDuck, decoyDuck }; // Массив уток с типом данных Duck

            for (int i = 0; i < ducks.Length; i++) 
            {
                Console.WriteLine(ducks[i].Display());
                Console.WriteLine(ducks[i].Swim());

                if (ducks[i] is IQuackable)
                    Console.WriteLine((ducks[i] as IQuackable).Quack());

                if (ducks[i] is IFlyable)
                    Console.WriteLine((ducks[i] as IFlyable).Fly());

                Console.WriteLine(" ");
            }

            Console.ReadKey();
        }
    }
}
