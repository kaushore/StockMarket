using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockMarket.ExcelAPI.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        [StringLength(10)]
        public string UserId { get; set; }

        [Required]
        [StringLength(40)]
        public string Username { get; set; }

        [Required]
        [StringLength(30)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [StringLength(20)]
        public string Email { get; set; }

        [StringLength(15)]
        public string Mobile { get; set; }
                
        public bool Confirmed { get; set; }
    }
}
