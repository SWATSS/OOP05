using Csharp_Advanced.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Advanced.Classes
{
    internal class SmsNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"SMS To {recipient}:");
            Console.WriteLine("============================================");
            Console.WriteLine(message);
            Console.WriteLine("============================================");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
