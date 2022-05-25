using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace StudentWebApp.Helper
{
    public class StudentAPI
    {
        public HttpClient Initial()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44344/");
            return client;
        }
    }
}
