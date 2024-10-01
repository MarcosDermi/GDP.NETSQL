using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Datos
    {
        private SqlConnection oCnn = new SqlConnection(@"Data Source=.\;Initial Catalog=TP1;Integrated Security=True");

        SqlCommand cmd;

        public DataTable Leer(string consulta)
        {
            DataTable tabla = new DataTable();
            try
            {
                SqlDataAdapter Da = new SqlDataAdapter(consulta, oCnn);

                Da.Fill(tabla);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { oCnn.Close(); }

            return tabla;
        }

        public bool LeerScalar(string consulta)
        {
            oCnn.Open();
            cmd = new SqlCommand(consulta, oCnn);
            cmd.CommandType = CommandType.Text;
            try
            {
                int Respuesta = Convert.ToInt32(cmd.ExecuteScalar());
                oCnn.Close();
                if (Respuesta > 0)
                { return true; }
                else
                { return false; }
            }
            catch (SqlException ex)
            { throw ex; }
            finally
            {
                oCnn.Close();
            }
        }

        public bool Escribir(string Consulta_SQL)
        {
            oCnn.Open();
            SqlTransaction oSQLTrans;
            cmd = new SqlCommand();
            oSQLTrans = oCnn.BeginTransaction();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = oCnn;
            cmd.CommandText = Consulta_SQL;

            try
            {
                cmd.Transaction = oSQLTrans;
                int respuesta = cmd.ExecuteNonQuery();
                oSQLTrans.Commit();
                return true;
            }
            catch (SqlException ex)
            {
                oSQLTrans.Rollback();
                throw ex;
            }
            catch (Exception ex)
            {
                oSQLTrans.Rollback();
                throw ex;
            }
            finally { oCnn.Close(); }
        }

    }
}
