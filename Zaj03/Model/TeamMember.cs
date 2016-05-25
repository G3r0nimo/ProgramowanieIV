using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaj03.Model
{
    public enum eMemberType
    {
        TeamLeader,
        Programmer,
        Tester,
        ScrumMaster,
        ProjectOwner
    }

    public class TeamMember
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public eMemberType MemberType { get; set; }

        public virtual ICollection<Project> Projects { get; set; }

        public virtual Team Team { get; set; }
    }
}
