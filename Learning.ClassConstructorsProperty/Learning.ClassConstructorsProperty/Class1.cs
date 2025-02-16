using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.ClassConstructorsProperty
{
    public class SportFitShopUser
    {
        private string fName;
        private string lName;
        public string FirstName
        {
            get
            {
                return fName;
            }
            set
            {
                if (string.IsNullOrEmpty(fName))
                {
                    throw new ArgumentNullException("Имя не может быть пустым");
                }
                fName = value;
            }
        }
        public string LastName
       {
            get
            {
                return lName;
            }
            set
            {
                if (string.IsNullOrEmpty(lName))
                {
                    throw new ArgumentNullException("Фамилия не может быть пустой");
                }
                lName = value;
            }
        }
        public SportFitShopUser(string LastName, string FirstName)
        {
            lName = LastName;
            fName = FirstName;
        }

        public int SportId { get; set; }
        public int CardBalance { get; set; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public string FullSportName
        {
            get
            {
                return $"{LastName} {FirstName} {SportId} {CardBalance}";
            }
        }

    }
}
