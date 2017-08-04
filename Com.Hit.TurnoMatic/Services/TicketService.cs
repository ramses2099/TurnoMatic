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
    public class TicketService : IDisposable
    {
        public const String TAG = "TicketService";
        bool disposed = false;

        public TicketService()
        {


        }

        //
        public int AddTicket(int IdTipoServicio)
        {

            int rs = 0;
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

                    using (DbCommand _DbCommand = _Db.GetStoredProcCommand("dbo.AddTicket"))
                    {
                        _DbCommand.Connection = connetion;

                        _DbCommand.Parameters.Add(new SqlParameter() { ParameterName = "@IdTipoServicio", SqlDbType = SqlDbType.Int, Value = IdTipoServicio });

                        rs = Convert.ToInt32(_DbCommand.ExecuteScalar());

                    }

                }


            }
            catch (Exception ex)
            {
                Com.Hit.TurnoMatic.Utils.Log.LogError(TAG, "AddTicket", ex);
            }

            return rs;

        }
        //
        public void ChangeEstatusTicket(int IdTicket, EstatusTicket Estatus)
        {


            SqlDatabase _Db = null;
            int IdEstatusTicket = 0;

            switch (Estatus)
            {
                case EstatusTicket.Libre:
                    IdEstatusTicket = 1;
                    break;
                case EstatusTicket.Seleccionado:
                    IdEstatusTicket = 2;
                    break;
                case EstatusTicket.Completado:
                    IdEstatusTicket = 3;
                    break;
                case EstatusTicket.NosePresento:
                    IdEstatusTicket = 4;
                    break;
                default:
                    break;
            }


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

                    using (DbCommand _DbCommand = _Db.GetStoredProcCommand("dbo.ChangeEstatusTicket"))
                    {
                        _DbCommand.Connection = connetion;

                        _DbCommand.Parameters.Add(new SqlParameter() { ParameterName = "@IdEstatusTicket", SqlDbType = SqlDbType.Int, Value = IdEstatusTicket });

                        _DbCommand.Parameters.Add(new SqlParameter() { ParameterName = "@IdTicket", SqlDbType = SqlDbType.Int, Value = IdTicket });

                        _DbCommand.ExecuteNonQuery();

                    }

                }


            }
            catch (Exception ex)
            {
                Com.Hit.TurnoMatic.Utils.Log.LogError(TAG, "ChangeEstatusTicket", ex);
            }



        }
        //
        public void EnviaRevision(int IdCaja, int IdTicket)
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

                    using (DbCommand _DbCommand = _Db.GetStoredProcCommand("dbo.EnviaRevision"))
                    {
                        _DbCommand.Connection = connetion;

                        _DbCommand.Parameters.Add(new SqlParameter() { ParameterName = "@IdCaja", SqlDbType = SqlDbType.Int, Value = IdCaja });

                        _DbCommand.Parameters.Add(new SqlParameter() { ParameterName = "@IdTicket", SqlDbType = SqlDbType.Int, Value = IdTicket });

                        _DbCommand.ExecuteNonQuery();

                    }

                }

            }
            catch (Exception ex)
            {
                Com.Hit.TurnoMatic.Utils.Log.LogError(TAG, "EnviaRevision", ex);
            }


        }
        //
        public int EnviaRevisionListo(int IdCaja, int NumTicket)
        {

            SqlDatabase _Db = null;
            int rs = 0;

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

                    using (DbCommand _DbCommand = _Db.GetStoredProcCommand("dbo.EnviaRevisionListo"))
                    {
                        _DbCommand.Connection = connetion;

                        _DbCommand.Parameters.Add(new SqlParameter() { ParameterName = "@IdCaja", SqlDbType = SqlDbType.Int, Value = IdCaja });

                        _DbCommand.Parameters.Add(new SqlParameter() { ParameterName = "@NumTicket", SqlDbType = SqlDbType.Int, Value = NumTicket });

                        rs = Convert.ToInt32(_DbCommand.ExecuteScalar());

                    }

                }

            }
            catch (Exception ex)
            {
                Com.Hit.TurnoMatic.Utils.Log.LogError(TAG, "EnviaRevisionListo", ex);
            }

            return rs;

        }
        //
        public void RegresarTicketCola(int IdTicket)
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

                    using (DbCommand _DbCommand = _Db.GetStoredProcCommand("dbo.RegresarTicketCola"))
                    {
                        _DbCommand.Connection = connetion;

                        _DbCommand.Parameters.Add(new SqlParameter() { ParameterName = "@IdTicket", SqlDbType = SqlDbType.Int, Value = IdTicket });

                        _DbCommand.ExecuteNonQuery();

                    }

                }

            }
            catch (Exception ex)
            {
                Com.Hit.TurnoMatic.Utils.Log.LogError(TAG, "RegresarTicketCola", ex);
            }


        }
        //
        public List<TicketNoSePresento> GetTicketNoSePresento()
        {

            List<TicketNoSePresento> _List = new List<TicketNoSePresento>();
            SqlDatabase _Db = null;
            StringBuilder sql = new StringBuilder();

            sql.AppendLine(" SELECT t.IdTicket, t.Secuencia as NumeroTicket, Convert(varchar(10),t.FechaSistema,103) as FechaSistema ");
            sql.AppendLine("  FROM dbo.Ticket t  WHERE  t.IdEstatusTicket = 4 and t.IdEstado = 1 ");

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

                                TicketNoSePresento _instance = new TicketNoSePresento();
                                _instance.IdTicket = reader["IdTicket"] != DBNull.Value ? Convert.ToInt32(reader["IdTicket"]) : 0;
                                _instance.NumeroTicket = Convert.ToInt32(reader["NumeroTicket"]) != 0 ? Convert.ToInt32(reader["NumeroTicket"]) : 0;
                                _instance.FechaSistema = Convert.ToString(reader["FechaSistema"]) != "" ? Convert.ToString(reader["FechaSistema"]) : "";

                                _List.Add(_instance);
                            }

                        }
                    }

                }


            }
            catch (Exception ex)
            {
                Com.Hit.TurnoMatic.Utils.Log.LogError(TAG, "GetTicketNoSePresento", ex);
            }

            return _List;

        }
        //
        public void ResetSecuencia()
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

                    using (DbCommand _DbCommand = _Db.GetStoredProcCommand("dbo.ResetSecuencia"))
                    {
                        _DbCommand.Connection = connetion;

                        _DbCommand.ExecuteNonQuery();

                    }

                }

            }
            catch (Exception ex)
            {
                Com.Hit.TurnoMatic.Utils.Log.LogError(TAG, "ResetSecuencia", ex);
            }


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
