﻿using BharghavasPieShop.Models;
using BharghavasPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BharghavasPieShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;

        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        public IActionResult Index()
        {
            var piesOfTheWeek=_pieRepository.PiesOfTheWeek;
            var homeViewModel=new HomeViewModel(piesOfTheWeek);
            return View(homeViewModel);
        }
    }
}
