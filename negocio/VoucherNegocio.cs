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
                datos.setearConsulta("SELECT CodigoVoucher, IdCliente, FechaCanje, IdArticulo FROM Vouchers");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    v = new Voucher();
                    v.CodigoVoucher = (string)datos.Lector["CodigoVoucher"];
                    if(!(datos.Lector["IdCliente"] is DBNull)) v.IdCliente = (int)datos.Lector["IdCliente"];
                    if (!(datos.Lector["FechaCanje"] is DBNull)) v.FechaCanje = (DateTime)datos.Lector["FechaCanje"];
                    if (!(datos.Lector["IdArticulo"] is DBNull)) v.IdArticulo = (int)datos.Lector["IdArticulo"];
                    l.Add(v);
                }

                return l;
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

        public void Actualizar(Voucher v)
        {
            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                accesoDatos.setearConsulta("update VOUCHERS set IdCliente = @ic, FechaCanje = @fc, IdArticulo = @ia Where CodigoVoucher = @cv");
                accesoDatos.setearParametro("@ic", v.IdCliente);
                accesoDatos.setearParametro("@fc", v.FechaCanje);
                accesoDatos.setearParametro("@ia", v.IdArticulo);
                accesoDatos.setearParametro("@cv", v.CodigoVoucher);
                accesoDatos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;

            }
            finally
            {
                accesoDatos.cerrarConexion();
            }

        }
        public int ComprobarVoucher(List<Voucher> listVoucher, string voucher)
        {
            try
            {
                foreach (Voucher v in listVoucher)
                {
                    if (v.CodigoVoucher == voucher)
                    {
                        if (v.IdCliente > 0) 
                        {
                            return 1;
                        } else 
                        {
                            return 2;
                        } 
                    }
                }
                return 0;
            }
            catch (Exception)
            {

                throw;
            }            
        }
    }
}
