using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Metods
{
    public class ProductCase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public double Balance { get; set; }
        public double Price { get; set; }

        public string Status
        {
            get
            {
                if (Balance <= 0.0) return "Bronze";
                if (Balance < 10000.0) return "Silver";
                return "Gold";
            }
        }

        public ProductCase(string lastName, string firstName, int id, double balance, double price)
        {
            LastName = lastName;
            FirstName = firstName;
            Id = id;
            Balance = balance;
            Price = price;
        }

        public string FullName => $"{LastName} {FirstName} - {Status}";
    }
}