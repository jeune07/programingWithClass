class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("blue", 2);
        double area = square.GetArea();
        // Console.WriteLine("Area of the square: " + area);

        // Square square2 = new Square("Red", 3);
        // Console.WriteLine("The area of the square 2 is: " + square2.GetArea());
        // Console.WriteLine("The color of the square2 is: " + square2.GetColor());

        Rectangle rectangle = new Rectangle(10,10,"red");
        double areaRectangle = rectangle.GetArea();
        // Console.WriteLine("The area of the retangle is:  "+ areaRectangle);

        Circle circle = new Circle(10, "red");


        List<Shape> _listShape = new List<Shape>();

        _listShape.Add(square);
        _listShape.Add(rectangle);
        _listShape.Add(circle);

        Console.WriteLine(_listShape);

    }
}
