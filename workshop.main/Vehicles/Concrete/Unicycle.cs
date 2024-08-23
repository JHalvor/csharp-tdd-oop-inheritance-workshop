﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workshop.main.Vehicles.Abstract;
using workshop.main.Vehicles.Interfaces;

namespace workshop.main.Vehicles.Concrete
{
    public class Unicycle : Vehicle
    {
        public Unicycle(IPerson person) : base(person)
        {
        }
    }
}
