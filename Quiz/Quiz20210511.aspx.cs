using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Quiz {
    public partial class Quiz20210511 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["name"] = tb_Name.Text;
            Session["id"] = tb_ID.Text;
            Response.Redirect("Quiz20210511_1.aspx", false);
            HttpContext.Current.ApplicationInstance.CompleteRequest();

        }
    }
}