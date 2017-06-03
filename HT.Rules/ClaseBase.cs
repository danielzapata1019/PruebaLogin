using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;


namespace HT.Rules
{
    public class ClaseBase 
    {
        //Consultas    
        private string _Query_SQL = "";
        private string _UsuarioLogeado = "Anonimo";
        private string _IP_Cliente = "0";
        private int _IUS = 0;
        //DT Generico
        DataTable _Dtg = new DataTable();


        //SQLServer
        private string _BaseSQLServer = "";
        private int _TimeOutSQLServer = 15;


        /// <summary>
        /// Base de datos SQL Server en la cual se ejecutaran por defecto las instrucciones
        /// </summary>
        public string BaseSQLServer
        {
            get
            {
                return _BaseSQLServer;
            }
            set
            {
                _BaseSQLServer = value;
            }
        }

        /// <summary>
        /// Time Out de las consultas SQL Server, 15 segundos por defecto
        /// </summary>
        public int TimeOutSQLSever
        {
            get
            {
                return _TimeOutSQLServer;
            }
            set
            {
                _TimeOutSQLServer = value;
            }
        }
        /// <summary>
        ///   Datatable Generico donde se almacenaran los resultados de las consultas
        /// </summary>

        public DataTable DTg
        {
            get
            {
                return _Dtg;
            }
            set
            {
                value = new DataTable();
                _Dtg = value;
            }
        }

         protected void SQL_GET(string SQL)
         {
             HT.Data.sql oSQL = new HT.Data.sql();
             if (BaseSQLServer != "")
             {
              oSQL.Base = BaseSQLServer;
             }
             oSQL.TimeOut = TimeOutSQLSever;
             _Dtg= oSQL.ExecuteQ(SQL);
         }

        protected void SQL_SET(string SQL){
            HT.Data.sql oSQL = new HT.Data.sql();
             if (BaseSQLServer != "")
             {
              oSQL.Base = BaseSQLServer;
             }
             oSQL.TimeOut = TimeOutSQLSever;
             _Dtg= oSQL.ExecuteQ(SQL);
        }
          
    }
}
