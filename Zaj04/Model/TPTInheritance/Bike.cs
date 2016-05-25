using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.TestConsole.Models.TPTInheritance
{
    public enum eBikeType
    {
        eMoountainBike,
        eStandardBike,
        eBmx
    }

    [Table("Bikes")]
    public class Bike : Product
    {
        public eBikeType Type { get; set; }
    }
}
