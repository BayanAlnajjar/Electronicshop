using System;
using System.Collections.Generic;
using System.Text;

namespace DATA.Classes
{
    public class Admin :User
    { public override string GetRole()
        {
         return " Hi , I am admin";
        }
        public override string ToString()
        {
            return "ADMIN";
        }
    }
}
