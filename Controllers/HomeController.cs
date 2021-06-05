﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision;
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using WebApplicationOCR.Models;
using static System.Net.Mime.MediaTypeNames;

namespace WebApplicationOCR.Controllers
{
    public class ImageData
    {
        public string baseImg  { get; set; }
    }
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        [RequestSizeLimit(400000000)]
        public async Task<IActionResult> GetImageAsync(string baseImg)
        {

            var dat = baseImg;

            byte[] imageBytes = Convert.FromBase64String(encodedString);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);

            var READ_TEXT_URL_IMAGE = $"https://res.cloudinary.com/abvideo/image/upload/v1622842673/rccg_-_Adeleke_Ibrahim_wbavuv.jpg";
            //var READ_TEXT_URL_IMAGE = $"https://res.cloudinary.com/abvideo/image/upload/v1622843912/IMG_20180925_122845_-_Adewale_seyi_kclvv2.jpg";
           // var READ_TEXT_URL_IMAGE = $"https://res.cloudinary.com/abvideo/image/upload/v1622882401/DSC_0257_-_ladi_folarin_yrkuyy.jpg"; bad image

            string subscriptionKey = "2119afa6fe9d45b89ad77e4184901a18";
            string endpoint = "https://ocrhermestest.cognitiveservices.azure.com/";

            ComputerVisionClient client = Authenticate(endpoint, subscriptionKey);
            List<string> res = await ReadFileUrl(client, ms);

            return Ok(res);

        }
        private ComputerVisionClient Authenticate(string endpoint, string key)
        {
            ComputerVisionClient client =
              new ComputerVisionClient(new ApiKeyServiceClientCredentials(key))
              { Endpoint = endpoint };
            return client;
        }

        private async Task<List<string>> ReadFileUrl(ComputerVisionClient client, MemoryStream urlFile)
        {
            List<string> getString = new List<string>();

            // Read text from URL
            var textHeaders = await client.ReadInStreamAsync(urlFile);
            // After the request, get the operation location (operation ID)
            string operationLocation = textHeaders.OperationLocation;
            Thread.Sleep(2000);
            // </snippet_readfileurl_1>

            // <snippet_readfileurl_2>
            // Retrieve the URI where the extracted text will be stored from the Operation-Location header.
            // We only need the ID and not the full URL
            const int numberOfCharsInOperationId = 36;
            string operationId = operationLocation.Substring(operationLocation.Length - numberOfCharsInOperationId);

            // Extract the text
            ReadOperationResult results;
            // Console.WriteLine($"Extracting text from URL file {Path.GetFileName(urlFile)}...");
            Console.WriteLine();
            do
            {
                results = await client.GetReadResultAsync(Guid.Parse(operationId));
            }
            while ((results.Status == OperationStatusCodes.Running ||
                results.Status == OperationStatusCodes.NotStarted));
            // </snippet_readfileurl_2>

            // <snippet_readfileurl_3>
            // Display the found text.
            Console.WriteLine();
            var textUrlFileResults = results.AnalyzeResult.ReadResults;
            foreach (ReadResult page in textUrlFileResults)
            {
                foreach (Line line in page.Lines)
                {
                    getString.Add(line.Text);
                }
            }
            return getString;
        }

    }
}