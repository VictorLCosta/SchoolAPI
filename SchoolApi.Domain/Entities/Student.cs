namespace SchoolApi.Domain.Entities
{
    public class Student : BaseEntity
    {
        public string RA { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public char Gender { get; set; }
        public string CPF { get; set; }
    }
}