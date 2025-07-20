using Csharp_Advanced.Classes;

namespace Csharp_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 01: Define an interface named IShape with a property Area and a method DisplayShapeInfo. Create two interfaces, ICircle and IRectangle, that inherit from IShape. Implement these interfaces in classes Circle and Rectangle. Test your implementation by creating instances of both classes and displaying their shape information.
            Circle circle = new Circle(10);
            circle.DisplayShapeInfo();
            Console.WriteLine("#################################");
            Rectangle rectangle = new Rectangle(10,20);
            rectangle.DisplayShapeInfo();
            #endregion
        }
    }
}
