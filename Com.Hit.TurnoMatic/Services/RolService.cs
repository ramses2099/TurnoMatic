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
    public class RolService : IDisposable
    {
        public const String TAG = "RolService";
        bool disposed = false;

        public RolService()
        {


        }

        //
        public Rol GetRol(int IdRol)
        {

            Rol _Rol = null;
            SqlDatabase _Db = null;
            StringBuilder sql = new StringBuilder();

            sql.AppendLine("SELECT [IdRol] ,[Descripcion] ,[IdEstado] ,[FechaSistema] ");
            sql.AppendFormat("FROM[dbo].[Rol] WHERE[IdRol] = {0};", IdRol);

            
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

                            _Rol =RolMap(reader);

                        }
                    }

                }


            }
            catch (Exception ex)
            {
                Com.Hit.TurnoMatic.Utils.Log.LogError(TAG, "GetRol", ex);
            }

            return _Rol;

        }
        //
        private Rol RolMap(IDataReader reader)
        {

            Rol _instance = new Rol();

            try
            {


                while (reader.Read())
                {

                    _instance.IdRol = reader["IdRol"] != DBNull.Value ? Convert.ToInt32(reader["IdRol"]) : 0;
                    _instance.Descripcion = reader["Descripcion"] != DBNull.Value ? Convert.ToString(reader["Descripcion"]) : "";
                    _instance.IdEstado = reader["IdEstado"] != DBNull.Value ? Convert.ToInt32(reader["IdEstado"]) : 0;
                    _instance.FechaSistema = reader["FechaSistema"] != DBNull.Value ? Convert.ToDateTime(reader["FechaSistema"]) : DateTime.Now;

                }


            }
            catch (Exception ex)
            {
                Com.Hit.TurnoMatic.Utils.Log.LogError(TAG, "RolMap", ex);
            }

            return _instance;
        }


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
