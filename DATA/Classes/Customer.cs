using System;
using System.Collections.Generic;
using System.Text;

namespace DATA.Classes
{
    public class Customer :User 
    {
        public int Id { get; set; }
        public string Name  { get; set; }
        List<Product> PurchasedProducts { get; set; }
        public override string GetRole()
        {
            return $" my id is :{Id} $ my Name is :{Name}";
        }
        public override string ToString()
        {
            return $" the costomer Data: Name : {Name} , id :{Id}, List of products: {PurchasedProducts}";




        }


    }
}
