using Data_Entity_Layer.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Entity_Layer.InterfaceRepo
{
    public interface IAuth
    {
        Token Authenticate(Login login);

        bool isAuthenticated(string token);

        bool Logout(string login);
    }
}
