using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workshop.main.Vehicles.Interfaces;

namespace workshop.main.Vehicles.Abstract
{
    public abstract class Vehicle 
    {
        private IPerson _person;
        public Vehicle(IPerson driver)
        {
            _person = driver;
        }
        private bool _moving = false;
        public string Description { get; set; }
        public virtual bool Go()
        {
            _moving = true;
            return true;
        }
        public virtual bool Stop()
        {
            if (_moving)
            {
                _moving = false;
                return true;
            }
            return false;
        }
        public int People { get; set; } = 1;
        public string Driver => _person.Name;
     
    }
}
