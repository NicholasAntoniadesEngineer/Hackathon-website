using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ThePowerRanges.Models
{
    public class Budget
    {

        [Key]
        public int Id {get; set;}

        public ExpenseCollection Expenses { get; set; }
        public int ExpensesTotal { get; set; }
        public int Debt { get; set; }
        public  int Income { get; set; }
        public int  Save { get; set; }
        public int TaxPercentage { get; set; }
        public int Month { get; set; }

        public Budget() { }

    }
}
