using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASSESSMENT
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void backtoservicebroker_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://10.120.2.27/ilabservicebroker");
        }

        protected void finishlab_Click(object sender, EventArgs e)
        {
            Response.Redirect("/instructions.aspx");
        }
    }
}