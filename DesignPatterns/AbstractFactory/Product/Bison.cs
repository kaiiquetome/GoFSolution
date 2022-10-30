using AbstractFactory.AbstractProduct;

namespace AbstractFactory.Product
{
    class Bison : Herbivore
    {
        public override void Eat(Carnivore h)
        {
            throw new System.NotImplementedException();
        }
    }
}
