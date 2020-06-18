using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using GraphQL;
using Newtonsoft.Json;
using Poc.GraphQL.Web.Extension;
using Poc.GraphQL.Web.Models;

namespace Poc.GraphQL.Web.Clients
{
    public class AirlineHttpClient
    {
        private readonly HttpClient _httpClient;

        public AirlineHttpClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<GraphQLResponse<dynamic>> GetAirlinesByReadAsStream(string query)
        {
            
            var response = await _httpClient.GetAsync($"?query={JsonConvert.DeserializeObject(query)}");
            
            GraphQLResponse<dynamic> result = null;
            
            if (response.IsSuccessStatusCode)
            {
                var usedMemory = new List<string> { $"Total Memory: {GC.GetTotalMemory(false):#,##0}" };

                var stringResult = await response.Content.ReadAsStreamAsync();
                result = stringResult.ReadAndDeserializeFromJson<GraphQLResponse<dynamic>>();

                usedMemory.Add($"Total Memory: {GC.GetTotalMemory(false):#,##0}");
            }

            return result;
        }

        public async Task<GraphQLResponse<dynamic>> GetAirlinesByReadAsString(string query)
        {
            
            var response = await _httpClient.GetAsync($"?query={JsonConvert.DeserializeObject(query)}");

            GraphQLResponse<dynamic> result = null;

            if (response.IsSuccessStatusCode)
            {
                var usedMemory = new List<string> { $"Total Memory: {GC.GetTotalMemory(false):#,##0}" };

                var stringResult = await response.Content.ReadAsStringAsync();
                result = Newtonsoft.Json.JsonConvert.DeserializeObject<GraphQLResponse<dynamic>>(stringResult);

                usedMemory.Add($"Total Memory: {GC.GetTotalMemory(false):#,##0}");
            }

            return result;
        }

        public async Task<Response<AirlinesContainer>> GetAirlines()
        {
            var response = await _httpClient.GetAsync(@"?query= 
            { airlines 
                { id name description numberOfPlanes } 
            }");
            var stringResult = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Response<AirlinesContainer>>(stringResult);
        }
    }
}
