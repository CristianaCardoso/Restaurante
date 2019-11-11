using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Restaurante.Models
{
    public class RestauranteDbContext : DbContext
    {
        public RestauranteDbContext (DbContextOptions<RestauranteDbContext> options)
            : base(options)
        {
        }

        public DbSet<Restaurante.Models.FoodMenu> FoodMenu { get; set; }
    }
}
