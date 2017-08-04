using Com.Hit.TurnoMatic.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data.Common;
using System.Data.SqlClient;
using Com.Hit.TurnoMatic.Utils;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace Com.Hit.TurnoMatic.Services
{
    public class CajaService : IDisposable
    {
        public const String TAG = "CajaService";
        bool disposed = false;

        public CajaService()
        {


        }

        //
        public Caja GetCajaByIdUsuario(int IdUsuario)
        {

            Caja _Caja = null;
            SqlDatabase _Db = null;
            StringBuilder sql = new StringBuilder();

            sql.AppendLine("SELECT [IdCaja],[Descripcion],[IdUsuario],[IdEstado] ");
            sql.AppendFormat(",[FechaSistema] FROM[dbo].[Caja] WHERE IdUsuario = {0};", IdUsuario);

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

                    using (DbCommand _DbCommand = _Db.GetSqlStringCommand(sql.ToString()))
                    {
                        _DbCommand.Connection = connetion;

                        using (IDataReader reader = _DbCommand.ExecuteReader())
                        {

                            _Caja = CajaMap(reader);

                        }
                    }

                }


            }
            catch (Exception ex)
            {
                Com.Hit.TurnoMatic.Utils.Log.LogError(TAG, "GetCajaByIdUsuario", ex);
            }

            return _Caja;

        }
        //
        public List<VistaTurnosEnCaja> GetRevisionLista()
        {

            List<VistaTurnosEnCaja> _List = new List<VistaTurnosEnCaja>();
            SqlDatabase _Db = null;
            StringBuilder sql = new StringBuilder();

            sql.AppendLine("SELECT [TurnosFP],[Revision],[RevisionLista]  FROM [dbo].[VistaTurnosEnCaja] ");


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

                    using (DbCommand _DbCommand = _Db.GetSqlStringCommand(sql.ToString()))
                    {
                        _DbCommand.Connection = connetion;

                        using (IDataReader reader = _DbCommand.ExecuteReader())
                        {

                            while (reader.Read())
                            {

                                VistaTurnosEnCaja _instance = new VistaTurnosEnCaja();
                                _instance.TurnosFP = Convert.ToInt32(reader["TurnosFP"]) != 0 ? Convert.ToString(reader["TurnosFP"]) : "";
                                _instance.Revision = Convert.ToInt32(reader["Revision"]) != 0 ? Convert.ToString(reader["Revision"]) : "";
                                _instance.RevisionLista = Convert.ToInt32(reader["RevisionLista"]) != 0 ? Convert.ToString(reader["RevisionLista"]) : "";

                                _List.Add(_instance);
                            }

                        }
                    }

                }


            }
            catch (Exception ex)
            {
                Com.Hit.TurnoMatic.Utils.Log.LogError(TAG, "GetRevisionLista", ex);
            }

            return _List;

        }
        //
        public Ticket TurnoSiguiente(int IdTipoServicio, int IdCaja)
        {

            SqlDatabase _Db = null;
            Ticket _instance = null;

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

                    using (DbCommand _DbCommand = _Db.GetStoredProcCommand("dbo.TurnoSiguiente"))
                    {
                        _DbCommand.Connection = connetion;

                        _DbCommand.Parameters.Add(new SqlParameter() { ParameterName = "@IdTipoServicio", SqlDbType = SqlDbType.Int, Value = IdTipoServicio });

                        _DbCommand.Parameters.Add(new SqlParameter() { ParameterName = "@IdCaja", SqlDbType = SqlDbType.Int, Value = IdCaja });

                        using (IDataReader reader = _DbCommand.ExecuteReader())
                        {


                            while (reader.Read())
                            {
                                _instance = new Ticket();
                                _instance.IdTicket = reader["IdTicket"] != DBNull.Value ? Convert.ToInt32(reader["IdTicket"]) : 0;
                                _instance.Secuencia = reader["Turno"] != DBNull.Value ? Convert.ToInt32(reader["Turno"]) : 0;
                            }

                        }
                    }

                }


            }
            catch (Exception ex)
            {
                Com.Hit.TurnoMatic.Utils.Log.LogError(TAG, "TurnoSiguiente", ex);
            }

            return _instance;
        }
        //              
        public void TiempoEnCaja(int IdCaja, int IdTicket, int Opcion)
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

                    using (DbCommand _DbCommand = _Db.GetStoredProcCommand("dbo.TimeInCaja"))
                    {
                        _DbCommand.Connection = connetion;

                        _DbCommand.Parameters.Add(new SqlParameter() { ParameterName = "@IdCaja", SqlDbType = SqlDbType.Int, Value = IdCaja });

                        _DbCommand.Parameters.Add(new SqlParameter() { ParameterName = "@IdTicket", SqlDbType = SqlDbType.Int, Value = IdTicket });

                        _DbCommand.Parameters.Add(new SqlParameter() { ParameterName = "@Opcion", SqlDbType = SqlDbType.Int, Value = Opcion });


                        _DbCommand.ExecuteNonQuery();
                    }

                }

            }
            catch (Exception ex)
            {
                Com.Hit.TurnoMatic.Utils.Log.LogError(TAG, "TiempoEnCaja", ex);
            }

        }
        //
        public List<TurnosPantalla> GetTurnosPantalla()
        {

            List<TurnosPantalla> _List = new List<TurnosPantalla>();
            SqlDatabase _Db = null;
            TurnosPantalla _instance = null;
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

                    using (DbCommand _DbCommand = _Db.GetStoredProcCommand("dbo.TurnosPantalla"))
                    {
                        _DbCommand.Connection = connetion;

                        using (IDataReader reader = _DbCommand.ExecuteReader())
                        {
                            
                            while (reader.Read())
                            {
                                _instance = new TurnosPantalla();
                                _instance.IdTicket = reader["IdTicket"] != DBNull.Value ? Convert.ToInt32(reader["IdTicket"]) : 0;
                                _instance.NumTicket = reader["NumTicket"] != DBNull.Value ? Convert.ToInt32(reader["NumTicket"]) : 0;
                                _instance.IdCaja = reader["IdCaja"] != DBNull.Value ? Convert.ToInt32(reader["IdCaja"]) : 0;

                                _List.Add(_instance);
                            }

                        }
                    }

                }


            }
            catch (Exception ex)
            {
                Com.Hit.TurnoMatic.Utils.Log.LogError(TAG, "GetTurnosPantalla", ex);
            }

            return _List;

        }
        //





        //
        private Caja CajaMap(IDataReader reader)
        {

            Caja _instance = new Caja();

            try
            {


                while (reader.Read())
                {

                    _instance.IdCaja = reader["IdCaja"] != DBNull.Value ? Convert.ToInt32(reader["IdCaja"]) : 0;
                    _instance.Descripcion = reader["Descripcion"] != DBNull.Value ? Convert.ToString(reader["Descripcion"]) : "";
                    _instance.IdEstado = reader["IdEstado"] != DBNull.Value ? Convert.ToInt32(reader["IdEstado"]) : 0;
                    _instance.FechaSistema = reader["FechaSistema"] != DBNull.Value ? Convert.ToDateTime(reader["FechaSistema"]) : DateTime.Now;

                }


            }
            catch (Exception ex)
            {
                Com.Hit.TurnoMatic.Utils.Log.LogError(TAG, "CajaMap", ex);
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


