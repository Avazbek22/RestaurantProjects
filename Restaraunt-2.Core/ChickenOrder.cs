
namespace Restaraunt_2.Core
{
    public class ChickenOrder : Order
    {
        public ChickenOrder(int quantity) : base(quantity) { } 

        public void CutUp() { }

        public override void Cook() 
        {
            for (int i = 1; i <= _quantity; i++)
                CutUp();
        }
    }
}
