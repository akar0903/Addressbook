using Address_Book_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Address_Book_System
{
    class Contact
    {
        public string firstname;
        public string lastname;
        public long phonenumber;
        public string email;
    }
    class AddressBook : Contact
    {
        public string address;
        public string cityname;
        public string state;
        public long zipcode;

        public void Add_details()
        {
            Console.Write("Enter First Name: ");
            this.firstname = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            this.lastname = Console.ReadLine();

            Console.Write("Enter Address: ");
            this.address = Console.ReadLine();

            Console.Write("Enter City: ");
            this.cityname = Console.ReadLine();

            Console.Write("Enter State: ");
            this.state = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            this.phonenumber = Convert.ToInt64(Console.ReadLine());

            Console.Write("Enter Zip Code: ");
            this.zipcode = Convert.ToInt64(Console.ReadLine());

            Console.Write("Enter Email: ");
            this.email = Console.ReadLine();
        }

        public void Display_details()
        {
            Console.WriteLine($"First Name : {this.firstname}");
            Console.WriteLine($"Last Name : {this.lastname}");
            Console.WriteLine($"Phone Number : {this.phonenumber}");
            Console.WriteLine($"Email : {this.email}");
            Console.WriteLine($"Address : {this.address}");
            Console.WriteLine($"City : {this.cityname}");
            Console.WriteLine($"State : {this.state}");
            Console.WriteLine($"ZipCode : {this.zipcode}");
        }
        public void Editted_Contact(List<AddressBook> contact, string name)
        {
            int flag = 0, n, found = 0;
            for (int i = 0; i < contact.Count; i++)
            {
                if (contact[i].firstname == name)
                {
                    found = 1;
                    contact[i].Display_details();
                    Console.WriteLine();
                    do
                    {
                        Console.WriteLine("Enter the option to edit : ");
                        Console.WriteLine("1. First Name\n2. Last Name\n3. Phone Number\n4. Email\n5. Address\n6. City\n7. State\n8. ZipCode\n9. Done\n");
                        n = Convert.ToInt32(Console.ReadLine());
                        switch (n)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("Enter the New First Name : ");
                                contact[i].firstname = Console.ReadLine();
                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine("Enter the New Last Name : ");
                                contact[i].lastname = Console.ReadLine();
                                break;
                            case 3:
                                Console.Clear();
                                Console.WriteLine("Enter the New Phone Number : ");
                                contact[i].phonenumber = Convert.ToInt64(Console.ReadLine());
                                break;
                            case 4:
                                Console.Clear();
                                Console.WriteLine("Enter the New Email : ");
                                contact[i].email = Console.ReadLine();
                                break;
                            case 5:
                                Console.Clear();
                                Console.WriteLine("Enter the New Address : ");
                                contact[i].address = Console.ReadLine();
                                break;
                            case 6:
                                Console.Clear();
                                Console.WriteLine("Enter the New City : ");
                                contact[i].cityname = Console.ReadLine();
                                break;
                            case 7:
                                Console.Clear();
                                Console.WriteLine("Enter the New State : ");
                                contact[i].state = Console.ReadLine();
                                break;
                            case 8:
                                Console.Clear();
                                Console.WriteLine("Enter the New ZipCode : ");
                                contact[i].zipcode = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 9:
                                Console.WriteLine("Edited..");
                                flag = 1;
                                break;
                        }
                        Console.Clear();
                        Console.WriteLine();
                    } while (flag == 0);

                }
            }
            if (found == 0)
            {
                Console.WriteLine("The Given Name is not there in the contact list");
                Thread.Sleep(2000);
            }
        }



        public void Delete(List<AddressBook> contact, string name)
        {
            int found = 0;
            for (int i = 0; i < contact.Count; i++)
            {
                if (contact[i].firstname == name)
                {
                    found = 1;
                    Console.WriteLine($"Are you sure of deleteing {name}\'s contact (Y/N)");
                    char ch = Convert.ToChar(Console.ReadLine());
                    if (ch == 'Y' || ch == 'y')
                    {
                        contact.Remove(contact[i]);
                        Console.WriteLine("Contact is Deleted ...");
                        Thread.Sleep(2000);
                    }
                    else
                    {
                        Console.WriteLine("Contact Not Deleted");
                        Thread.Sleep(2000);
                    }
                }
                if (found == 0)
                {
                    Console.WriteLine($"The contact with the name '{name}' is not found in the contact list.");
                    Thread.Sleep(2000);
                }
            }
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            List<AddressBook> list = new List<AddressBook>();
            AddressBook obj1 = new AddressBook();
            int flag = 0;
            do
            {
                Console.WriteLine("Enter an Option to perform : ");
                Console.WriteLine("1. Add Details\n2. Display Details\n3. Edit a Contact\n4. Delete a Contact\n5. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Add details:\n");
                        AddressBook address = new AddressBook();
                        address.Add_details();
                        list.Add(address);
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Display Details\n");
                        for (int i = 0; i < list.Count; i++)
                        {
                            list[i].Display_details();
                            Console.WriteLine();
                        }
                        Thread.Sleep(2000);
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Enter name for edit the details\n");
                        string name = Console.ReadLine();
                        obj1.Editted_Contact(list, name);
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Enter name for deleting the contact\n");
                        string deleteName = Console.ReadLine();
                        obj1.Delete(list, deleteName);
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Exited");
                        flag = 1;
                        break;
                }
                Console.Clear();
            } while (flag == 0);
        }
    }
}