namespace BoardGameTeka.Model.Entities
{
    public class MembershipType
    {
        public virtual int MembershipTypeId { get; protected set; }
        public virtual string Name { get; set; }
        public virtual int DurationInMonths { get; set; }

    }
}
