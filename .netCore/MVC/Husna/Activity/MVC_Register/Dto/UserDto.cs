namespace MVC_Register.Dto
{
    public class UserDto
    {
        public int Id { get; set; }

        public required string Name { get; set; }
        public required string Email { get; set; }
    }
}
