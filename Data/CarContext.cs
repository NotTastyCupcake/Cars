using Cars.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Data
{
    public class CarContext : DbContext 
    {
        public CarContext(DbContextOptions<CarContext> options) : base(options)
        { }
        public CarContext() { }
        public DbSet<CarModel> Cars { get; set; }
    }
}
