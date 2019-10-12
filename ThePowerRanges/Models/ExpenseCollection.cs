using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThePowerRanges.Models
{

    public class ExpenseCollection
    {

        public int Id { get; set; }
        private Dictionary<string, double> Expenses {get; set;}
        public ExpenseCollection()
        {
            Expenses = new Dictionary<string, double>();
        }

        public void AddExpense(string expenseName, double amount)
        {

            Expenses.Add(expenseName, amount);

        }

        public void RemoveExpense(string expenseName, double amount)
        {

            Expenses.Remove(expenseName);

        }

        // edit expense code here
        public void EditExpense()
        {

            //

        }
    }
}
