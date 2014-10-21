using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FRCHelper
{
    class GsFrcApiCommunicator
    {
        public FRCEventListingResponse getEventListing(int season, string eventCode, string districtCode, bool excludeDistrict)
        {
            FRCEventListingRequest request = new FRCEventListingRequest(season, eventCode, districtCode, excludeDistrict);

            string response = SendAndGetRawResponse(request.BuildUri());

            FRCEventListingResponse eventListingResponse = JsonConvert.DeserializeObject<FRCEventListingResponse>(response);

            return eventListingResponse;
        }

        public FRCEventListingResponse getEventListing(int season)
        {
            FRCEventListingRequest request = new FRCEventListingRequest(season);

            string response = SendAndGetRawResponse(request.BuildUri());

            FRCEventListingResponse eventListingResponse = JsonConvert.DeserializeObject<FRCEventListingResponse>(response);

            return eventListingResponse;
        }

        public FRCTeamListingResponse getTeamListing(int season, string eventCode)
        {
            FRCTeamListingRequest request = new FRCTeamListingRequest(season, eventCode);

            string response = SendAndGetRawResponse(request.BuildUri());

            FRCTeamListingResponse teamListingResponse = JsonConvert.DeserializeObject<FRCTeamListingResponse>(response);

            return teamListingResponse;
        }

        public FRCTeamListingResponse getTeamListing(int season, int teamNumber)
        {
            FRCTeamListingRequest request = new FRCTeamListingRequest(season, teamNumber);

            string response = SendAndGetRawResponse(request.BuildUri());

            FRCTeamListingResponse teamListingResponse = JsonConvert.DeserializeObject<FRCTeamListingResponse>(response);

            return teamListingResponse;
        }

        public string SendAndGetRawResponse(string uri)
        {
            var request = System.Net.WebRequest.Create(uri) as System.Net.HttpWebRequest;
            request.KeepAlive = true;

            request.Headers.Add("Authorization: Token communitysampletoken");

            request.Method = "GET";

            request.Accept = "application/json";
            request.ContentLength = 0;

            string responseContent = null;

            using (var response = request.GetResponse() as System.Net.HttpWebResponse)
            {
                using (var reader = new System.IO.StreamReader(response.GetResponseStream()))
                {
                    responseContent = reader.ReadToEnd();
                }
            }

            return responseContent;
        }
    }
}
