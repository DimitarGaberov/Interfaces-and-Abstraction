using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface ICitizen : IIdentifiable
{
    string Name { get; }
    int Age { get; }
}
