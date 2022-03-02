using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace User_Registration_Regex_Unit_Testing
{
    internal class UserRegistrationPattern
    {
        public static string name = "";

        public void ValidateFirstName(string[] names)
        {
            foreach (string n in names)
            {
                string result = Regex.IsMatch(n, name) ? $"{n} entered is valid" : $"{n} entered is Invalid";

                Console.WriteLine(result);
            }

        }
    }
}
