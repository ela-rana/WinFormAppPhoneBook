//Design a personal phone /address book using Dictionary collection. Write a person class to store 
//details of person like : FirstName , LastName , Mobile Phone, Work Phone and Address.
//Provide a grid to display all, add more, delete ( with confirmation message) and search by name.
//Search should show details of person searched. You may use the key as name of person.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormAppPhoneBook
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CellPhone { get; set; }
        public string HomePhone { get; set; }
        public string Address{ get; set; }
    }
}
