using ExamenCC.DAO;
using ExamenCC.Entity;
using System;
using System.Collections.Generic;

namespace ExamenCC.BL
{
    public class ClienteContactoBL
    {

        #region Variable
        private ClienteContactoDAO DAO ;
        #endregion Variable

        #region Constructor
        public ClienteContactoBL()
        {
            DAO = new ClienteContactoDAO();
        }
        #endregion Constructor

        #region Metodos Cliente

        #region Cliente
        public void GuardarCliente(ClienteContacto clienteContacto, int nOpcion)
        {
            try
            {

                DAO.GuardarCliente(clienteContacto, nOpcion);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ActualizarCliente(ClienteContacto clienteContacto, int nOpcion)
        {
            try
            {
                DAO.ActualizarCliente(clienteContacto, nOpcion);
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
                DAO.EliminarPorIdCliente(nIdCliente);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<ClienteContacto> ListaClienteGeneral()
        {
            try
            {
                return DAO.ListaClienteAll();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public ClienteContacto ClientePorId(int idCliente)
        {
            try
            {
                return DAO.ClientePorId(idCliente);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public ClienteContacto claveConsecutivo() 
        {
            try
            {
                return DAO.ConsecutivoCliente();
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion Cliente

        #endregion Metodos Cliente


        #region Metodos Contacto

        #region Contacto

        public Contacto claveConsecutivoContacto()
        {
            try
            {
                return DAO.ConsecutivoContacto();
            }
            catch (Exception)
            {

                throw;
            }
        }


        public List<Contacto> ContactoPorId(int idCliente)
        {
            try
            {
                return DAO.LeerContactoPorIdCliente(idCliente);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void GuardarContacto(Contacto clienteContacto)
        {
            try
            {
                DAO.GuardarContacto(clienteContacto);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ActualizarContacto(Contacto clienteContacto)
        {
            try
            {
                DAO.ActualizaContacto(clienteContacto);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void EliminarPorIdContacto(int nIdContacto)
        {
            try
            {
                DAO.EliminarPorIdContacto(nIdContacto);
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion Cliente
        #endregion Metodos Contacto

    }
}
