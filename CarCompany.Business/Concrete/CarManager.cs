using CarCompany.Business.Abstract;
using CarCompany.DataAccess.Abstract;
using CarCompany.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCompany.Business.Concrete
{
    public class CarManager : ICarService
    {
        private readonly ICarDal _cardal;

        public CarManager(ICarDal cardal)
        {
            _cardal = cardal;
        }

        public void Add(Car car)
        {
            _cardal.Add(car);
        }

        public void Delete(Car car)
        {
            _cardal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _cardal.GetAll();
        }

        public Car GetById(int id)
        {
            return _cardal.Get(c => c.Id == id);
        }

        public void Update(Car car)
        {
            _cardal.Update(car);
        }
    }
}
