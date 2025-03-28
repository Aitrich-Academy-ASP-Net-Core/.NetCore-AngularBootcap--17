namespace Example1
{
    public abstract class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        //non abstract method
        public bool Login(string username, string password)
        {
            Console.WriteLine("Login success !!!");
            return true;
        }
        //Abstract method
        abstract public void Welcome();
    }
}
