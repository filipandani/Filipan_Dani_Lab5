using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filipan_Dani_lab5.Models
{
    public class ExpenseDTO
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
    }
}
