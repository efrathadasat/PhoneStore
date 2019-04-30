using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneStore.Models
{
    public class Memory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Size { get; set; }
        public ICollection<Phone> Phones { get; set; }
    }
}
