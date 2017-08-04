using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Hit.TurnoMatic.Model;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Com.Hit.TurnoMatic.Utils;
using Microsoft.Practices.EnterpriseLibrary.Data;


namespace Com.Hit.TurnoMatic.Services
{
    public class LlamarClienteService : IDisposable
    {
        public const String TAG = "LlamarClienteService";
        bool disposed = false;

        public LlamarClienteService()
        {


        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="IdCaja"></param>
        /// <param name="IdTicket"></param>
        public void LlamarCliente(int IdCaja, int NumeroTicket)
        {

            SqlDatabase _Db = null;

            try
            {
                DatabaseProviderFactory factory = new DatabaseProviderFactory();

                _Db = factory.CreateDefault() as SqlDatabase;

                using (DbConnection connetion = _Db.CreateConnection())
                {

                    if (connetion.State == ConnectionState.Closed)
                    {
                        connetion.Open();
                    }

                    using (DbCommand _DbCommand = _Db.GetStoredProcCommand("dbo.AddLlamarCliente"))
                    {
                        _DbCommand.Connection = connetion;

                        _DbCommand.Parameters.Add(new SqlParameter() { ParameterName = "@IdCaja", SqlDbType = SqlDbType.Int, Value = IdCaja });

                        _DbCommand.Parameters.Add(new SqlParameter() { ParameterName = "@NumeroTicket", SqlDbType = SqlDbType.Int, Value = NumeroTicket });

                        _DbCommand.ExecuteNonQuery();

                    }

                }

            }
            catch (Exception ex)
            {
                Com.Hit.TurnoMatic.Utils.Log.LogError(TAG, "LlamarCliente", ex);
            }


        }
        //

        public void ChangeLlamarCliente(int NumeroTicket)
        {

            SqlDatabase _Db = null;

            try
            {
                DatabaseProviderFactory factory = new DatabaseProviderFactory();

                _Db = factory.CreateDefault() as SqlDatabase;

                using (DbConnection connetion = _Db.CreateConnection())
                {

                    if (connetion.State == ConnectionState.Closed)
                    {
                        connetion.Open();
                    }

                    using (DbCommand _DbCommand = _Db.GetStoredProcCommand("dbo.ChangeLlamarCliente"))
                    {
                        _DbCommand.Connection = connetion;

                        _DbCommand.Parameters.Add(new SqlParameter() { ParameterName = "@NumeroTicket", SqlDbType = SqlDbType.Int, Value = NumeroTicket });

                        _DbCommand.ExecuteNonQuery();

                    }

                }

            }
            catch (Exception ex)
            {
                Com.Hit.TurnoMatic.Utils.Log.LogError(TAG, "LlamarCliente", ex);
            }


        }


        public LlamarCliente GetLlamarCliente()
        {

            SqlDatabase _Db = null;
            LlamarCliente _instance = null;

            try
            {
                string sql = "SELECT TOP 1 * FROM  dbo.VistaLlamarCliente  WHERE IdEstado = 1 ORDER BY FechaSistema ASC";

                DatabaseProviderFactory factory = new DatabaseProviderFactory();

                _Db = factory.CreateDefault() as SqlDatabase;

                using (DbConnection connetion = _Db.CreateConnection())
                {

                    if (connetion.State == ConnectionState.Closed)
                    {
                        connetion.Open();
                    }

                    using (DbCommand _DbCommand = _Db.GetSqlStringCommand(sql))
                    {
                        _DbCommand.Connection = connetion;

                        using (IDataReader reader = _DbCommand.ExecuteReader())
                        {


                            while (reader.Read())
                            {
                                _instance = new LlamarCliente();
                                _instance.IdLlamarCliente = reader["IdLlamarCliente"] != DBNull.Value ? Convert.ToInt32(reader["IdLlamarCliente"]) : 0;
                                _instance.IdCaja = reader["IdCaja"] != DBNull.Value ? Convert.ToInt32(reader["IdCaja"]) : 0;
                                _instance.Caja = reader["Descripcion"] != DBNull.Value ? reader["Descripcion"].ToString() : "";
                                _instance.NumeroTicket = reader["NumeroTicket"] != DBNull.Value ? Convert.ToInt32(reader["NumeroTicket"]) : 0;
                                _instance.IdEstado = reader["IdEstado"] != DBNull.Value ? Convert.ToInt32(reader["IdEstado"]) : 0;
                                _instance.Estatus = reader["Estatus"] != DBNull.Value ? reader["Estatus"].ToString() : "";
                                _instance.FechaSistema = reader["FechaSistema"] != DBNull.Value ? Convert.ToDateTime(reader["FechaSistema"]) : DateTime.Now;

                            }

                        }
                    }

                }


            }
            catch (Exception ex)
            {
                Com.Hit.TurnoMatic.Utils.Log.LogError(TAG, "GetLlamarCliente", ex);
            }

            return _instance;
        }
        //         

        #region "DISPOSABLE"

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);

        }
        //
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposed)
            {

            }

            disposed = true;

        }


        #endregion

    }
}
