using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGallery.Model
{
    internal class UserModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public string ContactEmail { get; set; }
        public string ContactNum { get; set; }
        public string Gender { get; set; }
        public byte[] image { get; set; }
    }
}
