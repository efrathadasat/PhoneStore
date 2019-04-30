using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PhoneStore.Models
{
    public class PhoneStoreContext : DbContext
    {
        public PhoneStoreContext (DbContextOptions<PhoneStoreContext> options)
            : base(options)
        {
        }

        public DbSet<PhoneStore.Models.Phone> Phone { get; set; }
    }
}
