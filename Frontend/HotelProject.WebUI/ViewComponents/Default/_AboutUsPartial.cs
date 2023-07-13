using HotelProject.WebUI.Dtos.AboutDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.WebUI.ViewComponents.Default
{
    public class _AboutUsPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _AboutUsPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient(); //consume edilmesi için bir adet istemci oluşturdum
            var responseMessage = await client.GetAsync("http://localhost:60431/api/About"); //sonra belirlenen adrese istekte bulundum

            if (responseMessage.IsSuccessStatusCode) //adresten başarılı bir istek dönerse
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync(); //gelen veriyi jsondataya atadım
                var values = JsonConvert.DeserializeObject<List<ResultAboutDto>>(jsonData); //gelen json veriyi deseralize ederek okunur hale getirdim
                return View(values);
            }

            return View();
        }
       
    }
}


