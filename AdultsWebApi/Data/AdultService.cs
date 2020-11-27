using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using AdultsWebApi.Model;

namespace AdultsWebApi.Data
{
    public class AdultService : IAdultService
    {
        public async Task<IList<Adult>> GetPersons()
        {
            string content = File.ReadAllText(@"C:\JetBrains Rider staff\C# files\adults.json");
            IList<Adult> adults = JsonSerializer.Deserialize<List<Adult>>(content);
            return adults;
        }

        public async Task AddPerson(Adult person)
        {
            string content = File.ReadAllText(@"C:\JetBrains Rider staff\C# files\adults.json");
            IList<Adult> adults = JsonSerializer.Deserialize<List<Adult>>(content);
            //int maxId = adults.Max(a => a.id)+1;
            //todo.TodoId = maxId;
            adults.Add(person);

            string productsAsJson = JsonSerializer.Serialize(adults);
            File.WriteAllText(@"C:\JetBrains Rider staff\C# files\adults.json", productsAsJson);
        }

        public async Task RemovePerson(int id)
        {
            string content = File.ReadAllText(@"C:\JetBrains Rider staff\C# files\adults.json");
            IList<Adult> adults = JsonSerializer.Deserialize<List<Adult>>(content);
            Adult toRemove = adults.First(a => a.id == id);
            adults.Remove(toRemove);
            string productsAsJson = JsonSerializer.Serialize(adults);
            File.WriteAllText(@"C:\JetBrains Rider staff\C# files\adults.json", productsAsJson);
        }
    }
}