namespace Labb2AngularAPI.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Person? Person { get; set; }
    }
}