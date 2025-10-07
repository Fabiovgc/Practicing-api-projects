namespace Events_manager.Models
{
    public class Event
    {

        public Event()
        {
            CreatedAt = DateTime.Now;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Ticket { get; set; }
        public DateTime CreatedAt { get; set; }


        public void Update(string name, string description, decimal ticket)
        {
            Name = name;
            Description = description;
            Ticket = ticket;
        }

    }
}
