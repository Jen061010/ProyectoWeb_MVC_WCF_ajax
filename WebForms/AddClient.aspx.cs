using Dominio;
using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms
{
    public partial class AddClient : System.Web.UI.Page
    {
        public ICustomerService MyService { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //var customer = this.MyService.Add();

            }

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}