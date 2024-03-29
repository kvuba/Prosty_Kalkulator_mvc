﻿using Kalkulator.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Kalkulator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Calculator(Dane dane)
        {


            switch (dane.Znak)
            {
                case '+':
                    ViewBag.wynik = dane.Pierwsza_liczba + dane.Druga_liczba;
                    break;
                case '-':
                    ViewBag.wynik = dane.Pierwsza_liczba - dane.Druga_liczba;
                    break;
                case '*':
                    ViewBag.wynik = dane.Pierwsza_liczba * dane.Druga_liczba;
                    break;
                case '/':
                    ViewBag.wynik = dane.Pierwsza_liczba / dane.Druga_liczba;
                    break;
            }
            return View();

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}