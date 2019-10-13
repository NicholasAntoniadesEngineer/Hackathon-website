using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThePowerRanges.Models
{
    public class BudgetBindingModel
    {

        public List<int> Amounts { get; set; }
        public List<string> Expenses { get; set; }
        public int Total { get; set; }
        public int Debt { get; set;}
        public int Income { get; set; }
        public int Tax { get; set; }
        public int Save { get; set; }
        public int Month { get; set; } /**convert to date(month) in controller method**/

        public BudgetBindingModel()
        {

            Amounts = new List<int>();
            Expenses = new List<string>();

        }

    }
}
