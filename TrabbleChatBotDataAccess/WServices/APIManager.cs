using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Linq;

namespace TrabbleChatBotDataAccess.WServices
{
    public class APIManager
    {
        public async Task<T> LoadAPIResponse<T>(T dataObj, IEnumerable<string> parameterList, string url) where T : class
        {
            using (var httpClient = new HttpClient())
            {
                //TODO: Update for multiple params 
                using (var response = await httpClient.GetAsync(url + parameterList.ToList()[0]))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        dataObj = JsonSerializer.Deserialize<T>(apiResponse);
                    }
                    else
                    {
                        //Integrate logger for log response/Errors
                    }
                }
            }
            return dataObj;
        }

        public async Task<object> LoadDyanamicAPIResponse(IEnumerable<string> parameterList, string url) 
        {
            dynamic dataObj = new Object();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(url + parameterList.ToList()[0]))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        //dataObj = JsonSerializer.Deserialize<T>(apiResponse);
                        dataObj = JsonSerializer.Deserialize(apiResponse, typeof(object));
                    }
                    else
                    {
                        //Integrate logger for log response/Errors
                    }
                }
            }
            return dataObj;
        }
    }
}
