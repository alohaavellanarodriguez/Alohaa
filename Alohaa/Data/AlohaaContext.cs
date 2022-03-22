#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Alohaa.models;

namespace Alohaa.Data
{
    public class AlohaaContext : DbContext
    {
        public AlohaaContext (DbContextOptions<AlohaaContext> options)
            : base(options)
        {
        }

        public DbSet<Alohaa.models.pogi> pogi { get; set; }
    }
}
