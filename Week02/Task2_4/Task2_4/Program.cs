class Program
{
    static void Main()
    {
        Shape circle = new Circle(5);
        Shape rectangle = new Rectangle(10, 6);

        circle.DisplayArea();
        rectangle.DisplayArea();

        // Shape shape = new Shape(); // Compile-time error
    }
}