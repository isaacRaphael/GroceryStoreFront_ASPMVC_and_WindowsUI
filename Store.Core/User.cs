using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Core
{   public interface IUser
    {
         Role UserRole { get; set; }
    }

    public class User : IUser
    {

        public User(string x)
        {
            switch (x.ToLower())
            {
                case "m":
                    UserRole = Role.Manager;
                    break;
                case "f":
                    UserRole = Role.Staff;
                    break;
                default :
                    break;
            }
        }
        public Role UserRole { get; set; }

    }
}
