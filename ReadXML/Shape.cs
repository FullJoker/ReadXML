
namespace ReadXML
{
    abstract class Shape
    {
        protected int Id { get; set; }  
        protected string Name { get; set; }
        protected string Color { get; set; }

        protected Shape(int id, string name, string color)
        {
            Id = id;
            Name = name;
            Color = color;
        }
        public abstract double CalculateSquare();
        public override string ToString()
        {
            return Id + ")" + Name + ":" + Color + " = " + string.Format("{0:F2}", CalculateSquare()); 
        }
    }
}
