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
    public class UsuarioService : IDisposable
    {
        public const String TAG = "UsuarioService";
        bool disposed = false;

        public UsuarioService()
        {


        }

        //
        public Usuario ValidaUsuario(string UserName, string Clave)
        {

            Usuario _Usuario = null;
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

                    using (DbCommand _DbCommand = _Db.GetStoredProcCommand("dbo.ValidaUsuario"))
                    {
                        _DbCommand.Connection = connetion;

                        _DbCommand.Parameters.Add(new SqlParameter() { ParameterName = "@Usuario", SqlDbType = SqlDbType.VarChar, Value = UserName });

                        _DbCommand.Parameters.Add(new SqlParameter() { ParameterName = "@Clave", SqlDbType = SqlDbType.VarChar, Value = Clave });

                        using (IDataReader reader = _DbCommand.ExecuteReader())
                        {

                            _Usuario = UsuarioMap(reader);

                        }
                    }

                }
                

            }
            catch (Exception ex)
            {
                Com.Hit.TurnoMatic.Utils.Log.LogError(TAG, "ValidaUsuario", ex);
            }

            return _Usuario;

        }
        //
        private Usuario UsuarioMap(IDataReader reader)
        {

            Usuario _instance = new Usuario();

            try
            {


                while (reader.Read())
                {

                    _instance.IdUsuario = reader["IdUsuario"] != DBNull.Value ? Convert.ToInt32(reader["IdUsuario"]) : 0;
                    _instance.Clave = reader["Clave"] != DBNull.Value ? Convert.ToString(reader["Clave"]) : "";
                    _instance.IdRol = reader["IdRol"] != DBNull.Value ? Convert.ToInt32(reader["IdRol"]) : 0;
                    _instance.Nombres = reader["Nombres"] != DBNull.Value ? Convert.ToString(reader["Nombres"]) : "";
                    _instance.Apellidos = reader["Apellidos"] != DBNull.Value ? Convert.ToString(reader["Apellidos"]) : "";
                    _instance.IdEstado = reader["IdEstado"] != DBNull.Value ? Convert.ToInt32(reader["IdEstado"]) : 0;
                    _instance.FechaSistema = reader["FechaSistema"] != DBNull.Value ? Convert.ToDateTime(reader["FechaSistema"]) : DateTime.Now;

                }


            }
            catch (Exception ex)
            {
                Com.Hit.TurnoMatic.Utils.Log.LogError(TAG, "UsuarioMap", ex);
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
