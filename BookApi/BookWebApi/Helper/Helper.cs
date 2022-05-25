using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BookWebApi.Helper
{
        public class BookAPI
        {
            public HttpClient Initial()
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:44308/");
                return client;
            }
        }
}
