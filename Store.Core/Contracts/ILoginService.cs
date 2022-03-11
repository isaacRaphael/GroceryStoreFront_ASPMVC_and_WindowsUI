using System.Collections.Generic;

namespace Store.Core.Services
{
    public interface ILoginService
    {
        bool ValidateLogIn(string username, string password);
    }
}