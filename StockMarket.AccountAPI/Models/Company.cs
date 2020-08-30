using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockMarket.AccountAPI.Models
{
    [Table("Company")]
    public class Company
    {
        [Key]
        [StringLength(30)]
        public string CompanyCode { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public double Turnover { get; set; }
        [Required]
        public string CEO { get; set; }
        public string BoardOfDirectors { get; set; }        
        public string Sector { get; set; }
        public string WriteUp { get; set; }
        [Required]
        public string StockCode { get; set; }
        public bool Activate { get; set; }
        public IEnumerable<StockPrice> StockPrices { get; set; } // Navif=gation Property
        // Same company Can have multiple Stock prices
    }
}
