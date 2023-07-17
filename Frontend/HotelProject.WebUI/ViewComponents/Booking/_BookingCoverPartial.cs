using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HotelProject.WebUI.ViewComponents.Booking
{
    public class _BookingCoverPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
      
    }
}
