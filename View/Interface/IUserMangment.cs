using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGallery.View.Interface
{
    internal interface IUserMangment
    {
        //Fields
        object datagrid { get; set; }
        int userId { get; }
        string FullName { get; set; }
        string Form_FullName { get;}
        string ContactEmail { get; set; }
        string Form_ContactEmail { get; }
        string ContactNum { get; set; }
        string Form_ContactNum { get; }
        string Gender { get; set; }
        string Form_Gender { get; }
        byte[] Form_image { get; set; }
        byte[] image { get;}
        string Message { get; set; }

        //Method
        void setuserimage(byte[] value);
        //Event
        event EventHandler edituser;
    }
}
