using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockMarket.UserAPI.Models
{
    public class PlannedIPO
    {
        public string ID { get; set; }
        public string CompanyName { get; set; }
        public string StockExchange { get; set; }
        public float PricePerShare { get; set; }
        public long NumberOfShares { get; set; }
        public DateTime OpenDateTime { get; set; }
        public string Remarks { get; set; }
    }
}
