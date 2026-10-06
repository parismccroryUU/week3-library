using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Text;

namespace Library
{
    internal class Member
    {
        //Private fields
        private int memberID;
        private string name;
        private string address;
        private int phone;
        // Public properties
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
                    Console.WriteLine("Error: Member name cannot be blank or contain numbers");
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
        //Constructor
        public Member(int LmemberID, string Mname, string Maddress, int Mphone)
        {
            this.memberID = LmemberID; // Assigns the camelCase parameter to the PascalCase property
            this.name = Mname;
            this.address = Maddress;
            this.phone = Mphone;
        }
        //Methods
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
