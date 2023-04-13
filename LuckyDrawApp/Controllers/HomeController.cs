using LuckyDrawApp.Models;
using LuckyDrawApp.Service.Abstraction;
using LuckyDrawApp.Service.Model.Request;
using LuckyDrawApp.Service.Model.Response;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace LuckyDrawApp.Controllers
{
    public class HomeController : Controller
    {
        private IHostingEnvironment _hostingEnvironment;
        private ILuckyDrawService _luckyDrawService;
        private readonly IConfiguration _configuration;
        public HomeController(ILuckyDrawService luckyDrawService, IConfiguration configuration, IHostingEnvironment hostingEnvironment)
        {
            _configuration = configuration;
            _luckyDrawService = luckyDrawService;
            _hostingEnvironment = hostingEnvironment;
        }
        public async Task<IActionResult> Index()
        {
            List<LuckyDrawResponse> response = new List<LuckyDrawResponse>();
            GetListYearRequest request = new GetListYearRequest();
            request.Year = DateTime.Now.Year.ToString();
            response = await _luckyDrawService.GetYearLuckyDraw(request);
            return View(response);
        }
        [HttpPost]
        public async Task<IActionResult> Index(string title, string description, string Month, string Year, IFormFile file, string CountNumber, string buttonName, string ID)
        {
           
            try
            {
                if(buttonName == "Save")
                {
                    LuckyDrawResponse response = new LuckyDrawResponse();
                    SaveRequest request = new SaveRequest();
                    request.Name = title;
                    request.Description = description;
                    request.DrawMonth = Month;
                    request.DrawYear = Year;
                    List<LuckyDrawPrizeRequest> luckyDrawPrizes = new List<LuckyDrawPrizeRequest>();
                    //uploads
                    string folderName = "UploadImg";
                    string webRootPath = _hostingEnvironment.WebRootPath;
                    string newPath = Path.Combine(webRootPath, folderName);
                    var filename = DateTime.Now.ToString("yyyyMMddHHmmss") + file.FileName;
                    string fullPath = Path.Combine(newPath, filename);
                    var stream = new FileStream(fullPath, FileMode.Create);
                    await file.CopyToAsync(stream);

                    request.BackgroundImgUrl = "/UploadImg/" + filename;
                    request.CreatedBy = "NV00006";
                    request.LuckyDrawPrizes = luckyDrawPrizes;
                    response = await _luckyDrawService.SaveLuckyDraw(request);
                    if (response.Id != 0)
                    {
                        ViewBag.Message = "Lưu dữ liệu thành công ";
                    }
                    else
                    {
                        ViewBag.Message = "Lưu dữ liệu thất bại !";
                    }
                }  
                else
                {
                    if (buttonName == "Update")
                    {
                        string server = _configuration.GetConnectionString("SQL_LUCKY_DRAW");
                        bool response = false;
                        UpdateRequest request = new UpdateRequest();
                        request.Id = int.Parse(ID);
                        request.Name = title;
                        request.Description = description;
                        request.DrawMonth = Month;
                        request.DrawYear = Year;
                        List<LuckyDrawPrizeRequest> luckyDrawPrizes = new List<LuckyDrawPrizeRequest>();
                        //uploads
                        if(file != null)
                        {
                            string folderName = "UploadImg";
                            string webRootPath = _hostingEnvironment.WebRootPath;
                            string newPath = Path.Combine(webRootPath, folderName);
                            var filename = DateTime.Now.ToString("yyyyMMddHHmmss") + file.FileName;
                            string fullPath = Path.Combine(newPath, filename);
                            var stream = new FileStream(fullPath, FileMode.Create);
                            await file.CopyToAsync(stream);
                            request.BackgroundImgUrl = "/UploadImg/" + filename;
                        }    
                        request.UpdateBy = "NV00006";
                        request.LuckyDrawPrizes = luckyDrawPrizes;
                        response = await _luckyDrawService.UpdateLuckyDraw(request, server);
                        if (response == true)
                        {
                            ViewBag.Message = "Update dữ liệu thành công ";
                        }
                        else
                        {
                            ViewBag.Message = "Update dữ liệu thất bại !";
                        }
                    }
                }  
            }
            catch (Exception)
            {
                throw;
            }
            List<LuckyDrawResponse> responseAll = new List<LuckyDrawResponse>();
            GetListYearRequest requestAll = new GetListYearRequest();
            requestAll.Year = DateTime.Now.Year.ToString();
            responseAll = await _luckyDrawService.GetYearLuckyDraw(requestAll);
            return View(responseAll);
        }
        public async Task<IActionResult> EditLuckyRaw(int ID)
        {
            return PartialView();
        }
        [HttpPost]
        public async Task<IActionResult> DescriptionLuckyRaw(int ID)
        {
            LuckyDrawResponse response = new LuckyDrawResponse();
            response = await _luckyDrawService.GetLuckyDraw(ID);
            return PartialView("DescriptionLuckyRaw",response.Description);
        }
        public async Task<IActionResult> ImportGiaiThuong(int ID)
        {
            LuckyDrawResponse response = new LuckyDrawResponse();
            response = await _luckyDrawService.GetLuckyDraw(ID);
            return PartialView(response);
        }
        [HttpPost]
        public async Task<IActionResult> ImportDataLuckyDraw(int ID)
        {
            LuckyDrawResponse response = new LuckyDrawResponse();
            response = await _luckyDrawService.GetLuckyDraw(ID);
            return PartialView(response);
        }
        [HttpPost]
        public IActionResult UploadCKEditor(IFormFile upload)
        {
            string folderName = "UploadImg";
            string webRootPath = _hostingEnvironment.WebRootPath;
            string newPath = Path.Combine(webRootPath, folderName);

            var filename = DateTime.Now.ToString("yyyyMMddHHmmss") + upload.FileName;
            string fullPath = Path.Combine(newPath, filename);
            var stream = new FileStream(fullPath, FileMode.Create);
            upload.CopyToAsync(stream);
            return new JsonResult(new
            {
                uploaded = 1,
                fileName = upload.FileName,
                url = "/UploadImg/" + filename
            });
        }
        [HttpDelete]
        public async Task<JsonResult> DeleteLuckyDraw(int ID)
        {
            bool result = false;
            DeleteLuckyDraw request = new DeleteLuckyDraw();
            List<int> Ids = new List<int>();
            Ids.Add(ID);
            request.Ids = Ids;
            result = await _luckyDrawService.DeleteLuckyDraw(request);
            return Json(true);
        }
        [HttpPost]
        public async Task<JsonResult> InsertDetailGiaiThuong(int ID, string Name, string Value, string Quantity,[FromForm] IFormFile fileData)
        {
            string MaNV = "";
            string server = _configuration.GetConnectionString("SQL_LUCKY_DRAW");
            int result = 0;
            //uploads
            string folderName = "UploadImg";
            string webRootPath = _hostingEnvironment.WebRootPath;
            string newPath = Path.Combine(webRootPath, folderName);
            var filename = DateTime.Now.ToString("yyyyMMddHHmmss") + fileData.FileName;
            string fullPath = Path.Combine(newPath, filename);
            var stream = new FileStream(fullPath, FileMode.Create);
            await fileData.CopyToAsync(stream);
            string fullPathDataBase = "/UploadImg/" + filename; 
            result = await _luckyDrawService.SaveLuckyDrawPrize(ID, Name, Value, Quantity, fullPathDataBase, server, MaNV);
            return Json(result);
        }
        [HttpDelete]
        public async Task<JsonResult> DeleteDetailPrize(int ID)
        {
            string server = _configuration.GetConnectionString("SQL_LUCKY_DRAW");
            bool result = false;
            result = await _luckyDrawService.DeleteDetailPrize(server,ID);
            return Json(true);
        }
        [HttpPost]
        public async Task<JsonResult> SaveDataLuckyDrawData(string data, int ID)
        {
            string Server = _configuration.GetConnectionString("SQL_LUCKY_DRAW");
            string MaNV = "NV00006";
            List<LuckyDrawDataRequest> ListLuckyDraw = JsonConvert.DeserializeObject<List<LuckyDrawDataRequest>>(data);
            bool result = false;
            result = await _luckyDrawService.SaveDataLuckyDrawData(ListLuckyDraw, Server, MaNV);
            return Json(true);
        }
        [HttpGet]
        public async Task<JsonResult> GetLuckyDraw(int ID)
        {
            LuckyDrawResponse response = new LuckyDrawResponse();
            response = await _luckyDrawService.GetLuckyDraw(ID);
            return Json(response);
        }
        public async Task<IActionResult> ChonChuongTrinh(int ID)
        {
            LuckyDrawResponse response = new LuckyDrawResponse();
            response = await _luckyDrawService.GetLuckyDraw(ID);
            //Get List Agent Winner
            List<LuckyDrawResultResponse> response_Result = new List<LuckyDrawResultResponse>();
            response_Result = await _luckyDrawService.GetWinnerLuckyDraw(ID);
            response.LuckyDrawResults = response_Result;
            return View(response);
        }
        [HttpPost]
        public async Task<JsonResult> ActiveLuckyDrawPrize(int ID, int LuckyDrawId)
        {
            string Server = _configuration.GetConnectionString("SQL_LUCKY_DRAW");
            bool result = false;
            result = await _luckyDrawService.ActiveLuckyDrawPrize(Server,ID,LuckyDrawId);
            return Json(result);
        }
        public async Task<IActionResult> QuaySo(int LuckyDrawID)
        {
            string Server = _configuration.GetConnectionString("SQL_LUCKY_DRAW");
            LuckyDrawResponse response = new LuckyDrawResponse();
            response = await _luckyDrawService.GetLuckyDraw(LuckyDrawID);
            LuckyDrawPrizeResponse response_prize = new LuckyDrawPrizeResponse();
            response_prize = await _luckyDrawService.GetLuckyDrawPrize(LuckyDrawID, Server);
            response.LuckyDrawPrizes = null;
            List<LuckyDrawPrizeResponse> luckyDrawPrizeResponses = new List<LuckyDrawPrizeResponse>();
            luckyDrawPrizeResponses.Add(response_prize);
            response.LuckyDrawPrizes = luckyDrawPrizeResponses;
            //Get List Agent Winner
            List<LuckyDrawResultResponse> response_Result = new List<LuckyDrawResultResponse>();
            response_Result = await _luckyDrawService.GetWinnerLuckyDraw(LuckyDrawID);
            response.LuckyDrawResults = response_Result;
            return PartialView(response);
        }
    }
}
