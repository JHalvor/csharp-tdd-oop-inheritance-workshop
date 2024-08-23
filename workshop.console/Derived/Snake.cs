using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workshop.console.Base;
using workshop.console.Interfaces;

namespace workshop.console.Derived
{
    public class Bread : Product, IPerishable
    {
        public DateTime SellByDate {get;set;}
        public DateTime BestBefore { get; set; }
    }
}
