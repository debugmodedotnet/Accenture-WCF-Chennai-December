using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebClient.ServiceReference1;

namespace WebClient
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductsCRUDServiceClient p = new ProductsCRUDServiceClient();
            var result = p.GetAllProducts();
            GridView1.DataSource = result;
            GridView1.DataBind();


        }
    }
}