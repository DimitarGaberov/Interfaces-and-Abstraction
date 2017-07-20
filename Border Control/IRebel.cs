using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IRebel : IBuyer
{
    string Name { get; }
    int Age { get; }
    string Group { get; }
}
