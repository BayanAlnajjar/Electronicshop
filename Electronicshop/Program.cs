using DATA.Classes;

namespace Electronicshop
{
    public class Program
    {
        static void Main(string[] args)
        {
            var Pro = ProData.GetProducts();
            int c = 0;
            while (c != 4 && c < 5)
            {
                Console.WriteLine("The Shop Menu:");
                Console.WriteLine("1. Display all the products");
                Console.WriteLine("2. Buying Product");
                Console.WriteLine("3.Restock quantity");
                Console.WriteLine("4.Exit\n\n\n");
                Console.WriteLine("Enter the number");
                c = int.Parse(Console.ReadLine());
                switch (c)
                {
                    case 1:
                        foreach (var pro in Pro)
                        {
                            Console.WriteLine(pro.ToString());

                        }
                        break;
                    case 2:
                        Console.WriteLine("Insert id of product");
                        int ProId = int.Parse(Console.ReadLine());
                        Product BuyPro = null;
                        foreach (var pro in Pro)
                        {
                            if (pro.Id == ProId)
                            {
                                BuyPro = pro;
                                break;
                            }
                        }
                        if (BuyPro == null)
                        { Console.WriteLine("product is not found"); }
                        else
                        {
                            Console.WriteLine("Enter quantity");
                            int quantity = int.Parse(Console.ReadLine());
                            if (BuyPro.Buy(quantity))
                            { Console.WriteLine("true purchased"); }
                            else { Console.WriteLine("quantity not allowed"); }

                        }
                        break;
                    case 3:
                        Console.WriteLine("Insert id of Product");
                        int ProductId = int.Parse(Console.ReadLine());
                        Product RestockPro = null; ;
                        foreach (var pro in Pro)
                        {
                            if (pro.Id == ProductId)
                            {
                                RestockPro=pro;
                                break;
                            }
                        }
                        if (RestockPro == null)
                        {
                            Console.WriteLine("Product ID is not found");
                        }
                        else
                        {
                            Console.WriteLine("Enter quantity");
                            int quantity = int.Parse(Console.ReadLine());
                            if (RestockPro.Restock(quantity))
                            { Console.WriteLine("Correct Addition Process"); }
                        }
                        break;
                    case 4:
                        Console.WriteLine("Bye Bye");
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;
                }  
            }
        }
    }
}
