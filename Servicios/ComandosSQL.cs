using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace _405369_Facturacion
{
    public class ComandosSQL
    {
        private string cadena_conexion = @"Data Source=ALFA\SQLEXPRESS;Initial Catalog = 405369-Facturacion; User ID = InteliCont; Password = IC21568552";
        private SqlConnection conexion = new SqlConnection();
        private SqlCommand comando = new SqlCommand();

        public void AbreConexionConTransaccion()
        {
            try
            {
                conexion.ConnectionString = cadena_conexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.Transaction = conexion.BeginTransaction();
            }
            catch (SqlException ex)
            {
                ProcesaError(ex);
            }

        }

        public void CierraConcexionConTransaccion()
        {
            try
            {
                comando.Transaction.Commit();
                conexion.Close();

            }
            catch (SqlException ex)
            {
                ProcesaError(ex);
            }

        }

        //public void CargaCombo(ComboBox combo, string SQLSP, string nombre_valuemember, string nombre_displaymember)
        //{
        //    try
        //    {
        //        AbreConexionConTransaccion();
        //        comando.CommandText = SQLSP;
        //        comando.CommandType = CommandType.Text;
        //        DataTable tabla = new DataTable();
        //        tabla.Load(comando.ExecuteReader());
        //        CierraConcexionConTransaccion();
        //        combo.DataSource = tabla;
        //        combo.ValueMember = nombre_valuemember;
        //        combo.DisplayMember = nombre_displaymember;
        //        combo.SelectedIndex = -1;
        //    }
        //    catch (SqlException ex)
        //    {
        //        ProcesaError(ex);
        //    }

        //}

        public SqlDataReader? EjecutaLectorSP(string SQLSP, List<SqlParameter> parametros)
        {
            try
            {
                comando.CommandText = SQLSP;
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                foreach (SqlParameter par in parametros) 
                {
                    comando.Parameters.Add(par);
                }
                return comando.ExecuteReader();
            }
            catch (SqlException ex)
            {
                ProcesaError(ex);
                return  null;
            }

        }

        public void EjecutaSP(string SQLSP, List<SqlParameter> parametros)
        {
            try
            {
                comando.CommandText = SQLSP;
                comando.Parameters.Clear();
                foreach (SqlParameter param in parametros)
                {
                    comando.Parameters.Add(param);
                }
                comando.CommandType = CommandType.StoredProcedure;
                comando.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                ProcesaError(ex);
            }
        }

        public void ProcesaError(SqlException ex)

        {
            MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (conexion.State == System.Data.ConnectionState.Open)
            {
                comando.Transaction.Rollback();
                conexion.Close();
            }
            Application.Exit();
        }



    }
}
