
namespace Restaraunt_2.Core
{
    public class EggOrder : Order
    {
        private int _quality;
        private Random _rnd = new Random(DateTime.Now.Millisecond);

        public EggOrder(int quantity) : base(quantity) => _quality = _rnd.Next(1, 101); //

        public int GetQuality() => _quality;

        public void Crack() { }

        public void Discard() { }

        public override void Cook() 
        {
            for (int i = 1; i <= _quantity; i++) {
                Crack();
                Discard();
            }
        }
    }
}
