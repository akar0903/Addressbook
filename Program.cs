using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace address
{
    internal class Program
    {
        class book
        {
            public string firstname;
            public string lastname;
            public string city;
            public string state;
            public long number;
            public int zip;
            public string email;
            public void Setfirstname(string fname)
            {
                firstname = fname;
            }
            public void Setlastname(string lname) 
            {
                    lastname = lname;    
            }
            public void Setcity(string scity)
            {
                city = scity;
            }
            public void Setstate(string sstate)
            {
                state = sstate;
            }
            public void Setnumber(long nnumber)
            {
                number = nnumber;
            }
            public void Setzip(int zzip)
            {
                zip = zzip;
            }
            public void Setemail(string eemail)
            {
                email = eemail;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to adress book");
            book mybook = new book();
            mybook.firstname = "Arun";
            mybook.lastname = "Karthik";
            mybook.email = "av0019@srmist.edu.in";
            mybook.zip = 600096;
            mybook.number = 9789894450;
            mybook.city = "Chennai";
            mybook.state = "Tamil Nadu";
            Console.WriteLine(mybook.firstname);
            Console.WriteLine(mybook.lastname);
            Console.WriteLine(mybook.email);
            Console.WriteLine(mybook.zip);
            Console.WriteLine(mybook.number);
            Console.WriteLine(mybook.city);
            Console.WriteLine(mybook.state);
            Console.ReadLine();
        }
    }
}
