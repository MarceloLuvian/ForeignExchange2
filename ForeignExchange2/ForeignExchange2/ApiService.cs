using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using ForeignExchange2.Models;
using Newtonsoft.Json;

namespace ForeignExchange2
{
    public class ApiService
    {
        //public async Response CheckConnection()
        //{
            
        //}

        public async Task<Response> GetList<T>(string urlBase, string controller)
        {

            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri(urlBase);
                var response = await client.GetAsync(controller);
                var result = await response.Content.ReadAsStringAsync();
                if (!response.IsSuccessStatusCode)
                {
                    return new Response
                    {
                        IsSuccess = false,
                        Message = result,
                    };
                }

                var list = JsonConvert.DeserializeObject<List<T>>(result);

                return new Response
                {
                    IsSuccess = true,
                    Result = list,
                };
            }
            catch (Exception ex)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = ex.Message,
                };
            }
        }
    }
}