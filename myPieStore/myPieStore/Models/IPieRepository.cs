using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myPieStore.Models
{
    public interface IPieRepository
    {
        IEnumerable<Pie> AllPie { get; }
        IEnumerable<Pie> PieOfTheWeek { get; }
        Pie GetPieById(int pieId);

    }
}
