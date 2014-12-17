using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BloodDonorService.WebClient.ServiceReference1;

namespace BloodDonorService.WebClient
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCallService_Click(object sender, EventArgs e)
        {
            BloodDonorServiceClient client = new BloodDonorServiceClient("ep2");
            var group = txtBloodGroup.Text;
            var pin = Convert.ToInt32(txtPinCode.Text);
            var result = client.GetTopDonor(group,pin);
            lblResult.Text = result; 


        }
    }
}