using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Hit.TurnoMatic.Model
{
    public class Usuario
    {

        public int IdUsuario { get; set; }
        public String Usuarios { get; set; }
        public String Clave { get; set; }
        public int IdRol { get; set; }
        public String Nombres { get; set; }
        public String Apellidos { get; set; }
        public int IdEstado { get; set; }
        public DateTime FechaSistema { get; set; }


    }
}
