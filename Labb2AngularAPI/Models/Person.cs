namespace Labb2AngularAPI.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int Salary { get; set; }
        public Gender Gender { get; set; }

        public int? DepartmentId { get; set; }
        public ICollection<Department>? Department { get; set; }

    }
}
