using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGallery.Presenter.Interface
{
    internal interface ILogin
    {
        //Fields
        string LoginEmail { get; set; }
        string LoginPassword { get; set; }
        string ErrorMessage { get; set; }

    }
}
