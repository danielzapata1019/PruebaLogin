using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HT.Rules
{
    public class Login : ClaseBase
    {

        public Boolean Loguear(string Usuario, string Password)
        {
            SQL_GET("SELECT * FROM TS_Usuarios WHERE IdUsuario='" + Usuario +"' AND Psw='" + Password + "'");
            if (DTg.Rows.Count != 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
