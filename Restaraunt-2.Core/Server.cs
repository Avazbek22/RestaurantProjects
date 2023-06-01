
namespace Restaraunt_2.Core
{
    public class Server
    {
        private MenuItem[][] orders = new MenuItem[0][];
        private OrderStatus? _orderStatus = null;
        int _totalEggs = 0;
        int _totalChickens = 0;
        private MyCook _cook = new MyCook();
        ChickenOrder chickenOrder = null;
        EggOrder eggOrder = null;


        public void Receive(int amountChicken, int amountEgg, MenuItem drink)
        {
            if (orders.Length > 7)
                throw new Exception("You can make only 8 orders for 1 table!");

            if (_orderStatus == OrderStatus.SentToCook)
                throw new Exception("The order is ready, it remains to serve!");

            _totalChickens += amountChicken;
            _totalEggs += amountEgg;

            Array.Resize(ref orders, orders.Length + 1);
            orders[orders.Length - 1] = FillOrders(amountChicken, amountEgg, drink);

            _orderStatus = OrderStatus.Received;
        }

        public string Send()
        {
            if (_orderStatus == OrderStatus.SentToCook)
                throw new Exception("Already sent for cooking!");

            if (_orderStatus != OrderStatus.Received)
                throw new Exception("First make an order!");

            chickenOrder = (_cook.SubmitRequest(MenuItem.Chicken, _totalChickens) as ChickenOrder)!;
            _cook.PrepareFood(chickenOrder);

            eggOrder = (_cook.SubmitRequest(MenuItem.Egg, _totalEggs) as EggOrder)!;
            _cook.PrepareFood(eggOrder);

            _totalChickens = 0;
            _totalEggs = 0;
            _orderStatus = OrderStatus.SentToCook;
            return _cook.Inspect(eggOrder);
        }

        public string[] Serve()
        {
            //This method should be called only once 
            switch (_orderStatus)
            {
                case null: throw new Exception("First make an order!");
                case OrderStatus.Received: throw new Exception("First send an order to the cook!");
                case OrderStatus.Served: throw new Exception("Already served!");
            }

            int chickenCount = 0, eggCount = 0, i = 0;
            string[] preparedOrdersResult = new string[orders.Length];
            while (chickenOrder.GetQuantity() != 0 && eggOrder.GetQuantity() != 0)
            {
                for (int j = 0; j < orders[i].Length; j++)
                {
                    if (orders[i][j] is MenuItem.Chicken) chickenCount++;
                    else if (orders[i][j] is MenuItem.Egg) eggCount++;
                }

                eggOrder.SubtactQuantity(eggCount);
                chickenOrder.SubtactQuantity(chickenCount);
                preparedOrdersResult[i] = $"Customer {i} is served {chickenCount} chicken, {eggCount} egg, {orders[i][orders[i++].Length - 1]}.";
                chickenCount = 0;
                eggCount = 0;

            }

            orders = new MenuItem[0][];
            _orderStatus = OrderStatus.Served;
            return preparedOrdersResult;
        }
        private enum OrderStatus
        {
            Received,
            SentToCook,
            Served,
        }

        private MenuItem[] FillOrders(int amountChicken, int amountEgg, MenuItem Drink)
        {
            MenuItem[] customerOrder = new MenuItem[amountChicken + amountEgg + 1];

            for (int i = 0; i < amountChicken; i++)
                customerOrder[i] = MenuItem.Chicken;

            for (int i = amountChicken; i < customerOrder.Length; i++)
                customerOrder[i] = MenuItem.Egg;

            customerOrder[customerOrder.Length - 1] = Drink;

            return customerOrder;
        }
    }
}
