using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var c in carManager.GetALL())
            {
                Console.WriteLine(c.Description);
                Console.WriteLine(c.DailyPrice);
                Console.WriteLine(c.ModelYear);
            }

        }
    }
}
