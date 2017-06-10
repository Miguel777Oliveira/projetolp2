using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TPBO;
namespace WebApplication
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            foreach (var item in Enum.GetValues(typeof(Etnia)))
            {
                DropDownList1.Items.Add(item.ToString());
            }
            foreach (var itemI in Enum.GetValues(typeof(EstadoCivil)))
            {
                DropDownList2.Items.Add(itemI.ToString());
            }
        }
    }
}