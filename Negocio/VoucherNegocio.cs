using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;
using AccesoDatos;

namespace Negocio
{
    public class VoucherNegocio
    {


        public Boolean listarVoucher(string codigo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Voucher> listado = new List<Voucher>();
            Voucher voucher;
            try
            {

                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: agregué todos los datos del voucher. Incluso su universo, que lo traigo con join.
                comando.CommandText = "select Id  From Vouchers Where CodigoVoucher =" + "'" + codigo + "'";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {                    
                    //seteamos en
                //    listado.Add(voucher);
                    return true;
                }
                return false;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }
/*
        public void agregarHeroeSP(Heroe heroeNuevo)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {
                accesoDatos.setearSP("agregarHeroe");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@Nombre", heroeNuevo.Nombre);
                accesoDatos.Comando.Parameters.AddWithValue("@Debilidad", heroeNuevo.Debilidad);
                //accesoDatos.Comando.Parameters.AddWithValue("@UC", modificar.UsaCapa);
                //accesoDatos.Comando.Parameters.AddWithValue("@Vol", modificar.Volador);
                //accesoDatos.Comando.Parameters.AddWithValue("@IdUni", modificar.Universo.Id);
                accesoDatos.abrirConexion();
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

        public void agregarHeroe(Heroe nuevo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: le agregué todas las columnas. Teniendo en cuenta inclusive lo que elegimos en el combo de selección..
                comando.CommandText = "insert into PERSONAJES (Nombre, Debilidad, UsaCapa, Volador, IdUniverso) values";
                comando.CommandText += "('" + nuevo.Nombre + "', '" + nuevo.Debilidad + "', '" + nuevo.UsaCapa.ToString() + "', '" + nuevo.Volador.ToString() + "'," + nuevo.Universo.Id.ToString() + ")";
                comando.Connection = conexion;
                conexion.Open();

                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

        public void modificarHeroe(Heroe modificar)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {
                accesoDatos.setearConsulta("update PERSONAJES Set Nombre=@Nombre, Debilidad=@Debilidad, UsaCapa=@UC, Volador=@Vol, IdUniverso=@IdUni Where Id=" + modificar.Id.ToString());
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@Nombre", modificar.Nombre);
                accesoDatos.Comando.Parameters.AddWithValue("@Debilidad", modificar.Debilidad);
                accesoDatos.Comando.Parameters.AddWithValue("@UC", modificar.UsaCapa);
                accesoDatos.Comando.Parameters.AddWithValue("@Vol", modificar.Volador);
                accesoDatos.Comando.Parameters.AddWithValue("@IdUni", modificar.Universo.Id);
                accesoDatos.abrirConexion();
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
        */
    }
}
