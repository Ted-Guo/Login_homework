using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["userName"] = "guest"; 
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        bool ans = (string.IsNullOrEmpty(txtUserName.Text)|| string.IsNullOrEmpty(txtPassword.Text));
        if (ans)
        {
            lblPrompt.Text = "帳號或密碼未填!";
           
        }
        else {
            Session["userName"] = txtUserName.Text;
            Response.Redirect("Secret.aspx");
        }
         

    }
}