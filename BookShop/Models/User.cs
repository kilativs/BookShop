namespace BookShop.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string EmailAdrress { get; set; }

        public UserRoles UserRole { get; set; }

        public User()
        {
            Id = 0;
            Login = null;
            Password = null;
            FirstName = null;
            LastName = null;
            Address = null;
            Phone = null;
            EmailAdrress = null;
            UserRole = UserRoles.Member;
        }

        public User(int id, string login, string password, string firstName, string lastName, string address, string phone,
            string email, UserRoles role)
        {
            Id = id;
            Login = login;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Phone = phone;
            EmailAdrress = email;
            UserRole = role;
        }
    }
}
