using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SelfHostedSalesService;
using System.ServiceModel;

namespace SelfHostedSalesService.Host
{
    public partial class Form1 : Form
    {
        ServiceHost host; 
        public Form1()
        {
            InitializeComponent();
            host = new ServiceHost(typeof(Service1));
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            host.Open();
            lblStatus.Text = "Service is running, to stop click on Stop Service";
            lblRnAdd1.Text = "service is running on  net.tcp://localhost:9002/SelfHostedSalesService or http://localhost:9003/SelfHostedSalesService";

        }

        private void btnStopService_Click(object sender, EventArgs e)
        {
            host.Close();
            lblStatus.Text = "Service is stopped , to start click on Start Service";
            lblRnAdd1.Text = " ";
        }
    }
}
