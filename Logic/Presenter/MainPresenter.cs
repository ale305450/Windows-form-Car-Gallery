using CarGallery.View.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CarGallery.Logic.Services;

namespace CarGallery.Logic.Presenter
{
    internal class MainPresenter
    {
        IMain Imain;

        public MainPresenter(IMain view)
        {
            this.Imain = view;
        }

        public DataTable GetCars()
        {
            DataTable dataTable = new DataTable();
            dataTable = CarServices.MainCarDetalis();
            Imain.CarName_1 = dataTable.Rows[0][0].ToString();
            Imain.CarName_2 = dataTable.Rows[1][0].ToString();
            Imain.CarName_3 = dataTable.Rows[2][0].ToString();

            Imain.CarPrice_1 = dataTable.Rows[0][1].ToString();
            Imain.CarPrice_2 = dataTable.Rows[1][1].ToString();
            Imain.CarPrice_3 = dataTable.Rows[2][1].ToString();

            Imain.CarModel_1 = dataTable.Rows[0][2].ToString();
            Imain.CarModel_2 = dataTable.Rows[1][2].ToString();
            Imain.CarModel_3 = dataTable.Rows[2][2].ToString();

            Imain.CarImage_1 = (byte[])dataTable.Rows[0][3];
            Imain.CarImage_2 = (byte[])dataTable.Rows[1][3];
            Imain.CarImage_3 = (byte[])dataTable.Rows[2][3];

            Imain.CarImageDetails_1 = (byte[])dataTable.Rows[0][3];
            Imain.CarImageDetails_2 = (byte[])dataTable.Rows[1][3];
            Imain.CarImageDetails_3 = (byte[])dataTable.Rows[2][3];

            Imain.CompanyImage_1 = (byte[])dataTable.Rows[0][4];
            Imain.CompanyImage_2 = (byte[])dataTable.Rows[1][4];
            Imain.CompanyImage_3 = (byte[])dataTable.Rows[2][4];

            return dataTable;
        }
    }
}
