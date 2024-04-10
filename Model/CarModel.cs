using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGallery.Model
{
    internal class CarModel
    {
        public int Id { get; set; }
        public string CarName { get; set; }
        public string Description { get; set; }
        public string ContactNum { get; set; }
        public string ContactEmail { get; set; }
        public int price { get; set; }
        public string Model { get; set; }
        public string Length { get; set; }
        public byte[] Image { get; set; }
        public int company_id { get; set; }
        public int Rent_id { get; set; }
        public int Used_id { get; set; }
    }
}
