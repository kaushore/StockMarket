using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using StockMarket.ExcelAPI.Controllers;
using StockMarket.ExcelAPI.Models;
using StockMarket.ExcelAPI.Services;

namespace StockMarket.ExcelAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExcelController : ControllerBase
    {

        private IExcelService service;

        public ExcelController(IExcelService service)
        {
            this.service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Excel Service");
        }


        [HttpPost]
        [Route("ImportStock/{*filePath}")]
        public IActionResult ImportStock(string filePath)
        {            
            try
            {
                service.ImportStock(filePath);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
    
}
