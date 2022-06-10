using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RestDemo
{
    class MyRestClient
    {
        // Pro Endpoint Aufruf 1 public Methode
        // parameter mitgeben
        // keine return werte

        public string BaseURL { get; set; }

        public async void GetSingleUser(int userId){
            var client = new RestClient(BaseURL);
            var request = new RestRequest("api/users/2", Method.Get);
            var queryResult = client.GetAsync(request,CancellationToken.None);

            Console.WriteLine(queryResult.Result.Content);
        }

        public async void GetAllUser(int userId)
        {
            var client = new RestClient(BaseURL);
            var request = new RestRequest("api/users/", Method.Get);
            var queryResult = client.GetAsync(request, CancellationToken.None);

            Console.WriteLine(queryResult.Result.Content);
        }



    }
}
