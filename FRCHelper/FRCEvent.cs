using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRCHelper
{
    class FRCEvent
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string districtCode { get; set; }
        public string venue { get; set; }
        public string location { get; set; }
        public string dateStart { get; set; }
        public string dateEnd { get; set; }

        public FRCEvent() { }
    }
}
