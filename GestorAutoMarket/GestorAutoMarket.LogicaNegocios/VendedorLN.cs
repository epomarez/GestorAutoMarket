using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestorAutoMarket.Entidades;
using GestorAutoMarket.AccesoDatos;

namespace GestorAutoMarket.LogicaNegocios
{
    public class VendedorLN
    {
        public static bool addVendedor(Vendedor vendedor)
        {
            try
            {
                if (vendedor == null) return false;

                return AccesoDatos.DataAccess.addVendedor(vendedor);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el vendedor: " + ex.Message);

            }
        }

        public static Vendedor[] getVendedores()
        {
            try
            {
                return AccesoDatos.DataAccess.getVendedores();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener lista de vendedores: " + ex.Message);
            }
        }
    }
}
