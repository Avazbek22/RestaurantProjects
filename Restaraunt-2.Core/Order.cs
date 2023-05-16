
namespace Restaraunt_2
{
    public class Order
    {
        protected int _quantity; 
        public Order(int quantity) => _quantity = quantity; //

        public int GetQuantity() => _quantity;

        public void SubtactQuantity(int amount) => _quantity -= amount;

        public virtual void Cook() { }
    }
}
