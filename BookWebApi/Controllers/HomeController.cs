using BookWebApi.Helper;
using BookWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BookWebApi.Controllers
{
    public class HomeController : Controller
    {
        BookAPI _api = new BookAPI();
        public async Task<IActionResult> Index()
        {
            List<BookData> Books = new List<BookData>();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync("api/Book");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                Books = JsonConvert.DeserializeObject<List<BookData>>(results);
            }
            return View(Books);


        }
        public async Task<IActionResult> Details(int Id)
        {
            BookData book = await GetBookById(Id);
            return View(book);
        }

        private async Task<BookData> GetBookById(int Id)
        {
            BookData book = new BookData();
            HttpClient client = _api.Initial();

            HttpResponseMessage res = await client.GetAsync($"api/Book/{Id}");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                book = JsonConvert.DeserializeObject<BookData>(results);

            }

            return book;
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(BookData book)
        {
            HttpClient client = _api.Initial();

            //http post
            var postTask = client.PostAsJsonAsync<BookData>("api/Book/", book);
            postTask.Wait();


            var result = postTask.Result;
            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");

            }
            return View();
        }


        public async Task<IActionResult> Delete(int Id)
        {
            BookData book = new BookData();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.DeleteAsync($"api/Book?id="+Id);
            if (res.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();



        }
        [HttpGet]
        public async Task<IActionResult> Edit(int Id)
        {
            BookData book = await GetBookById(Id);
            return View(book);

        }
        [HttpPost]
        public async Task<IActionResult> Edit(BookData bookdata)
        {
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.PutAsJsonAsync($"api/Book?Id=" + bookdata.Id, bookdata);
            if (res.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
