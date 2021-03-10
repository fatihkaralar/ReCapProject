using Bussiness.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            InMemoryCarDal inMemoryCarDal = new InMemoryCarDal();
            CarManager carManager = new CarManager(inMemoryCarDal);

            foreach (var Car in carManager.GetAll())
            {
                Console.WriteLine(Car.Description);
            }
            Console.WriteLine("----------------------------------------------------");
            Car car1 = new Car { Id = 8, BrandId = 3, ColorId = 3, ModelYear = 2020, DailyPrice = 250, Description = "Kiralık Sedan." };
            carManager.Delete(car1);
            Console.WriteLine("----------------------------------------------------");


            foreach (var Car in carManager.GetAll())
            {
                Console.WriteLine(Car.Description);
            }
            Console.WriteLine("----------------------------------------------------");
            carManager.Add(car1);
            Console.WriteLine("----------------------------------------------------");
            foreach (var Car in carManager.GetAll())
            {
                Console.WriteLine(Car.Description);
            }

        }
    }
}
