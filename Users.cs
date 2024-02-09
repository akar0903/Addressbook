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
        public int GetContactCountByCity(string city)
        {
            int count = 0;
            foreach (var addressBook in dict.Values)
            {
                count += addressBook.GetContactCountByCity(city);
            }
            return count;
        }
        public int GetContactCountByState(string state)
        {
            int count = 0;
            foreach (var addressBook in dict.Values)
            {
                count += addressBook.GetContactCountByState(state);
            }
            return count;
        }
        public List<Contact> SortAllContactsByName()
        {
            List<Contact> sortedContacts = new List<Contact>();
            foreach (var addressBook in dict.Values)
            {
                sortedContacts.AddRange(addressBook.GetAllContacts());
            }
            sortedContacts.Sort((x, y) => x.Firstname.CompareTo(y.Firstname));
            return sortedContacts;
        }

        public List<Contact> SortAllContactsByCity()
        {
            List<Contact> sortedContacts = new List<Contact>();
            foreach (var addressBook in dict.Values)
            {
                sortedContacts.AddRange(addressBook.GetAllContacts()); // use the GetAllContacts method
            }
            sortedContacts.Sort((x, y) => x.City.CompareTo(y.City));
            return sortedContacts;
        }
        public List<Contact> SortAllContactsByState()
        {
            List<Contact> sortedContacts = new List<Contact>();
            foreach (var addressBook in dict.Values)
            {
                sortedContacts.AddRange(addressBook.GetAllContacts()); // use the GetAllContacts method
            }
            sortedContacts.Sort((x, y) => x.State.CompareTo(y.State));
            return sortedContacts;
        }
        public List<Contact> SortAllContactsByZip()
        {
            List<Contact> sortedContacts = new List<Contact>();
            foreach (var addressBook in dict.Values)
            {
                sortedContacts.AddRange(addressBook.GetAllContacts()); // use the GetAllContacts method
            }
            sortedContacts.Sort((x, y) => x.Zipcode.CompareTo(y.Zipcode));
            return sortedContacts;
        }
    }
}