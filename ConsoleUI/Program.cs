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
            int counter = 0;
            EfCarDal efCarDal = new EfCarDal();
            CarManager carManager = new CarManager(efCarDal);

            EfBrandDal efBrandDal = new EfBrandDal();
            BrandManager brandManager = new BrandManager(efBrandDal);

            EfRentalDal efRentalDal = new EfRentalDal();
            RentalManager rentalManager = new RentalManager(efRentalDal);

            EfUserDal efUserDal = new EfUserDal();
            UserManager userManager = new UserManager(efUserDal);

            EfCustomerDal efCustomerDal = new EfCustomerDal();
            CustomerManager customerManager = new CustomerManager(efCustomerDal);

          


            
            User user = new User { FirstName = "Fatih", LastName = "KARALAR", Email = "fthkrlr@hotmail.com", Password = "******" ,Id=4};
            Customer customer = new Customer { CompanyName = "Fatih KARALAR",UserId=4,Id=12};
           // userManager.Add(user);
           customerManager.Add(customer);



           
            



            Car car1 = new Car { BrandId = 3, ColorId = 3, ModelYear = 2020, DailyPrice = 250, Description = "Kiralık Sedan", CarName = "Sedan" };

            Car car2 = new Car { BrandId = 5, ColorId = 4, ModelYear = 2020, DailyPrice = 0, Description = "Kiralık peugeot", CarName = "Peugeot" };

            Car car3 = new Car { BrandId = 6, ColorId = 1, ModelYear = 2001, DailyPrice = 100, Description = "Kiralık Hyundai", CarName = "Hyundai" };

            Car car4 = new Car { BrandId = 1, ColorId = 4, ModelYear = 2020, DailyPrice = 350, Description = "Kiralık peugeot", CarName = "Peugeot" };

            Car car5 =new Car { BrandId = 1, ColorId = 4, ModelYear = 2020, DailyPrice = 350, Description = "Kiralık peugeot", CarName = "Peugeot" };
           

            // GetCarDetailsTest(counter, carManager);
           // GetAllBrandsTest(counter, brandManager);

        }

        private static void GetAllBrandsTest(int counter, BrandManager brandManager)
        {
            foreach (var Brand in brandManager.GetAll().Data)
            {
                counter++;
                Console.WriteLine(counter+"-"+brandManager.GetAll().Message + "  " + Brand.BrandName);

            }

            
        }

        private static void GetCarDetailsTest(int counter, CarManager carManager)
        {
            foreach (var Car in carManager.GetCarDetails().Data)
            {
                counter++;
                Console.WriteLine(carManager.GetCarDetails().Message);
                Console.WriteLine(counter + "-" + Car.CarName + "\nBrand: " + Car.BrandName + "\nColor: " + Car.ColorName + "\nDaily price: " + Car.DailyPrice + "\n-------------------------");

            }

           
        }
    }
}
