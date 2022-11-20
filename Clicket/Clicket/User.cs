using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace Clicket
{
    internal class User
    {
        private string _username;
        private string _password;
        private string _name;
        private string _email;
        private int _phone;
        private DateTime _birth;

        public static int UserID { get; }

        public string Username { get => _username; }

        public string Password { get => _password; set => _password = value; }

        public string Name { get => _name; set => _name = value; }

        public string Email { get => _email; set => _email = value; }

        public int Phone { get => _phone; set => _phone = value; }

        public DateTime Birth { get => _birth; set => _birth = value; }

        public void SetData(string username, string password, string name, string email, int phone, DateTime birth)
        {
            _username = username;
            _password = password;
            _name = name;
            _email = email;
            _phone = phone;
            _birth = birth;
        }

        public Boolean SignUp(string username, string password, string name, string email, DateOnly birth)
        {
            return false;
        }
    }
}
