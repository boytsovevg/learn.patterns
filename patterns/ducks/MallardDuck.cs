namespace ducks
{
    public class MallardDuck: Duck
    {
        public override void Quack()
        {
            throw new System.NotImplementedException();
        }

        public override void Swim()
        {
            throw new System.NotImplementedException();
        }

        public override string Display()
        {
            return $"I am Mallard Duck";
        }
    }
}