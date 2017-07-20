using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main(string[] args)
    {
        List<ICitizen> citizens = new List<ICitizen>();
        List<IRobot> robots = new List<IRobot>();
        List<IPet> pets = new List<IPet>();
        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            var inputArgs = input.Split(' ').ToArray();

            if (inputArgs[0] == "Citizen")
            {
                string name = inputArgs[1];
                int age = int.Parse(inputArgs[2]);
                string id = inputArgs[3];
                string birthdate = inputArgs[4];
                ICitizen citizen = new Citizen(name, age, id, birthdate);
                citizens.Add(citizen);
            }
            else if (inputArgs[0] == "Robot")
            {
                string model = inputArgs[1];
                string id = inputArgs[2];
                IRobot robot = new Robot(model, id);
                robots.Add(robot);
            }
            else
            {
                string name = inputArgs[1];
                string birthdate = inputArgs[2];
                IPet pet = new Pet(name, birthdate);
                pets.Add(pet);
            }
        }

        string year = Console.ReadLine();

        foreach (var citizen in citizens)
        {
            if (citizen.Birthdate.Split('/').Last() == year)
            {
                Console.WriteLine(citizen.Birthdate);
            }
        }

        foreach (var pet in pets)
        {
            if (pet.Birthdate.Split('/').Last() == year)
            {
                Console.WriteLine(pet.Birthdate);
            }
        }
    }
}
