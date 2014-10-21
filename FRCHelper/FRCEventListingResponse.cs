using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRCHelper
{
    class FRCEventListingResponse
    {
        public List<FRCEvent> Events { get; set; }
        public int eventCount { get; set; }

        public FRCEventListingResponse() { }

    }
}
