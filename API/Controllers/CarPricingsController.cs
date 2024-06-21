﻿using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarPricingsController : ControllerBase
    {
        private readonly ICarPricingService _carPricingService;

        public CarPricingsController(ICarPricingService carPricingService)
        {
            _carPricingService = carPricingService;
        }
        [HttpGet]
        public IActionResult CarPricingWithCarList()
        {
            var carPricings = _carPricingService.TGetCarPricingWithCars();
            return Ok(carPricings);
        }
        [HttpGet("CarPricingListWithModel")]
        public IActionResult CarPricingListWithModel()
        {
            var carPricings = _carPricingService.TGetCarPricingListWithModel();
            return Ok(carPricings);
        }
    }
}