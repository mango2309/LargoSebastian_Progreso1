using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LargoSebastian_Progreso1.Models;

namespace LargoSebastian_Progreso1.Data
{
    public class LargoSebastian_Progreso1Context : DbContext
    {
        public LargoSebastian_Progreso1Context (DbContextOptions<LargoSebastian_Progreso1Context> options)
            : base(options)
        {
        }

        public DbSet<LargoSebastian_Progreso1.Models.LargoS> LargoS { get; set; } = default!;
        public DbSet<LargoSebastian_Progreso1.Models.Celular> Celular { get; set; } = default!;
    }
}
