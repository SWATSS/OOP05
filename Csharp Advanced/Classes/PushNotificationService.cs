using Csharp_Advanced.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Advanced.Classes
{
    internal class PushNotificationService : INotificationService
    {
        #region Question 03:
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine(message);
            Console.WriteLine("-------------------------------------------");
        } 
        #endregion
    }
}
