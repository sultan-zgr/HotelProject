using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
    public class UpdateRoomDto
    {
        [Required(ErrorMessage = "Boş geçilemez.")]
        public int RoomID { get; set; }
        [Required(ErrorMessage = "Boş geçilemez.")]
        public string RoomNumber { get; set; }
        [Required(ErrorMessage = "Boş geçilemez.")]
        public string RoomCoverImage { get; set; }
        [Required(ErrorMessage = "Boş geçilemez.")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Boş geçilemez.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Boş geçilemez.")]
        public string BedCount { get; set; }
        [Required(ErrorMessage = "Boş geçilemez.")]
        public string BathCount { get; set; }
        [Required(ErrorMessage = "Boş geçilemez.")]
        public string Wifi { get; set; }
        [Required(ErrorMessage = "Boş geçilemez.")]
        public string Description { get; set; }
    }
}

