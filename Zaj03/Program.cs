using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using Zaj03.Model;

namespace Zaj03
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.SetData("DataDirectory",
                AppDomain.CurrentDomain.BaseDirectory);

            using (var db = new CompanyContext())
            {
                db.Database.Log = n => Console.WriteLine(n);

                db.Configuration.LazyLoadingEnabled = false;

                Console.WriteLine("------------------------");
                Console.WriteLine(from n in db.TeamMembers.Include(n => n.Team)
                                  select n);

                var q = (from n in db.TeamMembers.Include(n => n.Team)
                        select n).ToList();
                foreach (var member in q)
                {
                    Console.WriteLine("Member name: {0}, team: {1}", 
                        member.FirstName, member.Team.Name);
                }
                
                
                //string firstName = db.TeamMembers.First().FirstName;
                //Console.WriteLine(firstName);
                


                //db.Teams.Add(new Team
                //{
                //    Name = "ATH",
                //    TeamMembers = new List<TeamMember>
                //    {
                //        new TeamMember{FirstName = "Jan", MemberType = eMemberType.Programmer},
                //        new TeamMember{FirstName = "Malgosia", MemberType = eMemberType.Tester}
                //    }
                //});
                //db.Teams.Add(new Team
                //{
                //    Name = "Eksperci",
                //    TeamMembers = new List<TeamMember>
                //    {
                //        new TeamMember{FirstName = "Zbyszek", MemberType = eMemberType.Programmer},
                //        new TeamMember{FirstName = "Dominika", MemberType = eMemberType.Tester}
                //    }
                //});
                //db.SaveChanges();
            }
        }
    }
}
