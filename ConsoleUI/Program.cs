using Bussiness.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter=0;
            EfCarDal efCarDal = new EfCarDal();
            CarManager carManager = new CarManager(efCarDal);

            
          
           
            Car car1 = new Car { BrandId = 3, ColorId = 3, ModelYear = 2020, DailyPrice = 250, Description = "Kiralık Sedan" ,CarName="Sedan"};

            Car car2 = new Car { BrandId = 5, ColorId = 4, ModelYear = 2020, DailyPrice = 0, Description = "Kiralık peugeot", CarName = "Peugeot" };

            Car car3 = new Car { BrandId = 6, ColorId = 1, ModelYear = 2001, DailyPrice = 100, Description = "Kiralık Hyundai", CarName = "Hyundai" };

            Car car4 = new Car { BrandId = 1, ColorId = 4, ModelYear = 2020, DailyPrice = 350, Description = "Kiralık peugeot", CarName = "Peugeot" };

          
            foreach (var Car in carManager.GetCarDetails())
            {
                counter++;
                Console.WriteLine(counter + "-" + Car.CarName+"\nBrand: "+Car.BrandName+ "\nColor: " + Car.ColorName+ "\nDaily price: " + Car.DailyPrice+ "\n-------------------------");
            }






        }
    }
}
