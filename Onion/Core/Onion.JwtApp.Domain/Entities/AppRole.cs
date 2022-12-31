namespace Onion.JwtApp.Domain.Entities
{
    public class AppRole
    {
        public int Id { get; set; }
        public string? Definition { get; set; }

        public List<AppUser>? AppUsers { get; set; }
    }
}
