using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdultsWebApi.Model;
using AdultsWebApi.Persistance;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace AdultsWebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (AdultsContext db = new AdultsContext())
            {
                if (!db.adults.Any())
                {
                    seed(db);
                }
                
            }

            using (UsersContext db = new UsersContext())
            {
                if (!db.users.Any())
                {
                    seedUsers(db);
                }
            }
            CreateHostBuilder(args).Build().Run();
        }


        public static void seedUsers(UsersContext db)
        {
            IList<User> users = new[]
            {
                new User
                {
                    City = "Horsens",
                    Domain = "via.dk",
                    Password = "123456",
                    Role = "Teacher",
                    BirthYear = 1986,
                    SecurityLevel = 5,
                    UserName = "Troels"
                },
                new User
                {
                    City = "Aarhus",
                    Domain = "hotmail.com",
                    Password = "123456",
                    Role = "Student",
                    BirthYear = 1998,
                    SecurityLevel = 3,
                    UserName = "Jakob"
                },
                new User
                {
                    City = "Vejle",
                    Domain = "via.com",
                    Password = "123456",
                    Role = "Guest",
                    BirthYear = 1973,
                    SecurityLevel = 1,
                    UserName = "Kasper"
                }
            }.ToList();

            foreach (var user in users)
            {
                db.Add(user);
            }

            db.SaveChanges();
        }
        
        public static void seed(AdultsContext db)
        {
            Adult[] adults = {new Adult
                {
                    firstName = "Alex", lastName = "Clinton", id = 1, hairColor = 
                        "brown", eyeColor = "blue", age = 17, weight = 80,
                    height = 170, jobTitle = "Astronaut", sex = "M"
                }, new Adult
                {
                    firstName = "John", lastName = "Smith", id = 2, hairColor = 
                        "black", eyeColor = "brown", age = 25, weight = 87,
                    height = 180, jobTitle = "Chef", sex = "M"
                }, new Adult
                {
                    firstName = "Sara", lastName = "Jordan", id = 3, hairColor = 
                        "black", eyeColor = "green", age = 41, weight = 50,
                    height = 167, jobTitle = "Police", sex = "F"
                }
            };
            foreach (Adult adult in adults)
            {
                db.adults.Add(adult);
            }
            db.SaveChanges();
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}