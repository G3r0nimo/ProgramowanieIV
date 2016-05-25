using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.TestConsole.Models.TPTInheritance
{
    public class Shop
    {
        public int Id { get; set; }
        public virtual ICollection<Product> Products { get; set; }

        public Shop()
        {
            Products = new HashSet<Product>();
        }
    }
}
