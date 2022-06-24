using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practica3.DAL
{
    public class AppDbContext:DbContext
    {
       public AppDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
