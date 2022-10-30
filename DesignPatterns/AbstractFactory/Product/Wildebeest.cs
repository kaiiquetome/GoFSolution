using AbstractFactory.AbstractProduct;

namespace AbstractFactory.Product
{
    class Wildebeest : Herbivore
    {
        public override void Eat(Carnivore h)
        {
            throw new System.NotImplementedException();
        }
    }
}
