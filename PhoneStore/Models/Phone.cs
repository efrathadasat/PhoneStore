using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace PhoneStore.Models
{
    public class Phone
    {
        [DisplayName("KatalogNumber")]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quntity { get; set; }
        public double Version { get; set; }
        public Memory Memory { get; set; }
    }
}
