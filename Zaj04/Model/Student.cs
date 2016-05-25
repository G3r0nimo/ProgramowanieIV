using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaj04.Model
{
    [Table("Students")]
    public class Student : Person
    {
        public string CardNumber { get; set; }
        //..
    }
}
