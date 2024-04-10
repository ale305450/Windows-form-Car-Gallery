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
    internal class CarMangmentPresenter
    {
        ICarMangment IcarMangment;
        Frm_AddCar frm_AddCar = new Frm_AddCar();
        CarModel carModel = new CarModel();
        public CarMangmentPresenter(ICarMangment view)
        {
            this.IcarMangment = view;
            this.IcarMangment.EditCar_butclick += IcarMangment_EditCar_butclick;
        }

        private void IcarMangment_EditCar_butclick(object sender, EventArgs e)
        {
            InsertCar();
            SelectAllCars();
        }
        //Connect between the model and the interface
        private void connectionBetweenModelInterface()
        {
            carModel.Id = IcarMangment.FormCarId;
            carModel.CarName = IcarMangment.CarName;
            carModel.Description = IcarMangment.Description;
            carModel.price = IcarMangment.price;
            carModel.Model = IcarMangment.Model;
            carModel.ContactNum = IcarMangment.ContactNum;
            carModel.ContactEmail = IcarMangment.ContactEmail;
            carModel.Image = IcarMangment.Carimage;
            carModel.Length = IcarMangment.Length;
            carModel.company_id = IcarMangment.company_id;
            carModel.Rent_id = IcarMangment.Rent_id;
            carModel.Used_id = IcarMangment.Used_id;

        }

        public bool InsertCar()
        {
            connectionBetweenModelInterface();
            if (IcarMangment.ContactEmail.Contains("@") && IcarMangment.ContactNum.Length == 9)
            {
                IcarMangment.Message = "The car inserted successfully";
                if (Convert.ToBoolean(frm_AddCar.RadiobutRent))
                {
                    return CarServices.updateRentCar(carModel.Id, carModel.CarName, carModel.Description, carModel.price, carModel.Model, carModel.ContactNum
               , carModel.ContactEmail, carModel.Image, carModel.company_id, carModel.Rent_id);
                }
                else if (Convert.ToBoolean(frm_AddCar.RadiobutUsed))
                {
                    return CarServices.updateUsedCar(carModel.Id, carModel.CarName, carModel.Description, carModel.price, carModel.Model, carModel.ContactNum
              , carModel.ContactEmail, carModel.Image, carModel.company_id, carModel.Used_id);
                }
                else
                {
                    return CarServices.updateCar(carModel.Id, carModel.CarName, carModel.Description, carModel.price, carModel.Model, carModel.ContactNum
               , carModel.ContactEmail, carModel.Image, carModel.company_id);
                }
            }
            else if (!IcarMangment.ContactEmail.Contains("@"))
            {
                IcarMangment.Message = "The Email should contain @ ";
                return false;
            }
            else if (IcarMangment.ContactNum.Length != 9)
            {
                IcarMangment.Message = "The number should be 9 numbers";
                return false;
            }
            else return false;
        }
        public void SelectAllCars()
        {
            IcarMangment.Datagrid = CarServices.SelectAllCar();
        }
        public bool CarDelete()
        {
            bool check = CarServices.CarDelete(IcarMangment.FormCarId);
            SelectAllCars();
            return check;
        }
    }
}
