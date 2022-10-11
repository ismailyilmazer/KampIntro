
using ProjectK.Abstract;


namespace ProjectK.Entities
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public DateTime? CreatedDate { get; set; }
        public string? NationalityId { get; set; }



    }
}
