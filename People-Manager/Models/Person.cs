namespace People_Manager.Models
{
    public class Person
    {
        public Person(int id, string name, string surname, DateTime birthdate)
        {
            Id = id;
            Name = name;
            Name = name;
            Surname = surname;
            BirthDate = birthdate;
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public DateTime BirthDate { get; set; }

    }
}
