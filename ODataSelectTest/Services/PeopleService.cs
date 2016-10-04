using ODataSelectTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ODataSelectTest.Services
{
    public class PeopleService
    {
        private HashSet<Type> _types;

        public PeopleService()
        {
            _types = new HashSet<Type>();
            _types.Add(typeof(Male));
            _types.Add(typeof(Female));
        }

        public IQueryable<Person> GetPeople(string gender)
        {
            IQueryable<Person> result;
            Type type = _types.Where(t => t.Name == gender).FirstOrDefault();

            if (type == null)
            {
                throw new Exception("Type " + gender + " does not exist");
            }

            MockDbContext db = new MockDbContext();
            result = (db.Set(type) as IQueryable<Person>);

            return result;
        }

        public IQueryable<Person> GetPerson(int key, string gender)
        {
            IQueryable<Person> result;
            Type type = _types.Where(t => t.Name == gender).FirstOrDefault();

            if (type == null)
            {
                throw new Exception("Type " + gender + " does not exist");
            }

            MockDbContext db = new MockDbContext();
            result = (db.Set(type) as IQueryable<Person>).Where(p => p.Id == key);

            return result;
        }
    }
}