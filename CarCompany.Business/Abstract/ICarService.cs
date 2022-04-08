﻿using CarCompany.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCompany.Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        Car GetById(int id);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);

    }
}