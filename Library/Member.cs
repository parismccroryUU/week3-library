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
            set { memberID = value; } // Private setter makes read-only
        }
        public string Name
        {
            get { return name; }  // get method
            set { name = value; } // set method
        }
        public string Address
        {
            get { return address; }  // get method
            set { address = value; } // set method
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
    }
}
