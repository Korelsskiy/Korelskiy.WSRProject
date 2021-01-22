using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korelskiy.WSRProject.Infrastructure
{
   public interface IDbProccessor
    {
        bool Login(string userEmail, string userPassword);

    }
}
