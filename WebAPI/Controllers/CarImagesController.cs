using Business.Abstarct;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {
        ICarImageService _carimageservice;

        public CarImagesController(ICarImageService carimageservice)
        {
            _carimageservice = carimageservice;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            // _productService = new ProductManeger(new EFProductDal());
            var result = _carimageservice.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }



        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _carimageservice.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(CarImage image)
        {
            var result = _carimageservice.Add(image);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost("update")]
        public IActionResult Update(CarImage image)
        {
            var result = _carimageservice.Update(image);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost("delete")]
        public IActionResult Delete(CarImage image)
        {
            var result = _carimageservice.Delete(image);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

    }
}
