namespace BoardGameTeka.Model.Entities
{
    public class User 
    {
        public virtual int UserId { get; protected set; }
        public virtual string Username { get; set; }
        public virtual string Password { get; set; }
        public virtual Role Role { get; set; }

    }
}
