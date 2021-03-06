﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MyPLEX.Models;
using MyPLEX.Models.JSONs;
using Newtonsoft.Json;
using RestSharp;
using System.Diagnostics;

namespace MyPLEX.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public readonly AppSettings.Plex _plexConfig;

        public HomeController(
            IOptions<AppSettings.Plex> plexConfig,
            ILogger<HomeController> logger)
        {
            _plexConfig = plexConfig.Value;
            _logger = logger;
        }


        public IActionResult Index()
        {
            ViewBag.Client = _plexConfig.Url;
            ViewBag.Token = _plexConfig.Token;

            return View(new ConfigVisualizacao());
        }

        public IActionResult Visualizador(ConfigVisualizacao model)
        {
            ViewBag.Client = _plexConfig.Url;
            ViewBag.Token = _plexConfig.Token;
            ViewBag.Config = model;

            return View(Get(model.Section));
        }

        public Root Get(int? section)
        {
            var dataPlex = new Root();

            var client = new RestClient(_plexConfig.Url);
            var request = new RestRequest($"/library/sections/{section}/all?X-Plex-Token=" + _plexConfig.Token, Method.GET);
            request.RequestFormat = DataFormat.Xml;

            IRestResponse response = client.Execute(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
                return null;

            dataPlex = JsonConvert.DeserializeObject<Root>(response.Content);

            return dataPlex;
        }

        public IActionResult Test()
        {
            return Ok(new
            {
                Client = _plexConfig.Url,
                Token = _plexConfig.Token,
                Url = _plexConfig.Url + "/library/sections/1/all?X-Plex-Token=" + _plexConfig.Token,
                Data = Get(1)
            });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
