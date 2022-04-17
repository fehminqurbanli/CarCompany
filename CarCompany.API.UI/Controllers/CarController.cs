using CarCompany.API.UI.NLog;
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
        private readonly ILoggerService _logger;
        public CarController(ICarService carService, ILoggerService logger)
        {
            _carService = carService;
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> AddCar(Car car)
        {
            await _carService.Add(car);
            return Ok();
        }

        [HttpGet("GetCars")]
        public async Task<IActionResult> GetCars()
        {
            _logger.LogInfo("Accessed Car controller");
            var result= await _carService.GetAll();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCarById(int id)
        {
            var result =await _carService.GetById(id);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update(Car car)
        {
            
            await _carService.Update(car);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var deletedCar = await _carService.GetById(id);
            await _carService.Delete(deletedCar);
            return Ok();
        }


    }
}
