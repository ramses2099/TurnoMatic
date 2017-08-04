using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Hit.TurnoMatic.Model
{
    public class LlamarCliente
    {
        public int IdLlamarCliente { get; set; }

        public int IdCaja { get; set; }

        public string Caja { get; set; }
        
        public int NumeroTicket { get; set; }        
        
        public int IdEstado { get; set; }

        public string Estatus { get; set; }
        
        public DateTime FechaSistema { get; set; }

    }
}
