using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenCC.DAO
{
    public class ConexionDAO
    {

        #region Varibales

        private SqlConnection oConexion;
        #endregion Variables

        #region Metodos

        /// <summary>
        /// Abrir la conexion de la base de datos
        /// </summary>
        /// <returns></returns>
        public SqlConnection Open()
        {
            string sConexion = string.Empty;
            try
            {
                sConexion = ConfigurationManager.ConnectionStrings["Sir_SQLSERVER"].ToString();
                oConexion = new SqlConnection();
                oConexion.ConnectionString = sConexion;
                if (oConexion != null && oConexion.State == ConnectionState.Closed)
                {
                    oConexion.Open();
                }
                return oConexion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sConexion = null;
            }

        }

        /// <summary>
        /// Cierra la conexion a la base de datos
        /// </summary>
        /// <returns></returns>
        public SqlConnection Close()
        {
            try
            {
                if (oConexion != null && oConexion.State == ConnectionState.Open)
                {
                    oConexion.Close();
                }
                return oConexion;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        #endregion Metodos



    }
}
