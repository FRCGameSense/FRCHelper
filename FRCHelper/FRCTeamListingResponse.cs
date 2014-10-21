using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRCHelper
{
    class FRCTeamListingResponse
    {
        public List<FRCTeam> teams { get; set; }
        public int teamCountTotal { get; set; }
        public int teamCountPage { get; set; }
        public int pageCurrent { get; set; }
        public int pageTotal { get; set; }

        public FRCTeamListingResponse() { }
    }
}
