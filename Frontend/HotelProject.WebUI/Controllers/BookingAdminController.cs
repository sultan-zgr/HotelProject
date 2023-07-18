﻿using HotelProject.WebUI.Dtos.BookingDto;
using HotelProject.WebUI.Dtos.ServiceDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    public class BookingAdminController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BookingAdminController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient(); //consume edilmesi için bir adet istemci oluşturdum
            var responseMessage = await client.GetAsync("http://localhost:60431/api/Booking"); //sonra belirlenen adrese istekte bulundum

            if (responseMessage.IsSuccessStatusCode) //adresten başarılı bir istek dönerse
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync(); //gelen veriyi jsondataya atadım
                var values = JsonConvert.DeserializeObject<List<ResultBookingDto>>(jsonData); //gelen json veriyi deseralize ederek okunur hale getirdim
                return View(values);
            }

            return View();
        }
        public async Task<IActionResult> ApprovedReservation(ApprovedReservationDto approvedReservationDto)
        {
            approvedReservationDto.Status = "Onaylandı";
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(approvedReservationDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("http://localhost:60431/api/BookingB/", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View(); 
        }
    }
}
