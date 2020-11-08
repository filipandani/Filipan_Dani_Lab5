using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filipan_Dani_lab5.Models
{
    public class ExpenseContext : DbContext

    {
        public ExpenseContext(DbContextOptions<ExpenseContext> options) : base(options)
        {}
        public DbSet<Expense> ExpenseDTO { get; set; }
    }
}
