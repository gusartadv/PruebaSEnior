using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class Service1 : IService1
    {
        string cadenaConexion = ConfigurationManager.ConnectionStrings["myConexion"].ConnectionString;

        public misDatos consultar(int id, string descripcion, int tipo, int tipoConsulta)
        {
            misDatos misDatos = new misDatos();
            try
            {
                SqlConnection cnn = new SqlConnection(cadenaConexion);
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SpPruebaS", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@tipo", tipo);
                cmd.Parameters.AddWithValue("@tipoConsulta", tipoConsulta);

                SqlDataAdapter rd = new SqlDataAdapter(cmd);
                SqlDataReader dataR = rd.SelectCommand.ExecuteReader();
                if (dataR.HasRows)
                {
                    if (dataR.Read())
                    {
                        misDatos.Id = dataR.GetInt32(0);
                        misDatos.Descripcion = dataR.GetString(1);
                        misDatos.Tipo = dataR.GetInt32(2);
                    }
                }

                cnn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("ERROR DE consulta", ex);
            }
            return misDatos;
        }

        public int eliminar(int id, string descripcion, int tipo, int tipoConsulta)
        {
            int res = 0;
            try
            {
                SqlConnection cnn = new SqlConnection(cadenaConexion);
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SpPruebaS", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@tipo", tipo);
                cmd.Parameters.AddWithValue("@tipoConsulta", tipoConsulta);

                cmd.ExecuteNonQuery();
                res = 1;
                cnn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("ERROR DE ELIMINACION", ex);
            }
            return res;
        }

        public int insertar(int id, string descripcion, int tipo, int tipoConsulta)
        {
            int res = 0;
            try
            {
                SqlConnection cnn = new SqlConnection(cadenaConexion);
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SpPruebaS", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@tipo", tipo);
                cmd.Parameters.AddWithValue("@tipoConsulta", tipoConsulta);

                cmd.ExecuteNonQuery();
                res = 1;
                cnn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("ERROR DE INSERCION", ex);
            }
            return res;

        }

        public int modificar(int id, string descripcion, int tipo, int tipoConsulta)
        {
            int res = 0;
            try
            {
                SqlConnection cnn = new SqlConnection(cadenaConexion);
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SpPruebaS", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@tipo", tipo);
                cmd.Parameters.AddWithValue("@tipoConsulta", tipoConsulta);

                cmd.ExecuteNonQuery();
                res = 1;
                cnn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("ERROR DE modificacion", ex);
            }
            return res;
        }

        public List<misDatos> mostrarTodos(int id, string descripcion, int tipo, int tipoConsulta)
        {
            List<misDatos> lista = new List<misDatos>();
            try
            {
                SqlConnection cnn = new SqlConnection(cadenaConexion);
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SpPruebaS", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@tipo", tipo);
                cmd.Parameters.AddWithValue("@tipoConsulta", tipoConsulta);

                SqlDataAdapter rd = new SqlDataAdapter(cmd);
                SqlDataReader dataR = rd.SelectCommand.ExecuteReader();
                if (dataR.HasRows)
                {
                    while (dataR.Read())
                    {
                        lista.Add(new misDatos
                        {
                            Id = dataR.GetInt32(0),
                            Descripcion = dataR.GetString(1),
                            Tipo = dataR.GetInt32(2)

                        });
                    }
                }

                cnn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("ERROR DE consulta2", ex);
            }
            return lista;
        }
    }
}
