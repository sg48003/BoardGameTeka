namespace BoardGameTeka.Model.Entities
{
    public class Member 
    {
        public virtual int MemberId { get; protected set; }
        public virtual string Name { get; set; }
        public virtual int PhoneNumber { get; set; }
        public virtual MembershipType MembershipType { get; set; }

    }
}
