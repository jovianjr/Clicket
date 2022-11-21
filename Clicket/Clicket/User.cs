using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Security.Cryptography;

namespace Clicket
{
    internal class User
    {
        private static int _id;
        private string _username;
        private string _password;
        private string _name;
        private string _email;
        private int _phone;
        private DateTime _birth;
        private static int _role_id;

        public static int UserID { get => _id; }
        public static int RoleID { get => _role_id; }

        public string Username { get => _username; }

        public string Password { get => _password; set => _password = value; }

        public string Name { get => _name; set => _name = value; }

        public string Email { get => _email; set => _email = value; }

        public int Phone { get => _phone; set => _phone = value; }

        public DateTime Birth { get => _birth; set => _birth = value; }

        public void SetData(int id, string username, string password, string name, string email, int phone, DateTime birth, int role)
        {
            _id = id;
            _username = username;
            _password = password;
            _name = name;
            _email = email;
            _phone = phone;
            _birth = birth;
            _role_id = role;
        }

        public Boolean SignUp(string username, string password, string name, string email, DateOnly birth)
        {
            return false;
        }
    }
}
