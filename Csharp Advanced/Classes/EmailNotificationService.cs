using Csharp_Advanced.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Advanced.Classes
{
    internal class EmailNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            #region Question 03:
            Console.WriteLine($"Hello {recipient} You Received an Email:");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine(message);
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();
            Console.WriteLine(); 
            #endregion
        }
    }
}
