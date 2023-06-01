
namespace Restaraunt_2
{
    public class Order
    {
        protected int _quantity;
        public Order(int quantity)
        {
            if (quantity < 0)
                throw new InvalidOperationException("Order quantity can't be less than 1");

            _quantity = quantity;
        }

        public int GetQuantity() => _quantity;

        public void SubtactQuantity(int amount) => _quantity -= amount;

        public virtual void Cook() { }
    }
}
