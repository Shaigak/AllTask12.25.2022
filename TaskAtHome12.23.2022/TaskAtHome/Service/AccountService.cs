using Service.Interfaces;
using TaskAtHome.Helpers.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAtHome.Helpers.Constants;

namespace Service
{
    public class AccountService : IAccount
    {
        public string Login(string username, string password,int roles)
        {
            if(username== "test@code.edu.az" && password == "test12345"&& roles == (int)Roles.SuperAdmin)
            {
                return ErrorsClas.LoginSuc;
            }
            else if(roles != (int)Roles.SuperAdmin)
            {
                return ErrorsClas.LoginError;
            }
            return ErrorsClas.LoginMessageError;
            
        }
    }
}
