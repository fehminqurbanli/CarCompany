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

        public async Task Add(Car car)
        {
            await _cardal.Add(car);
        }

        public async Task Delete(Car car)
        {
            await _cardal.Delete(car);
        }

        public async Task<IEnumerable<Car>> GetAll()
        {
            return await _cardal.GetAll();
        }

        public async Task<Car> GetById(int id)
        {
            return await _cardal.Get(c => c.Id == id);
        }

        public async Task Update(Car car)
        {
            await _cardal.Update(car);
        }
    }
}
