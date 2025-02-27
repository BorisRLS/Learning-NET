using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Exception
{
    public class Users
    {
        public string FirstName { get; set;}
        public string LastName { get; set;}
        public DateTime BirthDate { get; set;}

        public Users(string firstName, string lastName, DateTime birthDate)
        {
            DateTime minAllowedDate = DateTime.Now.AddYears(-200);
            if (firstName is null || lastName is null || birthDate <= minAllowedDate)
            {
                throw new ConstructException();
            }
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }
    }
}
