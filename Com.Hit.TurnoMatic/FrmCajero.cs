using Com.Hit.TurnoMatic.Model;
using Com.Hit.TurnoMatic.Services;
using Com.Hit.TurnoMatic.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Com.Hit.TurnoMatic
{
    public partial class FrmCajero : Form
    {
        public const String TAG = "FrmCajero";
        private Ticket _ticketTrabajado = null;

        public string PathSound
        {
            get
            {
                return System.Configuration.ConfigurationManager.AppSettings["pathSound"].ToString();
            }
        }

        public int IdCaja
        {
            get
            {
                using (CajaService service = new CajaService())
                {
                    int IdCaja = service.GetCajaByIdUsuario(Session.Intance.CurrentSession.IdUsuario).IdCaja;

                    return IdCaja;
                }

            }
        }

        #region "Metodos"

        private String FormatNumero(int numero)
        {

            String rs = "";

            if (numero < 10)
            {
                rs = string.Format("00{0}", numero);
            }
            else if (numero >= 10 && numero <= 99)
            {
                rs = string.Format("0{0}", numero);
            }
            else
            {
                rs = numero.ToString();
            }

            return rs;
        }
        //
        private void BindingGrid()
        {
            using (CajaService _service = new CajaService())
            {
                this.gvListadodeColas.DataSource = _service.GetRevisionLista();
            }
        }
        //
        private void SiguienteTurno(IdTipoServicio TipoServicio)
        {

            switch (TipoServicio)
            {
                case IdTipoServicio.FP:
                    using (CajaService service = new CajaService())
                    {
                        int IdCaja = service.GetCajaByIdUsuario(Session.Intance.CurrentSession.IdUsuario).IdCaja;

                        _ticketTrabajado = service.TurnoSiguiente(1, IdCaja);

                        if (_ticketTrabajado != null)
                        {
                            this.lblNumTicket.Text = string.Format("FP-{0}", FormatNumero(_ticketTrabajado.Secuencia));
                        }

                    }
                    break;
                case IdTipoServicio.RV:
                    break;
                case IdTipoServicio.RL:
                    using (CajaService service = new CajaService())
                    {
                        int IdCaja = service.GetCajaByIdUsuario(Session.Intance.CurrentSession.IdUsuario).IdCaja;

                        _ticketTrabajado = service.TurnoSiguiente(3, IdCaja);

                        if (_ticketTrabajado != null)
                        {
                            this.lblNumTicket.Text = string.Format("RL-{0}", FormatNumero(_ticketTrabajado.Secuencia));
                        }

                    }
                    break;
                case IdTipoServicio.AC:
                    break;
                default:
                    break;
            }

        }
        //
        private void CasoAtendidoONoSePresento(EstatusTicket Estatus)
        {
            using (TicketService service = new TicketService())
            {
                if (_ticketTrabajado != null)
                {
                    service.ChangeEstatusTicket(_ticketTrabajado.IdTicket, Estatus);
                }
            }

            this.lblNumTicket.Text = "FP-000";
        }
        //
        private void TiempoEnCaja(int Opcion)
        {

            using (CajaService service = new CajaService())
            {
                int IdCaja = service.GetCajaByIdUsuario(Session.Intance.CurrentSession.IdUsuario).IdCaja;
                //
                service.TiempoEnCaja(IdCaja, _ticketTrabajado.IdTicket, Opcion);
            }

        }
        //
        private void LlamarCliente()
        {

            try
            {

                using (LlamarClienteService service = new LlamarClienteService())
                {
                    service.LlamarCliente(this.IdCaja, _ticketTrabajado.Secuencia);
                }

            }
            catch (Exception ex)
            {
                Com.Hit.TurnoMatic.Utils.Log.LogError(TAG, "GetCajaByIdUsuario", ex);
            }


        }
        //
        private void DesavilitaButtom(bool enabled)
        {
            btnAtendido.Enabled = enabled;
            btnNoSePresento.Enabled = enabled;
            btnLlamarCliente.Enabled = enabled;
            btnRevision.Enabled = enabled;
            btnCancelar.Enabled = enabled;
        }

        #endregion

        public FrmCajero()
        {
            InitializeComponent();
        }
        //
        private void FrmCajero_Load(object sender, EventArgs e)
        {
            lblNombreCajero.Text = "";
            lblNombreCajero.Text = String.Format("Cajero {0} {1}", Session.Intance.CurrentSession.Nombres, Session.Intance.CurrentSession.Apellidos);

            using (CajaService service = new CajaService())
            {
                lblCaja.Text = "";
                lblCaja.Text = service.GetCajaByIdUsuario(Session.Intance.CurrentSession.IdUsuario).Descripcion;
            }
            //
            BindingGrid();
            //
            DesavilitaButtom(false);
        }

        private void trBindingGrid_Tick(object sender, EventArgs e)
        {
            BindingGrid();
        }

        private void btnNuevoFP_Click(object sender, EventArgs e)
        {
            SiguienteTurno(IdTipoServicio.FP);
            //
            DesavilitaButtom(true);
            //
            if (_ticketTrabajado.IdTicket != 0)
            {
                DesavilitaButtom(true);
            }
        }

        private void btnNuevoRL_Click(object sender, EventArgs e)
        {
            SiguienteTurno(IdTipoServicio.RL);
            //
            if (_ticketTrabajado.IdTicket != 0)
            {
                DesavilitaButtom(true);
            }
            else {
                MessageBox.Show("No Hay casos Listos Revisión", "Turnos Hit V2.0 ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAtendido_Click(object sender, EventArgs e)
        {
            if (_ticketTrabajado.IdTicket != 0)
            {
                CasoAtendidoONoSePresento(EstatusTicket.Completado);
                //
                TiempoEnCaja(1);
                //
                DesavilitaButtom(false);
            }
        }

        private void btnNoSePresento_Click(object sender, EventArgs e)
        {
            if (_ticketTrabajado.IdTicket != 0)
            {
                CasoAtendidoONoSePresento(EstatusTicket.NosePresento);
                //
                DesavilitaButtom(false);
            }

        }

        private void btnRevision_Click(object sender, EventArgs e)
        {
            if (_ticketTrabajado.IdTicket != 0)
            {

                DialogResult rs = MessageBox.Show("Esta seguro que desea enviar este ticket a revision", "Turnos Hit V2.0 ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (rs == DialogResult.Yes)
                {
                    using (TicketService service = new TicketService())
                    {
                        service.EnviaRevision(IdCaja, _ticketTrabajado.IdTicket);
                        this.lblNumTicket.Text = "FP-000";
                    }
                }
            }
        }

        private void btnLlamarCliente_Click(object sender, EventArgs e)
        {

            if (_ticketTrabajado.IdTicket != 0)
            {
                LlamarCliente();
            }
            else
            {
                MessageBox.Show("Para Llamar a un cliente, debe seleccionar un ticket", "Turnos Hit V2.0 ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (_ticketTrabajado.IdTicket != 0)
            {

                DialogResult rs = MessageBox.Show("Esta seguro que desea Cancelar este Ticket", "Turnos Hit V2.0 ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (rs == DialogResult.Yes)
                {
                    using (TicketService service = new TicketService())
                    {
                        service.RegresarTicketCola(_ticketTrabajado.IdTicket);
                        this.lblNumTicket.Text = "FP-000";
                    }
                    //
                    DesavilitaButtom(false);

                }
            }
        }


    }
}
