using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using AdultsWebApi.Model;

namespace AdultsWebApi.Data
{
    public interface IUserService
    {
        Task<IList<User>> getUsers();
    }
}