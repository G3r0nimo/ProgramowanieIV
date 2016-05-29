using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaj05
{
    public class MainWindowViewModel
    {
        public User DefaultUser { get; set; }
        public List<User> AllUsers { get; set; }
        public MainWindowViewModel()
        {
            AllUsers = new List<User>
            {
                new User {Login="Log1",Email="E1@ath.com" },
                new User {Login="Log2",Email="E2@ath.com" },
                new User {Login="Log3",Email="E3@ath.com" },

            };
            DefaultUser = AllUsers.FirstOrDefault();
        }
    }
}
