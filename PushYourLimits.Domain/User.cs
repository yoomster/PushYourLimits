using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace PushYourLimits.Domain
{
    public class User
    {
        public User(
            string email,
            string password,
            string name,
            int birthYear
            )
        {
            if (string.IsNullOrWhiteSpace(email) || !IsValidEmailFormat(email))
                throw new ArgumentException("Email format is incorrect, moet @ bevatten.");

            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Wachtwoord is incorrect, deze moet minstens 6 characters bevatten.");

            if (birthYear > DateTime.Now.Year)
                throw new ArgumentException("Geboortejaar kan niet hoger zijn dan het huidige jaar.");


            Email = email;
            Password = password;
            Name = name;
            BirthYear = birthYear;
        }
        private bool IsValidEmailFormat(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public int Id { get; init; }
        public string Name { get; init; }
        public string LastName { get; init; }
        public string Email { get; init; }
        public string Password { get; init; }
        public int BirthYear { get; init; }

    }
}
