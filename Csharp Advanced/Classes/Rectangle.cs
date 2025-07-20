using Csharp_Advanced.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Advanced.Classes
{
    internal class Rectangle : IRectangle
    {
        #region Question 01: Define an interface named IShape with a property Area and a method DisplayShapeInfo. Create two interfaces, ICircle and IRectangle, that inherit from IShape. Implement these interfaces in classes Circle and Rectangle. Test your implementation by creating instances of both classes and displaying their shape information.
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Area
        {
            get { return Width * Height; }
        }

        public void DisplayShapeInfo()
        {
            {
                Console.WriteLine("Shape: Rectangle");
                Console.WriteLine($"Width: {Width}, Height: {Height}");
                Console.WriteLine($"Area: {Area:F2}");
            }
        } 
        #endregion
    }
}
