using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockMarket.UserAPI.Models
{
    public class Sector
    {
        [Key]
        public string SectorId { get; set; }
        public string Name { get; set; }
        public string Brief { get; set; }
    }
}
