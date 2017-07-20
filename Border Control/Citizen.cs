using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Citizen : ICitizen, IIdentifiable, IBirthable, IBuyer
{
    private string name;
    private int age;
    private string id;
    private string birthdate;
    private int food;

    public Citizen(string name, int age, string id, string birthdate)
    {
        this.Name = name;
        this.Age = age;
        this.Id = id;
        this.Birthdate = birthdate;
        this.Food = 0;
    }

    public string Name
    {
        get { return this.name; }
        private set { this.name = value; }
    }

    public int Age
    {
        get { return this.age; }
        private set { this.age = value; }
    }

    public string Id
    {
        get { return this.id; }
        private set { this.id = value; }
    }

    public string Birthdate
    {
        get { return this.birthdate; }
        private set { this.birthdate = value; }
    }

    public int Food
    {
        get { return this.food; }
        set { this.food = value; }
    }

    public void BuyFood()
    {
        this.Food += 10;
    }
}
