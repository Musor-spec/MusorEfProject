using MusorEfCodeFirst.Models;

namespace MusorEfCodeFirst;

class Program
{
    static void Main(string[] args)
    {
        var db = new MyDbContext();
        var role = new Role { RoleName = "Посетитель" };
        var guest = new Guest
        {
            FirstName = "Валерий",
            LastName = "Капустин",
            Email = "bla-bla-bla@inbox.ru",
            Role = role,
        };
        db.Guests.Add(guest);
        db.SaveChanges();
        Console.WriteLine("Сделано");
    }
}