using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace LearningASPNetCore.Models
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Character> Characters{ get; set; }
    }
}
