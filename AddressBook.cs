using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Address_Book_System
{
    class AddressBook
    {
        List<Contact> contacts = new List<Contact>();
        public void Add_details()
        {
            Console.WriteLine("Enter the first name: ");
            string firstname = Console.ReadLine();
            if (contacts.Any(c => c.Equals(new Contact { Firstname = firstname })))
            {
                Console.WriteLine($"Duplicate entry for {firstname}. Person already exists in the Address Book.");
                Thread.Sleep(4000);
                Console.Clear();
                return;
            }
            Console.WriteLine("Enter the last name: ");
            string lastname = Console.ReadLine();
            Console.WriteLine("Enter the Phone: ");
            string phone = Console.ReadLine();
            int f = 0;
            do
            {
                if (!Regex.IsMatch(phone, @"^[6-8]\d{9}$"))
                {
                    Console.WriteLine("Invalid phone number format. Please enter a valid phone number.");
                    string newphone = Console.ReadLine();
                    if (Regex.IsMatch(newphone, @"^[6-8]\d{9}$"))
                    {
                        phone = newphone;
                        f = 1;
                    }
                }
                else
                {
                    f = 1;
                }
            } while (f == 0);

            Console.WriteLine("Enter the address: ");
            string address = Console.ReadLine();
            Console.WriteLine("Enter the city: ");
            string city = Console.ReadLine();
            Console.WriteLine("Enter the state: ");
            string state = Console.ReadLine();
            Console.WriteLine("Enter the email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Enter the Zipcode: ");
            long zipcode = Convert.ToInt64(Console.ReadLine());
            int fl = 0;
            do
            {
                if (!Regex.IsMatch(zipcode.ToString(), @"^[4-5]\d{5}$"))
                {
                    Console.WriteLine("Invalid zip code format. Please enter a valid zip code.");
                    string newzipcode = Console.ReadLine();
                    if (Regex.IsMatch(newzipcode, @"^[4-5]\d{5}$"))
                    {
                        zipcode = Convert.ToInt64(newzipcode);
                        fl = 1;
                    }
                }
                else
                {
                    fl = 1;
                }
            } while (fl == 0);

            Contact newCon = new Contact
            {
                Firstname = firstname,
                Lastname = lastname,
                Address = address,
                City = city,
                State = state,
                Phonenumber = phone,
                Email = email,
                Zipcode = zipcode
            };
            contacts.Add(newCon);
            Console.WriteLine("Contact added successfully");
            Thread.Sleep(4000);
            Console.Clear();
        }
        public List<Contact> GetAllContacts()
        {
            return contacts;
        }
        public void SortContactsByName()
        {
            contacts.Sort((x, y) => x.Firstname.CompareTo(y.Firstname));
        }
        public void Display_details()
        {
            SortContactsByName();
            foreach (var contact in contacts)
            {
                Console.WriteLine($"First Name: {contact.Firstname}");
                Console.WriteLine($"Last Name: {contact.Lastname}");
                Console.WriteLine($"Address: {contact.Address}");
                Console.WriteLine($"City: {contact.City}");
                Console.WriteLine($"State: {contact.State}");
                Console.WriteLine($"Phone: {contact.Phonenumber}");
                Console.WriteLine($"Email: {contact.Email}");
                Console.WriteLine($"Zipcode: {contact.Zipcode}");
                Console.WriteLine();
            }
        }

        public void Editted_Contact(string name)
        {
            Contact editContact = contacts.Find(contact => contact.Firstname == name);

            if (editContact != null)
            {
                Console.WriteLine();

                int flag = 0, n;
                do
                {
                    Console.WriteLine("Enter the option to edit : ");
                    Console.WriteLine("1. First Name\n2. Last Name\n3. Phone Number\n4. Email\n5. Address\n6. City\n7. State\n8. ZipCode\n9. Done\n");
                    n = Convert.ToInt32(Console.ReadLine());

                    switch (n)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Enter New First Name : ");
                            editContact.Firstname = Console.ReadLine();
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Enter New Last Name : ");
                            editContact.Lastname = Console.ReadLine();
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Enter New Phone Number : ");
                            editContact.Phonenumber = Console.ReadLine();
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("Enter New Email : ");
                            editContact.Email = Console.ReadLine();
                            break;
                        case 5:
                            Console.Clear();
                            Console.WriteLine("Enter New Address : ");
                            editContact.Address = Console.ReadLine();
                            break;
                        case 6:
                            Console.Clear();
                            Console.WriteLine("Enter New City : ");
                            editContact.City = Console.ReadLine();
                            break;
                        case 7:
                            Console.Clear();
                            Console.WriteLine("Enter New State : ");
                            editContact.State = Console.ReadLine();
                            break;
                        case 8:
                            Console.Clear();
                            Console.WriteLine("Enter New ZipCode : ");
                            editContact.Zipcode = Convert.ToInt64(Console.ReadLine());
                            break;
                        case 9:
                            Console.WriteLine("Edited..");
                            flag = 1;
                            break;
                        default:
                            Console.WriteLine("Invalid option. Please try again.");
                            break;
                    }

                    Console.Clear();
                    Console.WriteLine();
                } while (flag == 0);
            }
            else
            {
                Console.WriteLine($"The contact with the name '{name}' is not found in the contact list.");
                Thread.Sleep(2000);
            }

        }



        public void Delete(string name)
        {
            Contact deladdbook = contacts.Find(contact => contact.Firstname == name);
            if (deladdbook != null)
            {
                Console.WriteLine($"Are you sure of deleting {name}'s contact (Y/N)");
                char ch = Convert.ToChar(Console.ReadLine());
                if (ch == 'Y' || ch == 'y')
                {
                    contacts.Remove(deladdbook);
                    Console.WriteLine("Contact is Deleted ...");
                    Thread.Sleep(2000);
                }
                else
                {
                    Console.WriteLine("Contact Not Deleted");
                    Thread.Sleep(2000);
                }
            }
            else
            {
                Console.WriteLine($"The contact with the name '{name}' is not found in the contact list.");
                Thread.Sleep(2000);
            }
        }

        public List<Contact> SearchByCity(string city)
        {
            return contacts.Where(contact => contact.City.Equals(city, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<Contact> SearchByState(string state)
        {
            return contacts.Where(contact => contact.State.Equals(state, StringComparison.OrdinalIgnoreCase)).ToList();
        }
        public List<Contact> SearchByName(string name)
        {
            return contacts.Where(contact => contact.Firstname.Equals(name, StringComparison.OrdinalIgnoreCase)).ToList();
        }
        public int GetContactCountByCity(string city)
        {
            return contacts.Count(contact => contact.City.Equals(city, StringComparison.OrdinalIgnoreCase));
        }
        public int GetContactCountByState(string state)
        {
            return contacts.Count(contact => contact.State.Equals(state, StringComparison.OrdinalIgnoreCase));
        }

    }
}