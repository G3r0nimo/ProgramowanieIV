using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zaj04.Model;

namespace Zaj04
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new SchoolContext())
            {
                //db.Database.Log = Console.WriteLine;

                //var q = from n in db.People//.OfType<Student>()
                //        select n;

                //foreach (var item in q)
                //{
                //    Console.WriteLine("{0}, {1}", 
                //        item.FirstName,
                //        item is Student ? (item as Student).CardNumber 
                //        : (item as Teacher).Degree.ToString());
                //}

                //db.Schools.Add(new School
                //{
                //    Name = "ATH",
                //    People = new List<Person>
                //    {
                //        new Teacher{FirstName = "Józek", Degree = eDegree.Professor},
                //        new Teacher{FirstName = "Malgosia", Degree = eDegree.Msc},
                //        new Student{FirstName="Jan", CardNumber="S01"},
                //        new Student{FirstName="Zosia", CardNumber="S02"},
                //        new Student{FirstName="Agnieszka", CardNumber="S03"},
                //    }
                //});

                //db.SaveChanges();
            }
        }
    }
}
