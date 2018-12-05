using SDClasses.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SDWeb
{
    public partial class AbrirChamado : System.Web.UI.Page
    {
        private Cliente cliente = new Cliente();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Cliente"] != null)
            {
                cliente = (Cliente)Session["Cliente"];
            } else
            {
                Response.Redirect("login.aspx");
            }
        }
    }
}