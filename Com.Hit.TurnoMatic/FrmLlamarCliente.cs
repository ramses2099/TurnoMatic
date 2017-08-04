using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;
using Com.Hit.TurnoMatic.Model;
using Com.Hit.TurnoMatic.Services;
using Com.Hit.TurnoMatic.Utils;

namespace Com.Hit.TurnoMatic
{
    public partial class FrmLlamarCliente : Form
    {

        public string PathSound
        {
            get
            {
                return System.Configuration.ConfigurationManager.AppSettings["pathSound"].ToString();
            }
        }

        private void LLamar()
        {
            LlamarCliente _llamarCliente = null;

            using (LlamarClienteService service = new LlamarClienteService())
            {
                _llamarCliente = service.GetLlamarCliente();
            }
            //
            if (_llamarCliente != null)
            {
                //            
                string fileNameNumero = string.Format("{0}.wav", _llamarCliente.NumeroTicket);
                //
                string fileNameCaja = string.Format("caja0{0}.wav", _llamarCliente.IdCaja);
                //
                SoundPlayer soundNumero = new SoundPlayer(string.Format("{0}\\Numeros\\{1}", this.PathSound, fileNameNumero));
                SoundPlayer soundCaja = new SoundPlayer(string.Format("{0}\\Cajas\\{1}", this.PathSound, fileNameCaja));
                //
                this.rTxtLlamandoCliente.Text += String.Format("Numero {0} a {1} Estatus {2}", _llamarCliente.NumeroTicket,_llamarCliente.Caja, _llamarCliente.Estatus) + System.Environment.NewLine;

                if (File.Exists(string.Format("{0}\\Numeros\\{1}", this.PathSound, fileNameNumero)))
                {
                    //
                    soundNumero.Play();
                }

                //
                System.Threading.Thread.Sleep(4000);
                //
                if (File.Exists(string.Format("{0}\\Cajas\\{1}", this.PathSound, fileNameCaja)))
                {
                    //
                    soundCaja.Play();
                }
                //
                using (LlamarClienteService service = new LlamarClienteService())
                {
                    service.ChangeLlamarCliente(_llamarCliente.NumeroTicket);
                }

                System.Threading.Thread.Sleep(2000);
            }
        }

        public FrmLlamarCliente()
        {
            InitializeComponent();
        }

        private void FrmLlamarCliente_Load(object sender, EventArgs e)
        {
            tmrLlamar.Enabled = true;
        }

        private void tmrLlamar_Tick(object sender, EventArgs e)
        {
            LLamar();
        }
   
    }
}
