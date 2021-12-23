﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebProje2.Models;

namespace WebProje2.Controllers
{
    public class MesajController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> son()
        {
            ApiSon reservationList = new ApiSon();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://api.genelpara.com/embed/doviz.json"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    reservationList = JsonConvert.DeserializeObject<ApiSon>(apiResponse.ToString());
                }
            }
            return View(reservationList);
        }

    }
}
