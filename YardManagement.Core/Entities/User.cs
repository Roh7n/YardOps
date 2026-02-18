namespace YardManagement.Core.Entities
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string Fullname { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

    }
}
