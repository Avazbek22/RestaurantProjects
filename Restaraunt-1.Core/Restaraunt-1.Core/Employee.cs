
namespace Restaraunt_1.Core
{
    public class Employee
    {
        private object _food;
        private int _counter = 0; // Количество вызовов метода "NewRequest"

        /// <summary>
        /// Осуществляет новый заказ
        /// </summary>
        /// <param name="quantity"></param>
        /// <param name="menuItem"></param>
        /// <returns></returns>
        public object NewRequest(int quantity, string menuItem) 
        {
            _counter++;
            if (_counter % 3 == 0) // Каждые 3 раза перепутываем сделанный заказ
                menuItem = (menuItem == "Chicken") ? "Egg" : "Chicken";

            _food = (menuItem == "Chicken") ? new ChickenOrder(quantity) : new EggOrder(quantity); 

            return _food;
        }

        /// <summary>
        /// Возвращает результат сделанного заказа
        /// </summary>
        /// <param name="food"></param>
        /// <returns></returns>
        public string? Inspect(object food)
        {
            if (food is ChickenOrder) return "Проверка не требуется";

            if (food is EggOrder egg) return egg.GetQuality().ToString();

            return "";
        }

        /// <summary>
        /// Копирует предыдущий заказ
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public object CopyRequest()
        {
            if (_food == null)
                throw new Exception("Сначала сделайте заказ!");

            if (_food is ChickenOrder chicken)
                return new ChickenOrder(chicken.GetQuantity());

            if (_food is EggOrder egg)
                return new EggOrder(egg.GetQuantity(), egg.GetQuality()); // Вызввается 2-ой конструктор EggOrder

            return null;
        }

        /// <summary>
        /// Готовит сделанный заказ и возвращает результат
        /// </summary>
        /// <param name="food"></param>
        /// <returns></returns>
        public string PrepareFood(object food)
        {
                if (_food == null) // Проверка на наличие заказа (был ли вызван метод "NewRequest")
                    throw new Exception("Сначала сделайте заказ!");

                string result = "";
                
                if (food is ChickenOrder chicken)
                {
                    for (int i = 0; i < chicken.GetQuantity(); i++) // Режем все курицы
                        chicken.CutUp();

                    chicken.Cook();
                    result = $"{chicken.GetQuantity()} Куриц приготовлено!";
                }
                else if (food is EggOrder egg)
                {
                    for (int i = 0; i < egg.GetQuantity(); i++) { //Разбиваем и очищаем скорлупу всех яиц
                        egg.Crack();
                        egg.DiscardShell();
                    }
                    egg.Cook();
                    result = $"{egg.GetQuantity()} Яиц приготовлено!";
                }
                _food = null; // Еда уже приготовлена. Удаляем значение переменной,
                              // чтобы пользователь не смог приготовить еду 2 раза подряд (так-как она уже приготовлена!)
                return result;
            }
        }
    }
