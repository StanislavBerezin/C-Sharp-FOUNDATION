using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class ShoppingCartModel
    {
        //Delegate that will receive the functionality of SubTotalAlert from ConsoleUI - Program.cs
        //Receives a method which can have another name, but under this class it will be declared as MentionDiscount
        public delegate void MentionDiscount(decimal subTotal);

        public List<ProductModel> Items { get; set; } = new List<ProductModel>();

        //1)When we call GenerateTotal, we pass a method to it, which then we execute (Using Delegate)
        //2)Func, we dont declare a delegate, first we pass the list of ProductModel 
        //then we pass "decimal" which is subTotal, and another 'decimal' is for output
       //last parameter is always the output, and then giving a name
       //3) Action, is similar to delage but without declaring, we just need to put the type of Action
       //and then call it
        public decimal GenerateTotal(MentionDiscount mentionSubtotal,
            Func<List<ProductModel>,decimal,decimal> calculateDiscountedTotal,
            Action<string> tellUserWeAreDiscounting)
        {
            decimal subTotal = Items.Sum(x => x.Price);

            //here we put the params
            mentionSubtotal(subTotal);

            //Calling the method and inserting our message
            tellUserWeAreDiscounting("We are applying your discount.");

            //considering the fact we know it will return an output we can store it in decimals
            //and then when we call it, we pass the List and subtotal
            decimal total = calculateDiscountedTotal(Items, subTotal);

            return total;
        }
    }
}
