using ExamenCC.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ExamenCC.DAO
{
    public class ClienteContactoDAO
    {

        #region Varibales

        private ConexionDAO oConexion;
        private SqlCommand oCommand;
        private SqlDataReader oDataRead;
        #endregion Variables

        #region Constructor

        public ClienteContactoDAO()
        {
            oConexion = new ConexionDAO();
            oCommand = new SqlCommand();
        }

        #endregion Constructor
        public void EnviaParametros(ClienteContacto clienteContacto, int nOpcion)
        {
            try
            {
                oCommand.Connection = oConexion.Open();

                oCommand.CommandText = nOpcion == 1 ? "SIR.usp_JJVZ_CClientes" : "SIR.usp_JJVZ_UClientes";
                oCommand.CommandType = System.Data.CommandType.StoredProcedure;
                oCommand.Parameters.Clear();
                if (nOpcion == 1)
                {
                    oCommand.Parameters.AddWithValue("@nIdCliente01", SqlDbType.Int).Direction = ParameterDirection.Output;
                }
                if (nOpcion == 2)
                {
                    oCommand.Parameters.AddWithValue("@nIdCliente01", clienteContacto.nIdCliente01);
                }
                oCommand.Parameters.AddWithValue("@sClave", clienteContacto.sClave);
                oCommand.Parameters.AddWithValue("@sNombre", clienteContacto.sNombre);
                oCommand.Parameters.AddWithValue("@sApellidoPat", clienteContacto.sApellidoPat);
                oCommand.Parameters.AddWithValue("@sApellidoMat", clienteContacto.sApellidoMat);
                oCommand.Parameters.AddWithValue("@sRazonSocial", clienteContacto.sRazonSocial);
                oCommand.Parameters.AddWithValue("@bTipoPersona", clienteContacto.bTipoPersona);
                oCommand.Parameters.AddWithValue("@sNombreComercial", clienteContacto.sNombreComercial);
                oCommand.Parameters.AddWithValue("@sCalle", clienteContacto.sCalle);
                oCommand.Parameters.AddWithValue("@nCodigoPostal", clienteContacto.nCodigoPostal);
                oCommand.Parameters.AddWithValue("@nExterior", clienteContacto.nExterior);
                oCommand.Parameters.AddWithValue("@sColonia", clienteContacto.sColonia);
                oCommand.Parameters.AddWithValue("@sMunicipio", clienteContacto.sMunicipio);
                oCommand.Parameters.AddWithValue("@sEstado", clienteContacto.sEstado);
                oCommand.Parameters.AddWithValue("@sPais", clienteContacto.sPais);
                oCommand.Parameters.AddWithValue("@sRFC", clienteContacto.sRFC);
                oCommand.Parameters.AddWithValue("@sCURP", clienteContacto.sCURP);
                oCommand.Parameters.AddWithValue("@nNumeroTelefono", clienteContacto.nNumeroTelefono);
                oCommand.Parameters.AddWithValue("@sEmail", clienteContacto.sEmail);
                oCommand.Parameters.AddWithValue("@bEstatus", clienteContacto.bEstatus);

                oDataRead = oCommand.ExecuteReader();
                if (nOpcion == 1)
                {
                    clienteContacto.nIdCliente01 = Convert.ToInt16(oCommand.Parameters["@nIdCliente01"].Value);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }


        #region Metodos CRUD Cliente
        public void GuardarCliente(ClienteContacto clienteContacto, int nOpcion)
        {
            try
            {
                EnviaParametros(clienteContacto, nOpcion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (oCommand.Connection.State == ConnectionState.Open)
                {
                    oConexion.Close();
                }
            }
        }

        public void ActualizarCliente(ClienteContacto clienteContacto,int nOpcion)
        {
            try
            {
                EnviaParametros(clienteContacto, nOpcion);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void EliminarPorIdCliente(int nIdCliente)
        {
            try
            {
                oCommand.Connection = oConexion.Open();
                oCommand.CommandText = "SIR.usp_JJVZ_DClientes";
                oCommand.CommandType = System.Data.CommandType.StoredProcedure;
                oCommand.Parameters.Clear();
                oCommand.Parameters.AddWithValue("@nIdCliente01", nIdCliente);
                oDataRead = oCommand.ExecuteReader();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (oCommand.Connection.State == ConnectionState.Open)
                    oConexion.Close();
            }
        }

        public List<ClienteContacto> ListaClienteAll()
        {
            try
            {
                oCommand.Connection = oConexion.Open();
                oCommand.CommandText = "SIR.usp_JJVZ_RClientes";
                oCommand.CommandType = System.Data.CommandType.StoredProcedure;
                oCommand.Parameters.Clear();
                oDataRead = oCommand.ExecuteReader();
                List<ClienteContacto> listCliente = new List<ClienteContacto>();
                ClienteContacto oCliente = new ClienteContacto();
                while (oDataRead.Read())
                {
                    oCliente = new ClienteContacto();
                    oCliente.nIdCliente01 = Convert.IsDBNull(oDataRead["nIdCliente01"]) ? 0 : Convert.ToInt32(oDataRead["nIdCliente01"]);
                    oCliente.sClave = Convert.IsDBNull(oDataRead["sClave"]) ? string.Empty : Convert.ToString(oDataRead["sClave"]);
                    oCliente.sNombre = Convert.IsDBNull(oDataRead["sNombre"]) ? string.Empty : Convert.ToString(oDataRead["sNombre"]);
                    oCliente.sApellidoPat = Convert.IsDBNull(oDataRead["sApellidoPat"]) ? string.Empty : Convert.ToString(oDataRead["sApellidoPat"]);
                    oCliente.sApellidoMat = Convert.IsDBNull(oDataRead["sApellidoMat"]) ? string.Empty : Convert.ToString(oDataRead["sApellidoMat"]);
                    oCliente.sRazonSocial = Convert.IsDBNull(oDataRead["sRazonSocial"]) ? string.Empty : Convert.ToString(oDataRead["sRazonSocial"]);
                    oCliente.bTipoPersona = Convert.ToInt32(oDataRead["bTipoPersona"]);
                    oCliente.sNombreComercial = Convert.IsDBNull(oDataRead["sNombreComercial"]) ? string.Empty : Convert.ToString(oDataRead["sNombreComercial"]);
                    oCliente.sCalle = Convert.IsDBNull(oDataRead["sCalle"]) ? string.Empty : Convert.ToString(oDataRead["sCalle"]);
                    oCliente.nCodigoPostal = Convert.IsDBNull(oDataRead["nCodigoPostal"]) ? string.Empty : Convert.ToString(oDataRead["nCodigoPostal"]);
                    oCliente.nExterior = Convert.IsDBNull(oDataRead["nExterior"]) ? string.Empty : Convert.ToString(oDataRead["nExterior"]);
                    oCliente.sColonia = Convert.IsDBNull(oDataRead["sColonia"]) ? string.Empty : Convert.ToString(oDataRead["sColonia"]);
                    oCliente.sMunicipio = Convert.IsDBNull(oDataRead["sMunicipio"]) ? string.Empty : Convert.ToString(oDataRead["sMunicipio"]);
                    oCliente.sEstado = Convert.IsDBNull(oDataRead["sEstado"]) ? string.Empty : Convert.ToString(oDataRead["sEstado"]);
                    oCliente.sPais = Convert.IsDBNull(oDataRead["sPais"]) ? string.Empty : Convert.ToString(oDataRead["sPais"]);
                    oCliente.sRFC = Convert.IsDBNull(oDataRead["sRFC"]) ? string.Empty : Convert.ToString(oDataRead["sRFC"]);
                    oCliente.sCURP = Convert.IsDBNull(oDataRead["sCURP"]) ? string.Empty : Convert.ToString(oDataRead["sCURP"]);
                    oCliente.nNumeroTelefono = Convert.IsDBNull(oDataRead["nNumeroTelefono"]) ? string.Empty : Convert.ToString(oDataRead["nNumeroTelefono"]);
                    oCliente.sEmail = Convert.IsDBNull(oDataRead["sEmail"]) ? string.Empty : Convert.ToString(oDataRead["sEmail"]);
                    oCliente.bEstatus = Convert.ToInt32(oDataRead["bEstatus"]);
                    listCliente.Add(oCliente);
                    oCliente = null;
                }
                
                return listCliente;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (oCommand.Connection.State == ConnectionState.Open)
                    oConexion.Close();
            }


        }

        public ClienteContacto ClientePorId(int idCliente)
        {
            try
            {
                oCommand.Connection = oConexion.Open();
                oCommand.CommandText = "SIR.usp_JJVZ_RClientesPorId";
                oCommand.CommandType = System.Data.CommandType.StoredProcedure;
                oCommand.Parameters.Clear();
                oCommand.Parameters.AddWithValue("@nIdCliente01", idCliente);
                oDataRead = oCommand.ExecuteReader();
                ClienteContacto oCliente = new ClienteContacto();
                while (oDataRead.Read())
                {
                    oCliente = new ClienteContacto();
                    oCliente.nIdCliente01 = Convert.IsDBNull(oDataRead["nIdCliente01"]) ? 0 : Convert.ToInt32(oDataRead["nIdCliente01"]);
                    oCliente.sClave = Convert.IsDBNull(oDataRead["sClave"]) ? string.Empty : Convert.ToString(oDataRead["sClave"]);
                    oCliente.sNombre = Convert.IsDBNull(oDataRead["sNombre"]) ? string.Empty : Convert.ToString(oDataRead["sNombre"]);
                    oCliente.sApellidoPat = Convert.IsDBNull(oDataRead["sApellidoPat"]) ? string.Empty : Convert.ToString(oDataRead["sApellidoPat"]);
                    oCliente.sApellidoMat = Convert.IsDBNull(oDataRead["sApellidoMat"]) ? string.Empty : Convert.ToString(oDataRead["sApellidoMat"]);
                    oCliente.sRazonSocial = Convert.IsDBNull(oDataRead["sRazonSocial"]) ? string.Empty : Convert.ToString(oDataRead["sRazonSocial"]);
                    oCliente.bTipoPersona = Convert.ToInt32(oDataRead["bTipoPersona"]);
                    oCliente.sNombreComercial = Convert.IsDBNull(oDataRead["sNombreComercial"]) ? string.Empty : Convert.ToString(oDataRead["sNombreComercial"]);
                    oCliente.sCalle = Convert.IsDBNull(oDataRead["sCalle"]) ? string.Empty : Convert.ToString(oDataRead["sCalle"]);
                    oCliente.nCodigoPostal = Convert.IsDBNull(oDataRead["nCodigoPostal"]) ? string.Empty : Convert.ToString(oDataRead["nCodigoPostal"]);
                    oCliente.nExterior = Convert.IsDBNull(oDataRead["nExterior"]) ? string.Empty : Convert.ToString(oDataRead["nExterior"]);
                    oCliente.sColonia = Convert.IsDBNull(oDataRead["sColonia"]) ? string.Empty : Convert.ToString(oDataRead["sColonia"]);
                    oCliente.sMunicipio = Convert.IsDBNull(oDataRead["sMunicipio"]) ? string.Empty : Convert.ToString(oDataRead["sMunicipio"]);
                    oCliente.sEstado = Convert.IsDBNull(oDataRead["sEstado"]) ? string.Empty : Convert.ToString(oDataRead["sEstado"]);
                    oCliente.sPais = Convert.IsDBNull(oDataRead["sPais"]) ? string.Empty : Convert.ToString(oDataRead["sPais"]);
                    oCliente.sRFC = Convert.IsDBNull(oDataRead["sRFC"]) ? string.Empty : Convert.ToString(oDataRead["sRFC"]);
                    oCliente.sCURP = Convert.IsDBNull(oDataRead["sCURP"]) ? string.Empty : Convert.ToString(oDataRead["sCURP"]);
                    oCliente.nNumeroTelefono = Convert.IsDBNull(oDataRead["nNumeroTelefono"]) ? string.Empty : Convert.ToString(oDataRead["nNumeroTelefono"]);
                    oCliente.sEmail = Convert.IsDBNull(oDataRead["sEmail"]) ? string.Empty : Convert.ToString(oDataRead["sEmail"]);
                    oCliente.bEstatus = Convert.ToInt32(oDataRead["bEstatus"]);
                }

                return oCliente;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (oCommand.Connection.State == ConnectionState.Open)
                    oConexion.Close();
            }


        }

        #endregion Metodos CRUD Cliente

        #region Metodos CRUD Contacto

        public ClienteContacto ConsecutivoCliente()
        {
            try
            {
                oCommand.Connection = oConexion.Open();
                oCommand.CommandText = "SIR.usp_JJVZ_RSiguienteClaveCliente";
                oCommand.CommandType = System.Data.CommandType.StoredProcedure;
                oCommand.Parameters.Clear();
                oDataRead = oCommand.ExecuteReader();
                ClienteContacto oClienteClave = new ClienteContacto();
                while (oDataRead.Read())
                {
                    oClienteClave = new ClienteContacto();
                    oClienteClave.sClave = Convert.IsDBNull(oDataRead["sClave"]) ? string.Empty : Convert.ToString(oDataRead["sClave"]);
                }
                return oClienteClave;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (oCommand.Connection.State == ConnectionState.Open)
                {
                    oConexion.Close();
                }
            }
        }

        public Contacto ConsecutivoContacto()
        {
            try
            {
                oCommand.Connection = oConexion.Open();
                oCommand.CommandText = "SIR.usp_JJVZ_RSiguienteClaveContacto";
                oCommand.CommandType = System.Data.CommandType.StoredProcedure;
                oCommand.Parameters.Clear();
                oDataRead = oCommand.ExecuteReader();
                Contacto oContactoClave = new Contacto();
                while (oDataRead.Read())
                {
                    oContactoClave = new Contacto();
                    oContactoClave.ClaveContacto = Convert.IsDBNull(oDataRead["sClaveContacto"]) ? string.Empty : Convert.ToString(oDataRead["sClaveContacto"]);
                }
                return oContactoClave;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (oCommand.Connection.State == ConnectionState.Open)
                {
                    oConexion.Close();
                }
            }
        }

        public void GuardarContacto(Contacto ocontacto)
        {
            try
            {
                oCommand.Connection = oConexion.Open();
                oCommand.CommandText = "SIR.usp_JJVZ_CContactos";
                oCommand.CommandType = System.Data.CommandType.StoredProcedure;
                oCommand.Parameters.Clear();
                oCommand.Parameters.AddWithValue("@nIdContacto02", SqlDbType.Int).Direction = ParameterDirection.Output;
                oCommand.Parameters.AddWithValue("@sClaveContacto", ocontacto.ClaveContacto);
                oCommand.Parameters.AddWithValue("@sNombreContacto", ocontacto.NombreContacto);
                oCommand.Parameters.AddWithValue("@sPuesto", ocontacto.Puesto);
                oCommand.Parameters.AddWithValue("@nTelefonoContacto", ocontacto.TelefonoContacto);
                oCommand.Parameters.AddWithValue("@sEmailContacto", ocontacto.EmailContacto);
                oCommand.Parameters.AddWithValue("@nIdCliente01", ocontacto.IdClienteContacto);
                oDataRead = oCommand.ExecuteReader();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (oCommand.Connection.State == ConnectionState.Open)
                    oConexion.Close();
            }
        }

        public void ActualizaContacto(Contacto ocontacto)
        {
            try
            {
                oCommand.Connection = oConexion.Open();
                oCommand.CommandText = "SIR.usp_JJVZ_UContacto";
                oCommand.CommandType = System.Data.CommandType.StoredProcedure;
                oCommand.Parameters.Clear();
                oCommand.Parameters.AddWithValue("@nIdContacto02", ocontacto.IdContacto02);
                oCommand.Parameters.AddWithValue("@sClaveContacto", ocontacto.ClaveContacto);
                oCommand.Parameters.AddWithValue("@sNombreContacto", ocontacto.NombreContacto);
                oCommand.Parameters.AddWithValue("@sPuesto", ocontacto.Puesto);
                oCommand.Parameters.AddWithValue("@nTelefonoContacto", ocontacto.TelefonoContacto);
                oCommand.Parameters.AddWithValue("@sEmailContacto", ocontacto.EmailContacto);
                oDataRead = oCommand.ExecuteReader();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (oCommand.Connection.State == ConnectionState.Open)
                    oConexion.Close();
            }
        }


        public void EliminarPorIdContacto(int nIdContacto)
        {
            try
            {
                oCommand.Connection = oConexion.Open();
                oCommand.CommandText = "SIR.usp_JJVZ_DContactos";
                oCommand.CommandType = System.Data.CommandType.StoredProcedure;
                oCommand.Parameters.Clear();
                oCommand.Parameters.AddWithValue("@nIdContacto02", nIdContacto);
                oDataRead = oCommand.ExecuteReader();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (oCommand.Connection.State == ConnectionState.Open)
                    oConexion.Close();
            }
        }

        public List<Contacto> LeerContactoPorIdCliente(int nIdCliente)
        {
            List<Contacto> listContacto = new List<Contacto>();
            Contacto oContacto = new Contacto();

            try
            {
                oCommand.Connection = oConexion.Open();
                oCommand.CommandText = "SIR.usp_JJVZ_RContactoPorIdCliente";
                oCommand.CommandType = System.Data.CommandType.StoredProcedure;
                oCommand.Parameters.Clear();
                oCommand.Parameters.AddWithValue("@nIdCliente01", nIdCliente);
                oDataRead = oCommand.ExecuteReader();
                while (oDataRead.Read())
                {
                    oContacto = new Contacto();
                    oContacto.IdContacto02 = Convert.IsDBNull(oDataRead["nIdContacto02"]) ? 0 : Convert.ToInt16(oDataRead["nIdContacto02"]);
                    oContacto.ClaveContacto = Convert.IsDBNull(oDataRead["ClaveContacto"]) ? string.Empty : Convert.ToString(oDataRead["ClaveContacto"]);
                    oContacto.NombreContacto = Convert.IsDBNull(oDataRead["NombreContacto"]) ? string.Empty : Convert.ToString(oDataRead["NombreContacto"]);
                    oContacto.Puesto = Convert.IsDBNull(oDataRead["Puesto"]) ? string.Empty : Convert.ToString(oDataRead["Puesto"]);
                    oContacto.TelefonoContacto = Convert.IsDBNull(oDataRead["TelefonoContacto"]) ? string.Empty : Convert.ToString(oDataRead["TelefonoContacto"]);
                    oContacto.EmailContacto = Convert.IsDBNull(oDataRead["EmailContacto"]) ? string.Empty : Convert.ToString(oDataRead["EmailContacto"]);
                    oContacto.IdClienteContacto = Convert.IsDBNull(oDataRead["nIdCliente01"]) ? 0 : Convert.ToInt16(oDataRead["nIdCliente01"]);
                    listContacto.Add(oContacto);
                    oContacto = null;
                }
                return listContacto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (oCommand.Connection.State == ConnectionState.Open)
                    oConexion.Close();
            }
        }
        #endregion Metodos CRUD Contacto




    }
}