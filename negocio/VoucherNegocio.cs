using dominio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class VoucherNegocio
    {
        public List<Voucher> Listar()
        {
            List<Voucher> l = new List<Voucher>();
            AccesoDatos datos = new AccesoDatos();
            Voucher v = null;

            try
            {
                datos.setearConsulta("select * from Vouchers");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    v = new Voucher();
                    v.CodigoVoucher = (string)datos.Lector["CodigoVoucher"];
                    v.IdCliente = (int)datos.Lector["IdCliente"];
                    v.FechaCanje = (DateTime)datos.Lector["FechaCanje"];
                    v.IdArticulo = (int)datos.Lector["IdArticulo"];
                    l.Add(v);
                }

                return l;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void Modificar(Voucher v)
        {
            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                accesoDatos.setearConsulta("update ARTICULOS set IdCliente = @ic, FechaCanje = @fc, IdArticulo = @ia, Where CodigoVoucher = @cv");
                accesoDatos.setearParametro("@ic", v.IdCliente);
                accesoDatos.setearParametro("@fc", v.FechaCanje);
                accesoDatos.setearParametro("@ia", v.IdArticulo);
                accesoDatos.setearParametro("@cv", v.CodigoVoucher);
                accesoDatos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }

        }
    }
}
