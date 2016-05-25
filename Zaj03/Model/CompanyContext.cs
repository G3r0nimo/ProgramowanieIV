using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaj03.Model
{
    public class CompanyContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }

        public CompanyContext()
        {
            Database
                .SetInitializer(new DropCreateDatabaseIfModelChanges<CompanyContext>());
        }
    }
}
