using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortuna.Common.BusinessObjects
{
    class Traekning : BusinessObject
    {
        public int Periode { get; set; }
        public int? LodseddelNummer { get; set; }
        public decimal? Beloeb { get; set; }
    }
}
