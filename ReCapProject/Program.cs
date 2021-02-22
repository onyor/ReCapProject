using Buisness.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ReCapProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarsGetAll();
            AddCars();
            Console.ReadKey();
        }

        private static void CarsGetAll()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetAll();

            if (result.Success)
            {
                foreach (var cars in result.Data)
                {
                    Console.WriteLine(cars.Description);
                }
            }
            Console.WriteLine(result.Message);
        }

        private static void AddCars()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car = new Car { BrandId = 6, ColorId = 7, DailyPrice = 250, ModelYear = 2017, Description = "En konforlu aracamız, bakımı yapılmış ve temiz." };
            var result = carManager.Add(car);

            if (result.Success)
            {
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
