using ODataSelectTest.Models;
using System;
using System.Collections.Generic;

namespace ODataSelectTest.Services
{
    public static class DbManager
    {
        private static Random random = new Random(DateTime.Now.Second); 
        public static void AddSampleData()
        {
            MockDbContext db = new MockDbContext();
            string[] maleNames = new string[] { "aaron", "abdul", "abe", "abel", "abraham", "adam", "adan", "adolfo", "adolph", "adrian" };
            string[] femaleNames = new string[] { "abby", "abigail", "adele", "adrian" };
            string[] lastNames = new string[] { "abbott", "acosta", "adams", "adkins", "aguilar" };
            List<Male> males = new List<Male>();
            List<Female> females = new List<Female>();

            for (var i = 0; i < 10; i++)
            {
                males.Add(new Male
                {
                    Age = random.Next(0, 200),
                    FirstName = maleNames[random.Next(0, maleNames.Length - 1)],
                    LastName = lastNames[random.Next(0, lastNames.Length - 1)]
                });

                females.Add(new Female
                {
                    Age = random.Next(0, 200),
                    FirstName = femaleNames[random.Next(0, femaleNames.Length - 1)],
                    LastName = lastNames[random.Next(0, lastNames.Length - 1)]
                });
            }

            db.Males.AddRange(males);
            db.Females.AddRange(females);
            db.SaveChanges();
        }
    }
}