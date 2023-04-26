using System.ComponentModel.DataAnnotations;


namespace LabiryntBackend.Models
{
    public class User
    {
        [Key]
        public long id_user { get; set; }
        public string login { get; set; }
        public string password { get; set; }

        public User(string login, string password)
        {
            this.id_user = 0;
            this.login = login;
            this.password = password;
        }
    }
}
