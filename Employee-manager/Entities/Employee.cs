namespace Employee_manager.Entities
{
    public class Employee
    {

        public Employee()
        {
            StartOfContract = DateTime.Now;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public string Position { get; set; }

        public string Department { get; set; }

        public decimal Salary { get; set; }

        public DateTime StartOfContract { get; set; }


        public void Update(string name, string position, string department, decimal salary)
        {
            Name = name;
            Position = position;
            Department = department;
            Salary = salary;
        }


    }
}
