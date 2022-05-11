namespace OOP1
{
    public abstract class Figure
    {
        public string Name { get; }


        public Figure(string name)
        {
            Name = name;
        }


        public abstract override string ToString();
    }
}
