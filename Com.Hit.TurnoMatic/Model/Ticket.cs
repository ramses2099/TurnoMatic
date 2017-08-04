using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Hit.TurnoMatic.Model
{
    public class Ticket
    {
        public int IdTicket { get; set; }
        public int Secuencia { get; set; }
        public int IdTipoServicio { get; set; }
        public int IdEstado { get; set; }
        public DateTime FechaSistema { get; set; }

    }
}
