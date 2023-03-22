using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressBookSystem
{
   public class Contact
    {
        public String firstname, lastname, mobilenumber, address, city, zip, state, email;
        public override string ToString()
        {
            return $"First Name: {firstname}, Last Name: {lastname}, Mobile Number: {mobilenumber}, Address: {address}, City: {city}, State: {state}, Zip: {zip}, Email: {email}";
        }

    }
}
