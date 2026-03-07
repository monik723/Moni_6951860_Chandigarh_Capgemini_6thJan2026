using System;

public abstract class Employee
{
    protected string department;
    protected string name;
    protected string location;
    protected bool isOnVacation = false;

    public Employee(string department, string name, string location)
    {
        this.department = department;
        this.name = name;
        this.location = location;
    }

    public abstract string GetDepartment();
    public abstract string GetName();
    public abstract string GetLocation();
    public abstract bool GetStatus();
    public abstract void SwitchStatus();
}

class FinanceEmployee : Employee
{
    public FinanceEmployee(string dep, string name, string loc)
        : base(dep, name, loc) { }

    public override string GetDepartment() => department;
    public override string GetName() => name;
    public override string GetLocation() => location;
    public override bool GetStatus() => isOnVacation;

    public override void SwitchStatus()
    {
        isOnVacation = !isOnVacation;
    }
}

class MarketingEmployee : Employee
{
    public MarketingEmployee(string dep, string name, string loc)
        : base(dep, name, loc) { }

    public override string GetDepartment() => department;
    public override string GetName() => name;
    public override string GetLocation() => location;
    public override bool GetStatus() => isOnVacation;

    public override void SwitchStatus()
    {
        isOnVacation = !isOnVacation;
    }
}

class Program
{
    static void Main()
    {
        Employee finance = new FinanceEmployee("Finance", "John", "London");

        Console.WriteLine($"FinanceEmployee info: Department - {finance.GetDepartment()}, Name - {finance.GetName()}, Location - {finance.GetLocation()}");

        Console.WriteLine($"{finance.GetName()} is {(finance.GetStatus() ? "on" : "not on")} vacation");

        finance.SwitchStatus();
        Console.WriteLine($"{finance.GetName()} is {(finance.GetStatus() ? "on" : "not on")} vacation");

        Employee marketing = new MarketingEmployee("Marketing", "Anna", "New York");

        Console.WriteLine($"MarketingEmployee info: Department - {marketing.GetDepartment()}, Name - {marketing.GetName()}, Location - {marketing.GetLocation()}");
    }
}