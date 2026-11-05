using System;
using System.Collections.Generic;
using System.Text;

namespace DATA.Classes
{
    public interface IPurchasable
    {
        public bool Buy(int quantituy);
        public bool Restock(int quantity); 
    }
}
