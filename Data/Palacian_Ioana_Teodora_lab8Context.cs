using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Palacian_Ioana_Teodora_lab8.Models;

namespace Palacian_Ioana_Teodora_lab8.Data
{
    public class Palacian_Ioana_Teodora_lab8Context : DbContext
    {
        public Palacian_Ioana_Teodora_lab8Context (DbContextOptions<Palacian_Ioana_Teodora_lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Palacian_Ioana_Teodora_lab8.Models.Book> Book { get; set; }

        public DbSet<Palacian_Ioana_Teodora_lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Palacian_Ioana_Teodora_lab8.Models.Category> Category { get; set; }
    }
}
