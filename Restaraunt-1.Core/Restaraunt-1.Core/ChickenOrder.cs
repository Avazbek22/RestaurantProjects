
namespace Restaraunt_1.Core
{
    public class ChickenOrder
    {
        private int _quantity; // Заказанное количество
        public ChickenOrder(int quantity) => _quantity = quantity;

        /// <summary>
        /// Возвращает количество
        /// </summary>
        /// <returns></returns>
        public int GetQuantity() => _quantity;

        /// <summary>
        /// Режет курицу
        /// </summary>
        public void CutUp() { }

        /// <summary>
        /// Готовит курицу
        /// </summary>
        public void Cook() { }
    }
}
