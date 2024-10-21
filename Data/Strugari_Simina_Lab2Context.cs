using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Strugari_Simina_Lab2.Models;

namespace Strugari_Simina_Lab2.Data
{
    public class Strugari_Simina_Lab2Context : DbContext
    {
        public Strugari_Simina_Lab2Context (DbContextOptions<Strugari_Simina_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Strugari_Simina_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Strugari_Simina_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Strugari_Simina_Lab2.Models.Authors> Authors { get; set; } = default!;
    }
}
