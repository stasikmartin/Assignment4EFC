using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using AdultsWebApi.Model;

namespace AdultsWebApi.Data
{
    public class UserService : IUserService
    {
        private IList<User> users;
        
        public async Task<IList<User>> getUsers()
        {
            if (!File.Exists(@"C:\JetBrains Rider staff\C# files\users.json"))
            {
                seed();
                string productsAsJson = JsonSerializer.Serialize(users);
                File.WriteAllText(@"C:\JetBrains Rider staff\C# files\users.json", productsAsJson);
                return users;
            }
            else
            {
                string productsAsJson = File.ReadAllText(@"C:\JetBrains Rider staff\C# files\users.json");
                users = JsonSerializer.Deserialize<IList<User>>(productsAsJson);
                return users;
            }
        }


        public void seed()
        {
            users = new[] {
                new User {
                    City = "Horsens",
                    Domain = "via.dk",
                    Password = "123456",
                    Role = "Teacher",
                    BirthYear = 1986,
                    SecurityLevel = 5,
                    UserName = "Troels"
                },
                new User {
                    City = "Aarhus",
                    Domain = "hotmail.com",
                    Password = "123456",
                    Role = "Student",
                    BirthYear = 1998,
                    SecurityLevel = 3,
                    UserName = "Jakob"
                },
                new User {
                    City = "Vejle",
                    Domain = "via.com",
                    Password = "123456",
                    Role = "Guest",
                    BirthYear = 1973,
                    SecurityLevel = 1,
                    UserName = "Kasper"
                }
            }.ToList();
        }

    }
}