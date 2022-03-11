using Store.Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Core.Services
{
    public class LoginService : ILoginService
    {
        private ILoginRepository _loginRepository;
        public LoginService(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }
        public bool ValidateLogIn(string username, string password)
        {
            bool result = false;
            
            var listOfUser = _loginRepository.checkUser();
            foreach (var pair in listOfUser)
            {
                if (pair.Key == username && pair.Value == password)
                {
                    result = true;
                }        
            }

            return result;
        }
    }
}
