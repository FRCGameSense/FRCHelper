using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRCHelper
{
    class FRCTeamListingRequest
    {
        public int season { get; set; }
        public int teamNumber { get; set; }
        public string eventCode { get; set; }
        public string districtCode { get; set; }

        public FRCTeamListingRequest(int season, int teamNumber)
        {
            this.season = season;
            this.teamNumber = teamNumber;
            this.eventCode = null;
            this.districtCode = null;
        }

        public FRCTeamListingRequest(int season, string eventCode)
        {
            this.season = season;
            this.teamNumber = 0;
            this.eventCode = eventCode;
            this.districtCode = null;
        }

        public string BuildUri()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Properties.Settings.Default.FrcApiUrl);
            sb.Append(season);
            sb.Append("/teams?");
            if (teamNumber != 0)
            {             
                sb.Append("teamNumber=" + teamNumber);
            }
            else if (eventCode != null)
            {
                sb.Append("eventCode=" + eventCode.ToUpper());
                if (districtCode != null)
                {
                    sb.Append("&districtCode=" + districtCode.ToUpper());
                }
            }           

            string url = sb.ToString();
            return url;
        }
    }
}
