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
            _cars = new List<Car>
            {
                new Car{CarId=1,ColorId=6,ModelYear=2015,DailyPrice=50000,Description="Hundai"},
                new Car{CarId=2,ColorId=10,ModelYear=2012,DailyPrice=150000,Description="BMW"},
                new Car{CarId=3,ColorId=13,ModelYear=2018,DailyPrice=97000,Description="Renault"},
                new Car{CarId=4,ColorId=11,ModelYear=2016,DailyPrice=80000,Description="Audi"},

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete= carToDelete = _cars.SingleOrDefault(c=>c.CarId==car.CarId);
            _cars.Remove(carToDelete);

        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(Car car)
        {
            //içindeki şarta uygun olanları yeni listede toplar,döndürür
            return _cars.Where(c=>c.CarId==car.CarId).ToList();
        }

        public List<Car> GetById(int CarId)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
