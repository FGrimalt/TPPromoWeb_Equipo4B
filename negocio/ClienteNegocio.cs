using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class ClienteNegocio
    {
        public int agregar(Clientes cliente)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("INSERT INTO CLIENTES (Documento, Nombre, Apellido, Email, Direccion, Ciudad, CP) " +
                                     "VALUES (@dni, @nombre, @apellido, @email, @direccion, @ciudad, @cp)" +
                                     "SELECT SCOPE_IDENTITY();"
                                    );

                datos.setearParametro("@dni", cliente.Documento);
                datos.setearParametro("@nombre", cliente.Nombre);
                datos.setearParametro("@apellido", cliente.Apellido);
                datos.setearParametro("@email", cliente.Email);
                datos.setearParametro("@direccion", cliente.Direccion);
                datos.setearParametro("@ciudad", cliente.Ciudad);
                datos.setearParametro("@cp", cliente.CP);

                int idNuevoCliente = datos.ejecutarReturn();
                return idNuevoCliente;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public Clientes ChequearDNI(int dni)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT * FROM CLIENTES WHERE Documento = @dni");
                datos.setearParametro("@dni", dni);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    Clientes cliente = new Clientes();
                    cliente.Id = Convert.ToInt32(datos.Lector["Id"]);
                    cliente.Documento = Convert.ToString(datos.Lector["Documento"]);
                    cliente.Nombre = Convert.ToString(datos.Lector["Nombre"]);
                    cliente.Apellido = Convert.ToString(datos.Lector["Apellido"]);
                    cliente.Email = Convert.ToString(datos.Lector["Email"]);
                    cliente.Direccion = Convert.ToString(datos.Lector["Direccion"]);
                    cliente.Ciudad = datos.Lector["Ciudad"].ToString();
                    cliente.CP = Convert.ToInt32(datos.Lector["CP"]);
                    return cliente;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
