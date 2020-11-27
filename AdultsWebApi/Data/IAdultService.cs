using System.Collections.Generic;
using System.Threading.Tasks;
using AdultsWebApi.Model;

namespace AdultsWebApi.Data
{
    public interface IAdultService
    {
        Task<IList<Adult>> GetPersons();

        Task AddPerson(Adult person);

        Task RemovePerson(int id);
    }
}