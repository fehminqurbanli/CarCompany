using CarCompany.DataAccess.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        public string filename = @"carDb.txt";


        [HttpPost]
        public IActionResult AddCar(Car car)
        {
            StreamWriter sw = new StreamWriter(filename,true);
            sw.WriteLine(car.Id+"-"+car.Brand + "-" + car.Model + "-" + car.Color + "-" + car.Year);
            sw.Close();
            return Ok();
        }

        [HttpGet("GetCars")]
        public IActionResult GetCars()
        {
            List<string> list = new List<string>();

            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    list.Add(line);
                }
            }
            return Ok(list);
        }

        [HttpGet("{id}")]
        public IActionResult GetCarById(int id)
        {
            string car=null;
            
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if(id.ToString()==line.Split('-').First())
                    {
                        car = line;
                        break;
                    }
                }
            }
            return Ok(car);
        }


    }
}
