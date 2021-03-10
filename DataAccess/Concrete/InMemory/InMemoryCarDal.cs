using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;


        public InMemoryCarDal()
        {
            _cars = new List<Car> {
            
                new Car{Id=1,BrandId=1,ColorId=1,ModelYear=2001,DailyPrice=700,Description="Kiralık mercedes."},
                new Car{Id=2,BrandId=1,ColorId=12,ModelYear=2018,DailyPrice=1000,Description="Kiralık mercedes son model."},
                new Car{Id=3,BrandId=2,ColorId=8,ModelYear=2020,DailyPrice=600,Description="Kiralık peugeot son model."},
                new Car{Id=4,BrandId=2,ColorId=11,ModelYear=2008,DailyPrice=400,Description="Kiralık peugeot 2008."},
                new Car{Id=5,BrandId=3,ColorId=3,ModelYear=2020,DailyPrice=250,Description="Kiralık TOGG."},
                new Car { Id = 8, BrandId = 3, ColorId = 3, ModelYear = 2020, DailyPrice = 250, Description = "Kiralık Sedan." },

        };
        }



        public void Add(Car car)
        {
            _cars.Add(car);
            Console.WriteLine(car.Description+" başarıyla eklendi!.");
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id==car.Id);
            if (carToDelete != null)
            {
                _cars.Remove(carToDelete);
                Console.WriteLine(carToDelete.Description+ " başarıyla silindi.");
            }
            else
            {
                Console.WriteLine("Silmeye çalıştığınız araç bulunamadı!");
            }
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int carId)
        {
            return _cars.SingleOrDefault(c => c.Id == carId);
        }

        public void Update(Car car)
        {
            Car updatedCar = _cars.SingleOrDefault(c => c.Id == car.Id);
            updatedCar.BrandId = car.BrandId;
            updatedCar.ColorId = car.ColorId;
            updatedCar.DailyPrice = car.DailyPrice;
            updatedCar.Description = car.Description;
            updatedCar.ModelYear = car.ModelYear;


        }
    }
}
