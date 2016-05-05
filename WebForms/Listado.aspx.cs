using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms
{
    public partial class Listado : Page
    {
        public ICustomerService MyService { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var customer = this.MyService.GetAlls();
                Lista.DataSource = MyService.GetAlls().ToList();

                Lista.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AddClient.aspx");
        }
     
        }

        /*protected void Lista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }*/
    
}