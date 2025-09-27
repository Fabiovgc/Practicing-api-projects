using System.ComponentModel.DataAnnotations;

namespace People_Manager.Models
{
    public class Person
    {
        public Person()
        {
        }

        public Person(int id, string name, string surname, DateTime birthdate)
        {
            Id = id;
            Name = name;
            Surname = surname;
            BirthDate = birthdate;
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "Name required ")]
        [StringLength(35, MinimumLength = 2, ErrorMessage = "Name cannot be shorter than 2 or longer than 35 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Surname required")]
        [StringLength(35, MinimumLength = 2, ErrorMessage = "Surname cannot be shorter than 2 or longer than 35 characters.")]
        public string Surname { get; set; }

        [Required(ErrorMessage ="Birth Date required")]
        [CustomValidation(typeof(Person), "ValidateBirthDate")]
        public DateTime? BirthDate { get; set; }

        public static ValidationResult ValidateBirthDate(DateTime birthDate)
        {
            if (birthDate > DateTime.Now)
            {
                return new ValidationResult("Birth date cannot be in the future.");
            }
                return ValidationResult.Success;
            
        }

    }
}
