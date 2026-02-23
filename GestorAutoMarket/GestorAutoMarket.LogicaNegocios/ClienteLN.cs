using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestorAutoMarket.Entidades;

namespace GestorAutoMarket.LogicaNegocios
{
    public class ClienteLN
    {
        public static bool addCliente(Cliente cliente)
        {
            try
            {
                if (cliente == null) return false;
                return AccesoDatos.DataAccess.addCliente(cliente);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el cliente: " + ex.Message);
            }
        }

        public static Cliente[] getClientes()
        {
            try
            {
                return AccesoDatos.DataAccess.getClientes();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener lista de clientes: " + ex.Message);
            }
        }
    }
}
