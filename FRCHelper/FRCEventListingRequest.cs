using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FRCHelper
{
    class FRCEventListingRequest
    {
        public int season { get; set; }
        public string eventCode { get; set; }
        public string districtCode { get; set; }
        public bool excludeDistrict { get; set; }

        public FRCEventListingRequest(int seasonYear)
        {
            this.season = seasonYear;
            this.eventCode = "";
            this.districtCode = "";
            this.excludeDistrict = false;
        }

        public FRCEventListingRequest(int seasonYear, string eventCode, string districtCode, bool excludeDistrict)
        {
            this.season = seasonYear;
            this.eventCode = eventCode;
            this.districtCode = districtCode;
            this.excludeDistrict = excludeDistrict;
        }

        /// <summary>
        /// Builds the HTTP request URL
        /// </summary>
        /// <returns>A string representing the request URL</returns>
        public string BuildUri()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Properties.Settings.Default.FrcApiUrl);
            sb.Append(season);
            sb.Append("/events?");
            if (eventCode != "")
            {
                sb.Append("eventCode=" + eventCode.ToUpper() );
            }
            if (districtCode != "")
            {
                sb.Append("&districtCode=" + districtCode.ToUpper());
            }
            if (excludeDistrict)
            {
                sb.Append("&excludeDistrict=" + excludeDistrict.ToString().ToLower());
            }

            string url = sb.ToString();
            return url;
        }

        
    }
}
