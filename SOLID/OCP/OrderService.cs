using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{

    /*
     *  Her müşterinin; standard (0.05) , silver (0.1) veya gold (0.15) türünde sadakat kartı olsun. Bu kartlara göre indirim yapılsın.
     */

    //public enum CardType
    //{
    //    Standard,
    //    Silver,
    //    Gold,
    //    Premium
    //} 

    public abstract class CardType
    {
        public abstract decimal GetDiscountedPrice(decimal price);
        
    }

    public class Standard : CardType
    {
        public override decimal GetDiscountedPrice(decimal price)
        {
           return price * .95m;
        }
    }

    public class Silver : CardType
    {
        public override decimal GetDiscountedPrice(decimal price)
        {
            return price * .9m;
        }
    }

    public class Gold : CardType
    {
        public override decimal GetDiscountedPrice(decimal price)
        {
            return price * .85m;
        }
    }

    public class Premium : CardType
    {
        public override decimal GetDiscountedPrice(decimal price)
        {
            return price * .8m;
        }
    }
    public class Customer
    {
        public string Name { get; set; }
        public CardType Card { get; set; }
    }
    public class OrderService
    {
        public Customer Customer { get; set; }

        public decimal GetTotalPrice(decimal price)
        {
            //switch (Customer.Card)
            //{
            //    case CardType.Standard:
            //        return price * .95m;
            //    case CardType.Silver:
            //        return price * .90m;

            //    case CardType.Gold:
            //        return price * .85m;
            //    case CardType.Premium:
            //        return price * .8m;

            //    default:
            //        return price;
            //}

            return Customer.Card.GetDiscountedPrice(price);
        }
    }
}
