using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGallery.Presenter.Interface
{
    interface ICompanyAdd
    {
        //Fields
        string CompanyName { get; set; }
        string Description { get; set; }
        byte[] Logo { get;}
        string Message { get; set; }
        object but_Addcompany { get; set; }

        //Methods
        byte[] getimage();

        //Events
        event EventHandler EditCompany_butclick;

    }
}
