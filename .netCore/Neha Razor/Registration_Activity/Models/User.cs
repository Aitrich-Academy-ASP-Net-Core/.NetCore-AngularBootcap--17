using System.ComponentModel.DataAnnotations;

namespace Registration_Activity.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
       
        public string Password { get; set; }
    }
}
