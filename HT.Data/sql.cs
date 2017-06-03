using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace HT.Data
{

    public class sql
    {
        private int _TimeOut = 15;
        SqlConnection _cnn = new SqlConnection();
        OleDbConnection _OleDBcnn = new OleDbConnection();
        SqlDataAdapter _da = new SqlDataAdapter();
        //SqlParameterCollection _pc = new SqlParameterCollection();
        SqlCommand _cmd = new SqlCommand();
        private string _Base = "Default";


        public int TimeOut
        {
            get
            {
                return _TimeOut;
            }
            set
            {
                _TimeOut = value;
            }
        }

        #region Propiedades
        public string Base
        {
            get
            {
                return _Base;
            }
            set
            {
                _Base = value;
            }
        }

        public string Cadena
        {
            get
            {
                switch (_Base)
                {
                    case "Default":
                        return HT.Data.Properties.Settings.Default.Hotel;

                    default:
                        return "";
                }

            }
        }

        #endregion

        #region MetodosPrivados
        private void abrirBase(string ruta = "")
        {
            cerrarBase();
            _cnn.ConnectionString = Cadena;
            _cnn.Open();

        }

        private void cerrarBase()
        {
            //if (_cnn.State.Equals(1)){
            _cnn.Close();
            //}
        }
        #endregion

        #region Metodos Publicos

        /// <summary>
        /// Ejecuta una instruccion Query en la base de datos
        /// </summary>
        /// <param name="SQL">Sintaxis SQL</param>
        /// <returns></returns>
        public DataTable ExecuteQ(string SQL)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(SQL, _cnn);
                abrirBase();
                da.SelectCommand.CommandTimeout = TimeOut;
                da.Fill(dt);
                return dt;
            }
            finally
            {
                cerrarBase();
            }
        }

        public void ExecuteNQ(string SQL)
        {
            try
            {
                abrirBase();
                _cmd.Connection = _cnn;
                _cmd.CommandText = SQL;
                _cmd.CommandTimeout = TimeOut;
                _cmd.ExecuteNonQuery();
            }
            finally
            {
                cerrarBase();
            }
        }

        #endregion

      
    }
}
