using ODataSelectTest.Models;
using System.Data.Entity;

namespace ODataSelectTest
{
    public class MockDbContext : DbContext
    {
        public virtual DbSet<Male> Males { get; set; }

        public virtual DbSet<Female> Females { get; set; }
    }
}