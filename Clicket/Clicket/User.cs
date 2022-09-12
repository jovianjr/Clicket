namespace Clicket
{
    internal class User
    {
        private string username;
        private string password;
        private string name;
        private string email;
        private int phone;
        private DateOnly birth;

        public int UserID { get; }

        public string Username { get => username; }

        public string Password { get => password; set => password = value; }

        public string Name { get => name; set => name = value; }

        public string Email { get => email; set => email = value; }

        public int Phone { get => phone; set => phone = value; }

        public DateOnly Birth { get => birth; set => birth = value; }

        public Boolean Login(string username, string password)
        {
            return false;
        }

        public Boolean SignUp(string username, string password, string name, string email, DateOnly birth)
        {
            return false;
        }
    }
}
