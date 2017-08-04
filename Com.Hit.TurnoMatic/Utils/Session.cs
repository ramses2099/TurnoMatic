using Com.Hit.TurnoMatic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Hit.TurnoMatic.Utils
{
    public class Session
    {
        private Usuario _Usuario;

        private Session() { }

        private static Session _Intance = null;

        public static Session Intance
        {
            get
            {
                if (_Intance == null)
                {
                    _Intance = new Session();
                }

                return _Intance;
            }

        }
        //
        public Usuario CurrentSession
        {
            get
            {
                return _Usuario;
            }
            set
            {
                _Usuario = value;
            }
        }


    }
}
