using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASSESSMENT
{
    public partial class FINALPAGE : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void finalbacktoservicebroker_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://10.120.2.27/ilabservicebroker");
        }
    }
}