using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockMarket.AccountAPI.Services;
using StockMarket.AccountAPI.Controllers;
using StockMarket.AccountAPI.Models;

namespace StockMarket.AccountAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private IAccountService service;
        public AccountController(IAccountService service)
        {
            this.service = service;
        }
        [HttpPost]
        [Route("AddUser")]
        public IActionResult AddUser (User item)
        {
            try
            {
                service.AddUser(item);
                return Ok();
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
