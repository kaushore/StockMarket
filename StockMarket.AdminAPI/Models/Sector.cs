using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockMarket.AdminAPI.Models
{
    public class Sector
    {
        public string SectorId { get; set; }
        public string Name { get; set; }
        public string Brief { get; set; }
    }
}
