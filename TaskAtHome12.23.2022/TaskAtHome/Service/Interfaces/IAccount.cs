using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    interface IAccount
    {
        string  Login(string username, string password,int roles);
    }
}
