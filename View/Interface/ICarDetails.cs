using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGallery.Presenter.Interface
{
    internal interface ICarDetails
    {
        //Fields
        byte[] CarPic {set; }
        byte[] companyLogo {set; }
        string CarNametxtbox { get; set; }
        string CarPricetxtbox { get; set; }
        string CarModeltxtbox { get; set; }

        //Methods
        void setCarImage(byte[] value);
        void setCarLogo(byte[] value);
    }
}
