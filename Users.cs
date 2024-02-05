using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book_System
{
    class Users
    {
        Dictionary<string, AddressBook> dict = new Dictionary<string, AddressBook>();
        public void AddPerson(string name)
        {
            AddressBook book = new AddressBook();
            if (!dict.ContainsKey(name))
            {
                dict.Add(name, book);
                Console.WriteLine("Person added successfully");
            }
            else
            {
                Console.WriteLine($"{name} already exist");
            }
        }

        public void DisplayPerson()
        {
            foreach (var entry in dict)
            {
                Console.WriteLine(entry.Key);
            }
        }
        public AddressBook getAddressBook(string name)
        {
            return dict[name];
        }
        public Dictionary<string, AddressBook> GetPersons()
        {
            return dict;
        }
        public List<Contact> SearchPersonsInCity(string city)
        {
            List<Contact> results = new List<Contact>();
            foreach (var addressBook in dict.Values)
            {
                results.AddRange(addressBook.SearchByCity(city));
            }
            return results;
        }

        public List<Contact> SearchPersonsInState(string state)
        {
            List<Contact> results = new List<Contact>();
            foreach (var addressBook in dict.Values)
            {
                results.AddRange(addressBook.SearchByState(state));
            }
            return results;
        }
        public List<Contact> SearchPersonsInName(string name)
        {
            List<Contact> results = new List<Contact>();
            foreach (var addressBook in dict.Values)
            {
                results.AddRange(addressBook.SearchByName(name));
            }
            return results;
        }

    }
}