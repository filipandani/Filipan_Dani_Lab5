using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Filipan_Dani_lab5.Models;

namespace Filipan_Dani_lab5.Models
{
    public class ExpenseContext : DbContext

    {
        internal readonly object ExpenseDTO;

        public ExpenseContext(DbContextOptions<ExpenseContext> options) 
            : base(options)
        {
        }
        public DbSet<ExpenseDTO> Expense { get; set; }
        public DbSet<Budget> Budget { get; set; }
    }
}
