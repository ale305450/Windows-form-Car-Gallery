using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGallery.Presenter.Interface
{
    internal interface ISignUp
    {
        //Fields
        string FullName { get; set; }
        string Password { get; set; }
        string ContactEmail { get; set; }
        string ContactNum { get; set; }
        string Gender { get; set; }
        byte[] image { get;}
        string Message { get; set; }
        object Passwordtxtbox { get; set; }

        //Methods
        byte[] getimage();

        //Event 
        event EventHandler CreateUser_butclick;

    }
}
