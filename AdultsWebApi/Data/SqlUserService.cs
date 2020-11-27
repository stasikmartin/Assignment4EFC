using System.Collections.Generic;
using System.Threading.Tasks;
using AdultsWebApi.Model;
using AdultsWebApi.Persistance;
using Microsoft.EntityFrameworkCore;

namespace AdultsWebApi.Data
{
    public class SqlUserService:IUserService
    {
        private UsersContext db;

        public SqlUserService(UsersContext usersContext)
        {
            db = usersContext;
        }
        
        public async Task<IList<User>> getUsers()
        {
            return await db.users.ToListAsync();
        }
        
        
    }
}