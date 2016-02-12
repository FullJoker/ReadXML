
namespace ReadXML
{
    abstract class Shape
    {
        protected int Id { get; set; }  //TODO: RENAME to _id
        protected string Name { get; set; } //TODO: RENAME to _name
        protected string Color { get; set; }//TODO: RENAME to _color

        protected Shape(int id, string name, string color) //PROTECTED CONSTRUCTOR? WTF?
        {
            Id = id;
            Name = name;
            Color = color;
        }
        public abstract double CalculateSquare();//TODO: rename to Square();
        public override string ToString()
        {
            return Id + ")" + Name + ":" + Color + " = " + string.Format("{0:F2}", CalculateSquare()); 
        }
    }
}
