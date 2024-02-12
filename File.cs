using System;
using System.Collections.Generic;
using System.IO;

namespace Address_Book_System
{
    class FileIO
    {
        public static void WriteToFile(string fileName, List<Contact> contacts)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(@"C:\Users\user\Documents\contacts.txt"))
                {
                    foreach (var contact in contacts)
                    {
                        writer.WriteLine($"First Name: {contact.Firstname}");
                        writer.WriteLine($"Last Name: {contact.Lastname}");
                        writer.WriteLine($"Address: {contact.Address}");
                        writer.WriteLine($"City: {contact.City}");
                        writer.WriteLine($"State: {contact.State}");
                        writer.WriteLine($"Phone: {contact.Phonenumber}");
                        writer.WriteLine($"Email: {contact.Email}");
                        writer.WriteLine($"Zipcode: {contact.Zipcode}");
                        writer.WriteLine();
                    }
                }
                Console.WriteLine("Contacts written to file successfully.");
            }
            catch (IOException e)
            {
                Console.WriteLine($"An error occurred while writing to the file: {e.Message}");
            }
        }

        public static List<Contact> ReadFromFile(string fileName)
        {
            List<Contact> contacts = new List<Contact>();
            try
            {
                using (StreamReader reader = new StreamReader(@"C:\Users\user\Documents\contacts.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Contact contact = new Contact();
                        contact.Firstname = GetValueFromLine(line);
                        contact.Lastname = GetValueFromLine(reader.ReadLine());
                        contact.Address = GetValueFromLine(reader.ReadLine());
                        contact.City = GetValueFromLine(reader.ReadLine());
                        contact.State = GetValueFromLine(reader.ReadLine());
                        contact.Phonenumber = GetValueFromLine(reader.ReadLine());
                        contact.Email = GetValueFromLine(reader.ReadLine());
                        contact.Zipcode = Convert.ToInt64(GetValueFromLine(reader.ReadLine()));

                        
                        reader.ReadLine();

                        contacts.Add(contact);
                    }
                }
                Console.WriteLine("Contacts read from file successfully.");
            }
            catch (IOException e)
            {
                Console.WriteLine($"An error occurred while reading from the file: {e.Message}");
            }
            return contacts;
        }

        private static string GetValueFromLine(string line)
        {
            string[] parts = line.Split(':');
            return parts.Length > 1 ? parts[1].Trim() : "";
        }
    }
}
