using System;
namespace AddressBook
{
    internal class Program
    {
        class Book
        {
            public string FirstName;
            public string LastName;
            public string City;
            public string State;
            public long Number;
            public int Zip;
            public string Email;
            public Book(string fname, string lname, string scity, string sstate, long nnumber, int zzip, string eemail)
            {
                FirstName = fname;
                LastName = lname;
                City = scity;
                State = sstate;
                Number = nnumber;
                Zip = zzip;
                Email = eemail;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to address book");
           
            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            Console.Write("Enter Zip Code: ");
            int zip = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Phone Number: ");
            long number = Convert.ToInt64(Console.ReadLine());

            Console.Write("Enter City: ");
            string city = Console.ReadLine();

            Console.Write("Enter State: ");
            string state = Console.ReadLine();

            
            Book myBook = new Book(firstName, lastName, city, state, number, zip, email);

            
            Console.WriteLine("\nDetails entered:");
            Console.WriteLine($"First Name: {myBook.FirstName}");
            Console.WriteLine($"Last Name: {myBook.LastName}");
            Console.WriteLine($"Email: {myBook.Email}");
            Console.WriteLine($"Zip Code: {myBook.Zip}");
            Console.WriteLine($"Phone Number: {myBook.Number}");
            Console.WriteLine($"City: {myBook.City}");
            Console.WriteLine($"State: {myBook.State}");

            Console.ReadLine();
        }
    }
}
