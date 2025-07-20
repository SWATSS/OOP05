using Csharp_Advanced.Classes;
using Csharp_Advanced.Interface;

namespace Csharp_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 01: Define an interface named IShape with a property Area and a method DisplayShapeInfo. Create two interfaces, ICircle and IRectangle, that inherit from IShape. Implement these interfaces in classes Circle and Rectangle. Test your implementation by creating instances of both classes and displaying their shape information.
            //Circle circle = new Circle(10);
            //circle.DisplayShapeInfo();
            //Console.WriteLine("#################################");
            //Rectangle rectangle = new Rectangle(10,20);
            //rectangle.DisplayShapeInfo();
            #endregion

            #region Question 02:
            IAuthenticationService authService = new BasicAuthenticationService("Ibrahim", "Ibra50##", Csharp_Advanced.Enums.Role.Admin);
            Console.Write("Please Enter UserName: ");
            string UserName = Console.ReadLine();
            Console.Write("Please Enter Password: ");
            string Password = Console.ReadLine();

            if (authService.AuthenticateUser(UserName, Password))
            {
                Console.Clear();
                Console.WriteLine("Authentication Successful");

                Console.Write("Please Enter Role (Admin, Manager, User): ");
                string role = Console.ReadLine();

                if (Enum.TryParse(role, out Csharp_Advanced.Enums.Role Role))
                {
                    if (authService.AuthorizeUser(UserName, Role))
                    {
                        Console.WriteLine("Authorization Successful");
                    }else Console.WriteLine("Authorization Failed");
                }else Console.WriteLine("Invalid Role Enterd ");
            }else Console.WriteLine("Authentication Failed");
            #endregion



        }
    }
}
