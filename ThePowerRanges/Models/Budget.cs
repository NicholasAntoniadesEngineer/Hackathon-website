using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThePowerRanges.Models
{
    public class Budget
    {

        [Key]
        public int Id {get; set;}
        public ExpenseCollection Expenses { get; set; }
        public double ExpensesTotal { get; set; }
        public double Debt { get; set; }
        public double Income { get; set; }
        public double Save { get; set; }
        public double TaxPercentage { get; set; }
        public DateTime Month { get; set; }

    }
}
