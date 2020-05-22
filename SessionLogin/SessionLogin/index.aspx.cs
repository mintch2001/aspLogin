using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionLogin
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Check();
        }

        protected void loginClick_Click(object sender, EventArgs e)
        {
            WriteID(txtID.Text);
            WritePass(txtPassword.Text);
            Check();
        }
        private void Check()
        {
            if (ReadID() == "" || ReadPass() == "")
            {
                
            }
            else
            {
                Server.Transfer("Home.aspx");
            }
        }
        protected void WriteID(string id)
        {
            Session["userID"] = id;
        }
        protected void WritePass(string pass)
        {
            Session["userPass"] = pass;
        }
        private string ReadID()
        {
            if (Session["userID"] == null)
            {
                return "";
            }
            else
            {
                return Session["userID"].ToString();
            }          
        }
        private string ReadPass()
        {
            if (Session["userPass"] == null)
            {
                return "";
            }
            else
            {
                return Session["userPass"].ToString();
            }          
        }
    }
}