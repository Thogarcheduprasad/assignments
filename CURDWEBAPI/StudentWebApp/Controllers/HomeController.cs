using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using StudentWebApp.Helper;
using StudentWebApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace StudentWebApp.Controllers
{
    public class HomeController : Controller
    {
        StudentAPI _api = new StudentAPI();

        public async Task<IActionResult> Index()
        {
            List<StudentData> students = new List<StudentData>();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync("api/student");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                students = JsonConvert.DeserializeObject<List<StudentData>>(results);
            }
            return View(students);


        }
        public async Task<ActionResult> Details(int Id)
        {
            var student = new StudentData();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync($"api/student{Id}");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                student = JsonConvert.DeserializeObject<StudentData>(results);
            }
            return View(student);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(StudentData student)
        {
            HttpClient client = _api.Initial();

            //http post
            var postTask = client.PostAsJsonAsync<StudentData>("api/student", student);
            postTask.Wait();


            var result = postTask.Result;
            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");

            }
            return View();
        }

        public async Task<IActionResult> Delete(int id)
        {
            var student = new StudentData();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.DeleteAsync($"api/student/{id}");

            return RedirectToAction("Index");
        }


    }
}
