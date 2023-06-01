
namespace Restaraunt_2.Core
{
    public class Cook
    {
        public Order SubmitRequest(MenuItem menuItem, int quantity) 
        {
            Order order = null;
            if (menuItem == MenuItem.Chicken) 
                order = new ChickenOrder(quantity);

            else if (menuItem == MenuItem.Egg) 
                order = new EggOrder(quantity);

            else 
                throw new ArgumentException("Wrong order type!");

            return order;
        }

        public void PrepareFood(Order order) => order.Cook();
 
        public string Inspect(EggOrder egg) => egg.GetQuality().ToString();
    }

    public class MyCook //By Dilshod aka
    {

        public Order SubmitRequest(MenuItem menuItem, int quantity) 
        {
            Order createdOrder = null;
            if (menuItem == MenuItem.Chicken)
                createdOrder = new ChickenOrder(quantity);

            else if (menuItem == MenuItem.Egg)
                createdOrder = new EggOrder(quantity);

            else
                throw new ArgumentException("Wrong order type!");

            return createdOrder;
        }

        public void PrepareFood(Order myOrder)
        {
            if (myOrder is ChickenOrder chicken)
            {
                chicken.Cook();
            }
            else if (myOrder is EggOrder egg)
            {
                egg.Cook();
            }
        }

        public string Inspect(EggOrder egg) => (egg.GetQuantity() != 0) ? egg.GetQuality().ToString() : string.Empty;
    }
}
