using CarGallery.Logic.Services;
using CarGallery.Model;
using CarGallery.Presenter.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGallery.Logic.Presenter
{
    internal class AddCarPresenter
    {
        CarModel carModel = new CarModel();
        IAddCar IaddCar;
        public AddCarPresenter(IAddCar view)
        {
            this.IaddCar = view;
            this.IaddCar.EditCar_butclick += IaddCar_EditCar_butclick;
        }

        // Method to connect Model and interface
        public void ConnectionBetweenModelAndInterface()
        {
            this.carModel.CarName = IaddCar.CarName;
            this.carModel.Description = IaddCar.Description;
            this.carModel.price = IaddCar.price;
            this.carModel.Model = IaddCar.Model;
            this.carModel.ContactNum = IaddCar.ContactNum;
            this.carModel.ContactEmail = IaddCar.ContactEmail;
            this.carModel.Image = IaddCar.image;
            this.carModel.Length = IaddCar.Length;
            this.carModel.company_id = IaddCar.company_id;
            this.carModel.Rent_id = IaddCar.Rent_id;
            this.carModel.Used_id = IaddCar.Used_id;
        }

        private void IaddCar_EditCar_butclick(object sender, EventArgs e)
        {
            InsertCar();
        }

        // Method to insert Car info In DB
        public bool InsertCar()
        {
            ConnectionBetweenModelAndInterface();
            if (IaddCar.ContactEmail.Contains("@") && IaddCar.ContactNum.Length == 9 )
            {
                IaddCar.Message = "The car inserted successfully";
                if(Convert.ToBoolean(IaddCar.RadiobutRent))
                {
                    return CarServices.insertRentedCar(carModel.CarName, carModel.Description, carModel.price, carModel.Model, carModel.ContactNum
               , carModel.ContactEmail, carModel.Image, carModel.company_id, carModel.Rent_id);
                }
                else if(Convert.ToBoolean( IaddCar.RadiobutUsed))
                {
                    return CarServices.insertUsedCar(carModel.CarName, carModel.Description, carModel.price, carModel.Model, carModel.ContactNum
              , carModel.ContactEmail, carModel.Image, carModel.company_id, carModel.Used_id);
                }
                else
                {
                    return CarServices.insertCar(carModel.CarName, carModel.Description, carModel.price, carModel.Model, carModel.ContactNum
               , carModel.ContactEmail, carModel.Image, carModel.company_id);
                }     
            }
            else if (!IaddCar.ContactEmail.Contains("@"))
            {
                IaddCar.Message = "The Email should contain @ ";
                return false;
            }
            else if(IaddCar.ContactNum.Length !=9)
            {
                IaddCar.Message = "The number should be 9 numbers";
                return false;
            }
            else return false;  
        }

        public byte[] getimage()
        {
            ConnectionBetweenModelAndInterface();
            return IaddCar.getimage();
        }
        // Is for the combox in the form which let you select company from data base
        public void selectcompany()
        {
            ConnectionBetweenModelAndInterface();
            IaddCar.comboxCompany = CarServices.getCompanyData();
            IaddCar.CompanyValueMember = "Id";
            IaddCar.CompanyDisplayMember = "Name";
        }
        // Is user to fill the combox in the form which display Rent Length 
        public void SelectRentLength()
        {
            ConnectionBetweenModelAndInterface();

            IaddCar.combox_Length = CarServices.getRentLength();
            IaddCar.LengthDisplayMember = "Rent_Length";
            IaddCar.LengthValueMember = "Id";
        }
        // Is user to fill the combox in the form which display Used Length 
        public void SelectUsedLength()
        {
            ConnectionBetweenModelAndInterface();

            IaddCar.combox_Length = CarServices.getUsedLength();
            IaddCar.LengthDisplayMember = "Used_Length";
            IaddCar.LengthValueMember = "Id";
        }
    }
}
