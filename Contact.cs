using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressBookSystem
{
   public class Contact
    {
        public string firstName;
        public string lastName;
        public string mobileNumber;
        public string address;
        public string city;
        public string state;
        public string zip;
        public string email;

        public override string ToString()
        {
            return $"Name: {firstName} {lastName}\nMobile Number: {mobileNumber}\nAddress: {address}\nCity: {city}\nState: {state}\nZip: {zip}\nEmail: {email}\n";
        }
    }


}
}
