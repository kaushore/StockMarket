using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockMarket.AdminAPI.Services;
using StockMarket.AdminAPI.Controllers;
using StockMarket.AdminAPI.Models;

namespace StockMarket.AdminAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        
        private IAdminService service;
        public AdminController(IAdminService service)
        {
            this.service = service;
        }
        

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Admin Service");
        }

        
        [HttpPost]
        [Route("AddStockExchange")]
        public IActionResult AddUser(StockExchange stockExchange)
        {
            try
            {
                service.AddStockExchange(stockExchange);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        [Route("AddCompany")]
        public IActionResult AddCompany(Company company)
        {
            try
            {
                service.AddCompany(company);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut]
        [Route("DeactivateCompany")]
        public IActionResult DeactivateCompany(string cid)
        {
            try
            {
                service.DeactivateCompany(cid);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete]
        [Route("DeleteStockExchange")]
        public IActionResult DeleteStockExchange(string sid)
        {
            try
            {
                service.DeleteStockExchange(sid);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        [Route("AddIPO")]
        public IActionResult AddIPO(PlannedIPO ipo)
        {
            try
            {
                service.AddIPO(ipo);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        [Route("UpdateIPO")]
        public IActionResult UpdateIPO(PlannedIPO ipo)
        {
            try
            {
                service.UpdateIPO(ipo);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

    }
}
