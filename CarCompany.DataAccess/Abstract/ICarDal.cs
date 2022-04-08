using CarCompany.DataAccess.Models;
using CarCompany.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCompany.DataAccess.Abstract
{
    public interface ICarDal:IEntityRepository<Car>
    {
    }
}
