using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmamCoderWebApi.Model
{
    public class ProductDbContext: DbContext
    {
        public ProductDbContext(DbContextOptions option) : base(option)
        {
        }

       public DbSet<Product> Products { get; set; }
    }
}
