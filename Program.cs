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
        }
    }
}
