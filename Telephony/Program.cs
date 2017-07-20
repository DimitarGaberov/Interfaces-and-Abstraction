using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main(string[] args)
    {
        Smartphone phone = new Smartphone("Samsung");
        var numbers = Console.ReadLine().Split(' ');
        foreach (var number in numbers)
        {
            Console.WriteLine(phone.Call(number));
        }
        
        var sites = Console.ReadLine().Split(' ');
        foreach (var site in sites)
        {
            Console.WriteLine(phone.Browse(site));
        }
    }
}
