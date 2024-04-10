using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGallery.Presenter.Interface
{
    internal interface IAddCar
    {
        //Fields
        string CarName { get; set; }
        string Description { get; set; }
        string ContactNum { get; set; }
        string ContactEmail { get; set; }
        int price { get; set; }
        string Model { get; set; }
        string Length { get; set; }
        byte[] image { get; }
        int company_id { get; set; }
        int Rent_id { get; set; }
        int Used_id { get; set; }
        object comboxCompany { get; set; }
        object RadiobutRent { get; set; }
        object RadiobutUsed { get; set; }
        string CompanyValueMember  { get; set; }
        string CompanyDisplayMember { get; set; }
        object combox_Length { get; set; }
        string LengthValueMember { get; set; }
        string LengthDisplayMember { get; set; }
        string Message { get; set; }

        //Methods
        byte[] getimage();

        //Method
        event EventHandler EditCar_butclick;


    }
}
