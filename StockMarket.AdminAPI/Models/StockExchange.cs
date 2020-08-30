using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockMarket.AdminAPI.Models
{
    [Table("StockExchanges")]
    public class StockExchange
    {
        [Key]
        public string StockExchangeId { get; set; }
        public string Name { get; set; }
        public string Brief { get; set; }        
        public string Address { get; set; }
        public string Remarks { get; set; }

    }
}
