using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockMarket.AdminAPI.Models
{
    [Table("StockPrice")]
    public class StockPrice
    {
        [Key]
        public int RowID { get; set; }
        [ForeignKey("Company")]
        [StringLength(30)]
        public string CompanyCode { get; set; }
        [Required] 
        public string StockExchange { get; set; }
        [Required]
        public string CurrentPrice { get; set; }
        [Required]
        [Column(TypeName = "Date")] // this is to endure that we only need date and not time
        public DateTime Date { get; set; }
        public string Time { get; set; }
        public Company Company { get; set; } // Navigation Prop
    }
}
