using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGallery.View.Interface
{
    internal interface IMain
    {
        //Fileds
        string CarName_1 { get; set; }
        string CarPrice_1 { get; set; }
        string CarModel_1 { get; set; }
        byte[] CarImage_1 { set; }
        byte[] CarImageDetails_1 { get; set; }
        byte[] CompanyImage_1 { get; set; }

        string CarName_2 { get; set; }
        string CarPrice_2 { get; set; }
        string CarModel_2 { get; set; }
        byte[] CarImage_2 {set; }
        byte[] CarImageDetails_2 { get; set; }
        byte[] CompanyImage_2 { get; set; }

        string CarName_3 { get; set; }
        string CarPrice_3 { get; set; }
        string CarModel_3 { get; set; }
        byte[] CarImage_3 {set; }
        byte[] CarImageDetails_3 { get; set; }
        byte[] CompanyImage_3 { get; set; }

        //Methods
        void setCarImage1(byte[] value);
        void setCarImage2(byte[] value);
        void setCarImage3(byte[] value);

    }
}
