using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaj03.Model
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TeamMember> TeamMembers { get; set; }
    }
}
