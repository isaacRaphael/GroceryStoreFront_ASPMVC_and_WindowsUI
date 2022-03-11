using System.Collections.Generic;

namespace Store.Core.DataAccess
{
    public interface ILoginRepository
    {
        Dictionary<string, string> checkUser();
    }
}