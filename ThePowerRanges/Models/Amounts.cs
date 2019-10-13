using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThePowerRanges.Models
{
    public class Amounts
    {
        [Key]
        public int Id { get; set; }
        private List<int> amounts { get; set; }

        public Amounts()
        {
            amounts = new List<int>();
        }

        public int getAmount(int index)
        {
            return amounts.ElementAt(index);

        }
        public void putAmount(int amount)
        {
            amounts.Add(amount);
        }

        public void removeAmount(int amount )
        {
            amounts.Remove(amount);
        }
    }
}
