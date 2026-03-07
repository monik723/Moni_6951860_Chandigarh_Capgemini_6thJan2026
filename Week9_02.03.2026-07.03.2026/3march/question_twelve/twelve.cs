using System;
using System.Collections.Generic;
using System.Linq;

class User
{
    public int Id;
    public string Email;
}

static class UserManager
{
    public static (List<User> updated, List<User> inserted)
        CompareUsers(List<User> db, List<User> incoming)
    {
        var updated = new List<User>();
        var inserted = new List<User>();

        foreach (var u in incoming)
        {
            var existing = db.FirstOrDefault(x => x.Id == u.Id);

            if (existing != null)
                updated.Add(u);
            else
                inserted.Add(u);
        }

        return (updated, inserted);
    }
}

class Program
{
    static void Main()
    {
        var db = new List<User>
        {
            new User{Id=1,Email="a@mail.com"},
            new User{Id=2,Email="b@mail.com"}
        };

        var newUsers = new List<User>
        {
            new User{Id=2,Email="b@mail.com"},
            new User{Id=3,Email="c@mail.com"}
        };

        var result = UserManager.CompareUsers(db, newUsers);

        Console.WriteLine("Updated Users:" + result.updated.Count);
        Console.WriteLine("Inserted Users:" + result.inserted.Count);
    }
}