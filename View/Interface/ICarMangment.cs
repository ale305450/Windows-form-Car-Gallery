using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGallery.Presenter.Interface
{
    internal interface ICarMangment
    {
        //Fields
        object Datagrid { get; set; }
        int FormCarId { get; }
        string FormCarNametxtbox { get; set; }
        string FormCarDescriptionrichbox { get; set; }
        int FormCarprice { get; set; }
        string FormCarModel { get; set; }
        string FormCarContactNum { get; set; }
        string FormCarContactEmail { get; set; }
        byte[] FormCarimagepicbox { get; set; }           
        byte[] Carimage { get; }           
        string Formcompany_Name { get; set; }
        int FormCarRent_id { get; set; }
        int FormCarUsed_id { get; set; }
        string Message { get; set; }
        object AddCar_but { get; set; }
        object EditCar_but { get; set; }
        object CarDetails_but { get; set; }
        object DeleteCar_but { get; set; }

        string CarName { get; set; }
        string Description { get; set; }
        string ContactNum { get; set; }
        string ContactEmail { get; set; }
        int price { get; set; }
        string Model { get; set; }
        string Length { get; set; }
        int company_id { get; set; }
        int Rent_id { get; set; }
        int Used_id { get; set; }


        //Methods
        void setCarImage(byte[] value);

        //Events
        event EventHandler EditCar_butclick;
        
    }
}
