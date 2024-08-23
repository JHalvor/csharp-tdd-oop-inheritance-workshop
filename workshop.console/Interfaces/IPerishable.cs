using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop.console
{
    public interface IPerishable
    {
        DateTime SellByDate { get; set; }
        DateTime BestBefore { get; set; }
    }
}
