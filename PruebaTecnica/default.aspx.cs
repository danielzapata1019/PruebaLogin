using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace PruebaTecnica
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //SqlConnection cnx = new SqlConnection(ConfigurationManager.AppSettings["cnx"].ToString());
            if(!Page.IsPostBack){
            }
        }

        /// <summary>
        /// Método Ingresar, valida el login del usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Ingresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                lblAdv.Text = "Debe ingresar un usuario";
            }
            else {
                loguear(txtUserName.Text.Trim(),txtPassword.Text.Trim());
            }
        }

        private void loguear(string User, string Psw)
        {
            HT.Rules.Login oLogin = new HT.Rules.Login();

              if (oLogin.Loguear(User,Psw)){
                  Response.Redirect("Menu.aspx");
              }
        }

      
    }
}