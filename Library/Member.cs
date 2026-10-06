using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Text;

namespace Library
{
    internal class Member
    {
        private int memberID;
        private string name;
        private string address;
        private int phone;

        public int MemberID
        {
            get { return memberID; }
            private set // Private setter makes read-only
            {
                if (value > 0)
                {
                    MemberID = value;
                }
                else
                {
                    Console.WriteLine("Error: Member ID must be greater than 0.");
                }
            } 
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (!value.Any(char.IsDigit) && value != " ")
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Error: Member name cannot be blank or contain numbers")
                }
            }
        }
        public string Address
        {
            get { return address; }  
            set { address = value; } 
        }
        public int Phone
        {
            get { return phone; }  // get method
            set { phone = value; } // set method
        }

        public Member(int memberID, string name, string address, int phone)
        {
            this.memberID = memberID; // Assigns the camelCase parameter to the PascalCase property
            this.name = name;
            this.address = address;
            this.phone = phone;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Member ID: {memberID}");
            Console.WriteLine($"Member Name: {name}");
            Console.WriteLine($"Member Address: {address}");
            Console.WriteLine($"Member Phone No: {phone}");
            Console.WriteLine();
        }   
    }
}
