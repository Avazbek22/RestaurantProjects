
namespace Restaraunt_1.Core
{
    public class EggOrder
    {
        private int _quantity; // Заказанное количество
        private int? _quality; // Качество яйца
        private static int callCount = 0; // Количество вызова метода "GetQuality"
        private Random _rnd = new Random(DateTime.Now.Millisecond);

        /// <summary>
        /// Основной конструктор
        /// </summary>
        /// <param name="quantity"></param>
        public EggOrder(int quantity)
        {
            _quantity = quantity;
            _quality = _rnd.Next(1, 101);
        }

        /// <summary>
        /// Конструктор для копирования предыдущего объекта
        /// </summary>
        /// <param name="quantity"></param>
        /// <param name="quality"></param>
        public EggOrder(int quantity, int? quality)
            => (_quantity, _quality) = (quantity, quality);

        /// <summary>
        /// Разбивает яйцо для приготовления (проверка качества яйца, если оно ниже 25, то выбрасывается исключение)
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void Crack() {
            if (_quality < 25)
                throw new Exception("Яйцо было испорчено");
        }

        /// <summary>
        /// Возвращает качество яйца (в 1/2 случаев возвращается null)
        /// </summary>
        /// <returns></returns>
        public int? GetQuality() => (++callCount % 2 == 0) ? null : _quality;

        /// <summary>
        /// Возвращает количество
        /// </summary>
        /// <returns></returns>
        public int GetQuantity() => _quantity;  

        /// <summary>
        /// Очищеняет скорлупу яйца
        /// </summary>
        public void DiscardShell() { }

        /// <summary>
        /// Готовит яйцо
        /// </summary>
        public void Cook() { }
    }
}