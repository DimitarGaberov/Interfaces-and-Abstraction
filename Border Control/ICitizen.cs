﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface ICitizen : IIdentifiable, IBirthable
{
    string Name { get; }
    int Age { get; }
}
