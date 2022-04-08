using CarCompany.Business.Abstract;
using CarCompany.DataAccess.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CarCompany.API.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpPost]
        public IActionResult AddCar(Car car)
        {
            _carService.Add(car);
            return Ok();
        }

        [HttpGet("GetCars")]
        public IActionResult GetCars()
        {

            var result=_carService.GetAll();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetCarById(int id)
        {
            var result = _carService.GetById(id);
            return Ok(result);
        }

        [HttpPut]
        public IActionResult Update(int id, Car car)
        {
            var updatedCar = _carService.GetById(id);
            
            _carService.Update(car);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var deletedCar = _carService.GetById(id);
            _carService.Delete(deletedCar);
            return Ok();
        }


    }
}
