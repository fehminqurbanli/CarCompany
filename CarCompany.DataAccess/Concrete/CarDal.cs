using CarCompany.DataAccess.Abstract;
using CarCompany.DataAccess.Models;
using CarCompany.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCompany.DataAccess.Concrete
{
    public class CarDal:EfCoreRepositoryBase<Car,EfCoreDbContext>,ICarDal
    {
    }
}
