using System.Security.Cryptography.X509Certificates;

namespace Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Person> persons = new List<Person>
            //{
            //new Person("Memmedeli", "Taghiyev", "Baki", 1200),
            //new Person("Akif", "Subhanov", "Rusiya", 800),
            //new Person("Davud", "Tagiyev", "Baki", 600),
            //new Person("Emil", "Vusalov", "Sumqayit",1500)
            //};
            //ShowPerson(persons,p => p.Salary > 1000 );

            //static void ShowPerson(List<Person> persons, Predicate<Person> predicate)
            //{
            //    foreach (var person in persons)
            //    {
            //        if (predicate(person))
            //        {
            //            Console.WriteLine($"Ad: {person.Name}, Soyad: {person.Surname}, Ünvan: {person.Adress}");
            //        }
            //    }
            //}

            List<Book> books = new List<Book>
            {
                new Book("Xosrov ve sirin ","Nizami"),
                new Book("sevgi","Albert"),
                new Book("Iskendername ","Nizami"),
                new Book("Tenha Baki ","Memmedeli"),
                new Book("Leyli ve mejnun ","Nizami")
            };

            int count = BookCount(books, b => b.Author == "Nizami");
            Console.WriteLine($"Nizaminin Kitab Sayi {count}");

            static int BookCount(List<Book>books,Predicate<Book> predicate)
            {
                int count = 0;
                foreach (Book book in books)
                    if (predicate(book))
                    {
                    count++;
                    }
                     return count;
            } 
        }
    }
}

