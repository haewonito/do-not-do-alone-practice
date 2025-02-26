namespace do_not_do_alone_practice.Server.Models
{
    public class Friend
    {
//todo make a constructor with empty strings instead of this
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; } = "";
        public string Email { get; set; } = "";
        public string Phone { get; set; } = "";
        public string Address { get; set; } = "";
        public string PreferredContact { get; set; } = "";
        public string Note { get; set; } = "";

    }
    
}
