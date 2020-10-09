using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesLibrary;
namespace TesterProgram
{
    class Tester
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-=-=Student=-=-\n");
           
            Student student1 = new Student();
            student1.FirstName = "Mike";
            student1.LastName = "Johnson";
            student1.Id = "MikeJ15";
            student1.GPA = 3.8f;
            Console.WriteLine(student1);

            Student student2 = new Student("Mike", "Johnson", "MikeJ15", 3.8f);
            Console.WriteLine(student2);

            Console.WriteLine();
            Console.WriteLine("-=-=Vehicle=-=-\n");
            Vehicle fusion1 = new Vehicle();
            fusion1.Make = "Ford";
            fusion1.Model = "Fusion";
            fusion1.Year = 2008;
            fusion1.Weight = 2.3f;
            Console.WriteLine(fusion1);

            Vehicle fusion2 = new Vehicle("Ford", "Fusion", 2008, 2.3f);
            Console.WriteLine(fusion2);

            Console.WriteLine();
            Console.WriteLine("-=-=Login=-=-\n");
            Login login1 = new Login();
            login1.UserName = "Spongebob";
            login1.Password = "Pinapple";
            Console.WriteLine(login1);

            Login login2 = new Login("Spongebob", "Pinapple");
            Console.WriteLine(login2);

            Console.WriteLine();
            Console.WriteLine("-=-=Contact Info=-=-\n");

            ContactInfo p1 = new ContactInfo();
            p1.StreetAddress = "123 jefferson street";
            p1.City = "Kansas City";
            p1.State = "Missouri";
            p1.Zip = "12345";
            p1.Phone = "816 222 3333";
            p1.Email = "MikeJ@gmail.com";

            Console.WriteLine(p1);
            Console.WriteLine();
            ContactInfo p2 = new ContactInfo("123 jefferson street", "Kansas City", "Missouri", "12345", "816 222 3333", "MikeH@Gmail.com");
            Console.WriteLine(p2);

            Console.WriteLine();
            Console.WriteLine("-=-=Customer=-=-\n");
            Customer c1 = new Customer();
            c1.CustomerId = "MikeH123";
            c1.FirstName = "Mike";
            c1.LastName = "Johnson";
            c1.ContactInformation = p2;
            Console.WriteLine(c1);
            Console.WriteLine();
            Customer c2 = new Customer("MikeH123", "Mike", "Johnson", p2);
            Console.WriteLine(c2);

            Console.WriteLine();
            Console.WriteLine("-=-=Credit Card Account=-=-\n");
            CreditCardAccount g1 = new CreditCardAccount();
            g1.AccountNumber = 12345;
            g1.CustomerInfo = c2;
            g1.Balance = 235.84m;
            g1.IsPastDue = false;
            g1.AnnualInterestRate = .02m;
            Console.WriteLine(g1);
            Console.WriteLine();

            CreditCardAccount g2 = new CreditCardAccount(12345, c2, 235.84m, false, 0.02m);
            Console.WriteLine(g2);

            Console.WriteLine();
            Console.WriteLine("-=-=Book=-=-\n");

            Book bk1 = new Book();
            bk1.Title = "Brave New World";
            bk1.Author = "Aldous Huxley";
            bk1.NbrOfPages = 268;
            Console.WriteLine(bk1);

            Book bk2 = new Book("Where the Wild Things Are", "Maurice Sendak", 43);
            Console.WriteLine(bk2);

            Console.WriteLine();
            Console.WriteLine("-=-=Library=-=-\n");

            List<Book> allBooks = new List<Book>() { bk1, bk2 };
                
            Library l1 = new Library();
            l1.BookList = allBooks;
            l1.LibraryName = "Mid-Continent Library";
            l1.StreetAddress = "15 SW Reading St";
            l1.City = "Page";
            l1.State = "Kansas";
            l1.Zip = "15345";
            Console.WriteLine(l1);

            Console.WriteLine();
            Library l2 = new Library(allBooks, "Mid-Continent Library", "15 SW Reading St", "Page", "Kansas", "15345");
            Console.WriteLine(l2);

            Console.WriteLine();
            Console.WriteLine("-=-=Song=-=-\n");

            Song song1 = new Song();
            song1.Artist = "Misfits";
            song1.Title = "Saturday Night";
            song1.LengthInSeconds = 207;
            Console.WriteLine(song1);

            Song song2 = new Song("Misfits", "Helena", 248);
            Console.WriteLine(song2);

            Console.WriteLine();
            Console.WriteLine("-=-=Artist=-=-\n");

            Song[] songs = new Song[2];
            songs[0] = song1;
            songs[1] = song2;


            Artist a1 = new Artist();
            a1.Tracks = songs;
            a1.Title = "Famous Monsters";
            a1.Genre = "Horror Punk";
            Console.WriteLine(a1);

            Artist a2 = new Artist(songs, "Famous Monsters", "Horror Punk");
            Console.WriteLine(a2);

            Console.WriteLine();
            Console.WriteLine("-=-=Motor Home=-=-\n");

            MotorHome h1 = new MotorHome();
            h1.Make = "Thor";
            h1.Model = "Hurricane";
            h1.Year = 2020;
            h1.Weight = 1.3f;
            h1.NumberOfBeds = 6;
            Console.WriteLine(h1);

            Console.WriteLine();

            MotorHome h2 = new MotorHome("Thor", "Daybreak", 2021, 1.5f, 5);
            Console.WriteLine(h2);

            Console.WriteLine();
            Console.WriteLine("-=-=Truck=-=-\n");

            Truck t1 = new Truck();
            t1.Make = "Chevrolet";
            t1.Model = "Silverado";
            t1.Year = 2020;
            t1.Weight = 2.3f;
            t1.LoadCapacityLbs = 9400f;
            Console.WriteLine(t1);

            Truck t2 = new Truck("Chevrolet", "Silverado 3500", 2020, 2.6f, 11290f);
            Console.WriteLine(t2);



                
            


            





        }
    }
}
