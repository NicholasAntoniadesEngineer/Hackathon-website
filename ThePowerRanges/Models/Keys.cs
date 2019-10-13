using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThePowerRanges.Models
{
    public class Keys
    {
        [Key]
        public int Id { get; set; }
        private List<string> keys { get; set; }
        public Keys()
        {
            keys = new List<string>();
        }

        public string getKey(int keyIndex)
        {
            return keys.ElementAt(keyIndex);

        }
        public void putKey(string key)
        {
            keys.Add(key);
        }

        public void removeKey(string key )
        {
            keys.Remove(key);
        }

        public int getSize()
        {
            return keys.Count;
        }

    }
}
