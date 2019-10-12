using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThePowerRanges.Models
{

    public class ExpenseCollection
    {

        public int Id { get; set; }
        private Dictionary<string, int> Expenses {get; set;}
        public List<string> Keys { get; set; }
        public List<int> Amounts { get; set; }
        public ExpenseCollection()
        {
            Expenses = new Dictionary<string, int>();
            Keys = new List<string>();
            Amounts = new List<int>();
        }

        public void AddExpense(string expenseName, int amount)
        {

            Expenses.Add(expenseName, amount);

        }

        public void RemoveExpense(string expenseName, double amount)
        {

            Expenses.Remove(expenseName);

        }

        public void Extract()
        {
            
            foreach(var pair in Expenses)
            {
                Keys.Add(pair.Key);
                Amounts.Add(pair.Value);
            }
        }

        public List<string> getKeys()
        {
            return Keys;
        }

        public List<int> getAmounts()
        {
            return Amounts;
        }

        // edit expense code here
        public void EditExpense()
        {

            //

        }
    }
}
