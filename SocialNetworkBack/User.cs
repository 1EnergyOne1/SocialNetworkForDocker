namespace SocialNetworkBack
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string? Lastname { get; set; }

        public string Login { get; set; } = null!;

        public string Password { get; set; } = null!;

        public int? Age { get; set; }

        public DateTime Datecreate { get; set; }

        public bool Isadmin { get; set; }
    }
}
