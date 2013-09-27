using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ODataService
{
    public partial class Employees : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Create the DataServiceContext using the service URI.
            var context = new ODataService.PubServiceReference.pubsEntities(new Uri("http://localhost:64724/Service/PubsDataService.svc"));
            try
            {
                //Define a query to access the employees
                var query = context.employees.ToList();
                
                //Bind data to the Gridview control
                GridView1.DataSource = query;
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write(ex.InnerException.Message.ToString());
            }
        }
    }
}