using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurante.Models
{
    public class FoodMenu
    {
        public int FoodMenuId { get; set; }

        [Required]
        [StringLength (200)]
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal price { get; set; }
    }
}
