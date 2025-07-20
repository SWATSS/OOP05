using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Advanced.Interface
{
    internal interface INotificationService
    {
        #region Question 03:
        public void SendNotification(string recipient, string message);
        #endregion
    }
}
