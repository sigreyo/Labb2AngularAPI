using Bogus;
using Microsoft.EntityFrameworkCore;

namespace Labb2AngularAPI.Models
{
    public class StaffDbContext:DbContext
    {
        public StaffDbContext(DbContextOptions opt) : base(opt){ }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var gender = new[] { "Male", "Female" };
            var personId = 1;
            var persons = new Faker<Person>("sv")
                .RuleFor(p => p.Id, f => personId++)
                .RuleFor(p => p.FirstName, f => f.Name.FirstName())
                .RuleFor(p => p.LastName, f => f.Name.LastName())
                .RuleFor(p => p.Address, f => f.Address.StreetAddress())
                .RuleFor(p => p.Salary, f => f.Random.Int(32000, 59000))
                .RuleFor(p => p.Gender, f => f.PickRandom(gender))
                .RuleFor(p => p.DepartmentId, f => f.Random.Int(1, 10));

            var depId = 1;
            var departments = new Faker<Department>("sv")
                .RuleFor(d => d.Id, f => depId++)
                .RuleFor(d => d.Name, f => f.Commerce.Department());

            modelBuilder.Entity<Person>().HasData(persons.Generate(50));
            modelBuilder.Entity<Department>().HasData(departments.Generate(10));

        }

        public DbSet<Person> Person { get; set; }
    }
}
