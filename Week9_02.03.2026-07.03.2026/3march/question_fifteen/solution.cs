using System;

abstract class User
{
    protected string name;
    protected string email;

    public User(string name, string email)
    {
        this.name = name;
        this.email = email;
    }

    public abstract string GetRole();
    public abstract void PerformAction();
}

class AdminUser : User
{
    public AdminUser(string name, string email)
        : base(name, email) { }

    public override string GetRole()
    {
        return "Admin";
    }

    public override void PerformAction()
    {
        Console.WriteLine($"{name} can manage system settings.");
    }
}

class RegularUser : User
{
    public RegularUser(string name, string email)
        : base(name, email) { }

    public override string GetRole()
    {
        return "Regular User";
    }

    public override void PerformAction()
    {
        Console.WriteLine($"{name} can browse content.");
    }
}

class Program
{
    static void Main()
    {
        User u1 = new AdminUser("Alice", "alice@mail.com");
        User u2 = new RegularUser("Bob", "bob@mail.com");

        Console.WriteLine($"{u1.GetRole()} - {u1.GetType().Name}");
        u1.PerformAction();

        Console.WriteLine($"{u2.GetRole()} - {u2.GetType().Name}");
        u2.PerformAction();
    }
}