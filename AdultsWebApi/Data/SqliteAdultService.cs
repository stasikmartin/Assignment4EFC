using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AdultsWebApi.Model;
using AdultsWebApi.Persistance;
using Microsoft.EntityFrameworkCore;

namespace AdultsWebApi.Data
{
    public class SqliteAdultService : IAdultService
    {
        private AdultsContext db;

        public SqliteAdultService(AdultsContext adultsContext)
        {
            db = adultsContext;
        }
        
        
        public async Task<IList<Adult>> GetPersons()
        {
            return await db.adults.ToListAsync();
        }

        public async Task AddPerson(Adult person)
        {
            await db.adults.AddAsync(person);
            await db.SaveChangesAsync();
        }

        public async Task RemovePerson(int id)
        {
            Adult toRemove = await db.adults.FirstOrDefaultAsync(a =>
                a.id == id);
            if (toRemove != null)
            {
                db.adults.Remove(toRemove);
                await db.SaveChangesAsync();
            }
            else
            {
                throw new NullReferenceException("adult "+toRemove.id+" does not exist");
            }
        }
    }
}