using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DotNetCoreSqlDb.Models;


namespace DotNetCoreSqlDb.Controllers
{
    public class HomeController : Controller
    {
        //private readonly IQueueCommunicator _queueCommunicator;
        //private readonly IStorageService _azureBlobStorageService;
        public HomeController(/*IQueueCommunicator queueCommunicator, IStorageService azureBlobStorageService*/)
        {
            //_queueCommunicator = queueCommunicator;
            //_azureBlobStorageService = azureBlobStorageService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            ViewBag.Message = "";
            return View();
        }
        //public async Task<ActionResult> FileUpload()
        //{
        //    try
        //    {
        //        StorageCommand command = new StorageCommand()
        //        {
        //            Route = BlobContainer.FileContainer,
        //            SubRoute = "Ashis/Appointment/",
        //            StorageType = (int)StorageTypeEnum.Blob
        //        };
        //        var allBlobs = await _azureBlobStorageService.ListAsync(command);
        //        return View(allBlobs);
        //    }
        //    catch (Exception ex)
        //    {
        //        ViewData["message"] = ex.Message;
        //        ViewData["trace"] = ex.StackTrace;
        //        return View("Error");
        //    }
        //}

        //[HttpPost]
        //public async Task<IActionResult> ContactUs(string contactName, string emailAddress)
        //{
        //    var thankYouEmail = new SendEmailCommand()
        //    {
        //        To = emailAddress,
        //        Subject = "Thank you for reaching out",
        //        Body = "We will contact you shortly"
        //    };
        //    await _queueCommunicator.SendAsync(thankYouEmail);
        //    var thankYouSMS = new SendSMSCommand()
        //    {
        //        To = "917008693982",
        //        Subject = "COVID-19",
        //        Body = "Stay at Home and Stay safe"
        //    };
        //    await _queueCommunicator.SendAsync(thankYouSMS);
        //    var adminEmail = new SendEmailCommand()
        //    {
        //        To = "ashis.mahapatra@cai.io",
        //        Subject = "New Contact",
        //        Body = $"{contactName} has reached out via contact form. Please respond back at {emailAddress}"
        //    };
        //    await _queueCommunicator.SendAsync(adminEmail);
        //    ViewBag.Message = "Thank you we've received your message =)";
        //    return View();
        //}


        //[HttpPost]
        //public async Task<ActionResult> UploadAsync()
        //{
        //    try
        //    {
        //        var request = await HttpContext.Request.ReadFormAsync();
        //        if (request.Files == null)
        //        {
        //            return BadRequest("Could not upload files");
        //        }
        //        var files = request.Files;
        //        if (files.Count == 0)
        //        {
        //            return BadRequest("Could not upload empty files");
        //        }
        //        StorageCommand command = new StorageCommand()
        //        {
        //            Files = files,
        //            Route = BlobContainer.FileContainer,
        //            SubRoute = "Ashis/Appointment/",
        //            StorageType= (int)StorageTypeEnum.Blob
        //        };
        //        await _azureBlobStorageService.UploadAsync(command);
        //        return RedirectToAction("Index");
        //    }
        //    catch (Exception ex)
        //    {
        //        ViewData["message"] = ex.Message;
        //        ViewData["trace"] = ex.StackTrace;
        //        return View("Error");
        //    }
        //}

        //[HttpPost]
        //public async Task<ActionResult> DeleteImage(string fileUri)
        //{
        //    try
        //    {
        //        StorageCommand command = new StorageCommand()
        //        {
        //            FileUri = fileUri,
        //            Route = BlobContainer.FileContainer,
        //            SubRoute = "Ashis/Appointment/",
        //            StorageType = (int)StorageTypeEnum.Blob
        //        };
        //        await _azureBlobStorageService.DeleteAsync(command);
        //        return RedirectToAction("Index");
        //    }
        //    catch (Exception ex)
        //    {
        //        ViewData["message"] = ex.Message;
        //        ViewData["trace"] = ex.StackTrace;
        //        return View("Error");
        //    }
        //}
        //public async Task<ActionResult> GetAllFiles()
        //{
        //    try
        //    {
        //        StorageCommand command = new StorageCommand()
        //        {
        //            Route = BlobContainer.FileContainer,
        //            SubRoute = "Ashis/Appointment/",
        //            StorageType = (int)StorageTypeEnum.Blob
        //        };
        //        var allBlobs = await _azureBlobStorageService.ListAsync(command);
        //        return View(allBlobs);
        //    }
        //    catch (Exception ex)
        //    {
        //        ViewData["message"] = ex.Message;
        //        ViewData["trace"] = ex.StackTrace;
        //        return View("Error");
        //    }
        //}
        //[HttpPost]
        //public async Task<ActionResult> DeleteAll()
        //{
        //    try
        //    {
        //        StorageCommand command = new StorageCommand()
        //        {
        //            Route = BlobContainer.FileContainer,
        //            SubRoute = "Ashis/Appointment/",
        //            StorageType = (int)StorageTypeEnum.Blob
        //        };
        //        await _azureBlobStorageService.DeleteAllAsync(command);
        //        return RedirectToAction("Index");
        //    }
        //    catch (Exception ex)
        //    {
        //        ViewData["message"] = ex.Message;
        //        ViewData["trace"] = ex.StackTrace;
        //        return View("Error");
        //    }
        //}


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
