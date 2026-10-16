namespace MusorEfCodeFirst;

class Program
{
    static void Main(string[] args)
    {
        var db = new MyDbContext();
        db.SaveChanges();
        Console.WriteLine("Hello, World!");
    }
}