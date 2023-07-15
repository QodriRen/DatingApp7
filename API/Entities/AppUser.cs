
namespace API.Entities
{
    public class AppUser
    {
        // If you wannna use a custome primary key
        // [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
    }
}