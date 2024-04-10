using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGallery.Presenter.Interface
{
    interface ICompanyMangment
    {
        //Fields
        object Datagrid { get; set; }
        int FormCompanyId { get;}
        string FormCompanyNametxtbox { get; set;}
        string CompanyNametxtbox { get; set;}
        string FormCompanyDescriptionrichbox { get; set; }
        string CompanyDescriptionrichbox { get; set; }
        byte[] FormCompanyLogopicbox { get; set; }
        byte[] CompanyLogo { get;}
        object AddCompany_but { get; set; }
        object EditCompany_but { get; set; }
        object DeleteCompany_but { get; set; }

        //Methods
        void setCompanyImage(byte[] value);

        //Events
        event EventHandler EditCompany_butclick;
    }
}
