using System;
using System.Collections.Generic;
using System.Text;

namespace DATA.Classes
{
    public abstract class User
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public abstract string GetRole();
        public override string ToString()
        {
            return $" UserName: {Name}, UserID:{Id}";
        }
    }
}
