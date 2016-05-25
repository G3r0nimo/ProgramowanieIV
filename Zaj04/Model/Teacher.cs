using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaj04.Model
{
    public enum eDegree
    {
        Professor,
        PhD,
        Msc,
        //..
    }

    [Table("Teachers")]
    public class Teacher : Person
    {
        public eDegree Degree { get; set; }
    }
}
