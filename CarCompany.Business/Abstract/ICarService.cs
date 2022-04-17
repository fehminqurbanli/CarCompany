using CarCompany.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCompany.Business.Abstract
{
    public interface ICarService
    {
        Task< IEnumerable<Car>> GetAll();
        Task< Car> GetById(int id);
        Task Add(Car car);
        Task Update(Car car);
        Task Delete(Car car);

    }
}
