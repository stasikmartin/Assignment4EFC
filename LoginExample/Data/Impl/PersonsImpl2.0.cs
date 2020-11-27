using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LoginExample.Data.Impl
{
    public class PersonsImpl2_0 : IPersons
    {
        public async Task<List<Adult>> GetPersons()
        {
            HttpClient client = new HttpClient();
            string message = await client.GetStringAsync("https://localhost:5005/Adults");
            List<Adult> result = JsonSerializer.Deserialize<List<Adult>>(message);
            return result;
            
        }

        public async Task AddPerson(Adult person)
        {
            HttpClient client = new HttpClient();
            string toPost = JsonSerializer.Serialize(person);
            Console.WriteLine(toPost);
            StringContent content = new StringContent(toPost, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync("https://localhost:5005/Adults", content);
            //HttpResponseMessage response = await client.PostAsync("https://localhost:5003/Todos",content);
            Console.WriteLine(response.StatusCode);
        }

        public async Task RemovePerson(int id)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.DeleteAsync("https://localhost:5005/Adults/"+id);
            Console.WriteLine(response.StatusCode);
        }
    }
}