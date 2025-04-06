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
            if (string.IsNullOrWhiteSpace(email) || !HasValidEmailFormat(email))
                throw new ArgumentException("Email format is incorrect, moet @ bevatten.");

            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Wachtwoord is incorrect, deze moet minstens 6 characters bevatten.");

            //if (!HasValidPasswordComplexity(password))
            //    throw new ArgumentException("Wachtwoord moet minstens 1 hoofdletter, 1 cijfer en 1 speciaal teken bevatten.");

            if ((DateTime.Now.Year - birthYear) < 13)
                throw new ArgumentException("Je moet minimaal 13 jaar oud zijn.");


            Email = email;
            Password = password;
            Name = name;
            BirthYear = birthYear;
        }
        private bool HasValidEmailFormat(string email)
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

        //private bool HasValidPasswordComplexity(string password)
        //{
        //    bool output = false;

        //    //not there yet.. FIX LATER!
        //    if (password.Contains(@"^(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&]).{6,}$"))
        //    {
        //        output = true;
        //    }

        //    return output;
        //}

        public int Id { get; init; }
        public string Name { get; init; }
        public string Email { get; init; }
        public string Password { get; init; }
        public int BirthYear { get; init; }
        public int DailyGoal { get; set; }


        public void RegisterActivity()
        {

        }

        public void GetProgress()
        {

        }
    }
}
