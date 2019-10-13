using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThePowerRanges.Models
{

    public class ExpenseCollection
    {


        public int Id { get; set; }
     
        private  Keys Keys_ { get; set; }
        private   Amounts Amounts_ { get; set; }
        public ExpenseCollection()
        {

            Keys_ = new Keys();
            Amounts_ = new Amounts();

        }

        public void AddExpense(string expenseName, int amount)
        {

            Keys_.putKey(expenseName);
            Amounts_.putAmount(amount);

        }

        public void RemoveExpense(string expenseName, int amount)
        {

            Keys_.removeKey(expenseName);

        }

        public string getKey(int index)
        {
            return Keys_.getKey(index);
        }

        public int  getAmount(int index)
        {
            return Amounts_.getAmount(index);
        }

        public int getSize()
        {
            return Keys_.getSize();
        }

        // edit expense code here
        public void EditExpense()
        {

            //

        }
    }
}
