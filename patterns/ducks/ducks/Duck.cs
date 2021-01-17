namespace ducks.ducks
{
    public class Duck
    {
        public Duck(string name)
        {
            this.Name = name;
        }

        public string Display()
        {
            return $"I am {this.Name}";
        }

        public string Name { get; set; }
    }
}