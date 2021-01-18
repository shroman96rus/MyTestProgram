using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyTestProgram.Pages.Model;

namespace MyTestProgram.Data
{
    public class MyTestProgramContext : DbContext
    {
        public MyTestProgramContext (DbContextOptions<MyTestProgramContext> options)
            : base(options)
        {
        }

        public DbSet<MyTestProgram.Pages.Model.Transaction> Transaction { get; set; }
    }
}
