using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Threading.Tasks;
using LoginExample.Models;

namespace LoginExample.Data.Impl {
    public class InMemoryUserService : IUserService
    {
        private IList<User> users;

        public InMemoryUserService()
        {
         initialiseUsers();
        }
        
        public async void initialiseUsers()
        {
            HttpClient client = new HttpClient();
            string result = await client.GetStringAsync("https://localhost:5005/Users");
            users = JsonSerializer.Deserialize<IList<User>>(result);
            // Console.WriteLine(users.Count);
        }


        public User ValidateUser(string userName, string password) {
            User first = users.FirstOrDefault(user => user.UserName.Equals(userName));
            if (first == null) {
                throw new Exception("User not found");
            }

            if (!first.Password.Equals(password)) {
                throw new Exception("Incorrect password");
            }

            return first;
        }
    }
}