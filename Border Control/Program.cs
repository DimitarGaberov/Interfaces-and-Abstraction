using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main(string[] args)
    {
        List<ICitizen> citizens = new List<ICitizen>();
        List<IRobot> robots = new List<IRobot>();
        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            var inputArgs = input.Split(' ').ToArray();

            if (inputArgs.Length == 3)
            {
                string name = inputArgs[0];
                int age = int.Parse(inputArgs[1]);
                string id = inputArgs[2];
                ICitizen citizen = new Citizen(name, age, id);
                citizens.Add(citizen);
            }
            else
            {
                string model = inputArgs[0];
                string id = inputArgs[1];
                IRobot robot = new Robot(model, id);
                robots.Add(robot);
            }
        }

        string IdEnd = Console.ReadLine();

        foreach (var citizen in citizens)
        {
            if (citizen.Id.EndsWith(IdEnd))
            {
                Console.WriteLine(citizen.Id);
            }
        }

        foreach (var robot in robots)
        {
            if (robot.Id.EndsWith(IdEnd))
            {
                Console.WriteLine(robot.Id);
            }
        }
    }
}
